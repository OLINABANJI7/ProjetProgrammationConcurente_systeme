using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Project;
using Xunit;

namespace Project.Tests
{
    public class KitchenChiefControllerTests
    {
        [Fact]
        public void WatchLoop_DistributesOrdersToCooks()
        {
            // Arrange
            var model = new Model
            {
                kitchen = new Kitchen
                {
                    kitchenChef = new Cook { commands = new List<Order>() },
                    cooks = new List<Cook>
                    {
                        new Cook { commands = new List<Order>(), isAvailable = true },
                        new Cook { commands = new List<Order>(), isAvailable = true }
                    },
                    order = new List<Order>
                    {
                        new Order { plats = new List<string> { "Plat 1" } }
                    }
                }
            };

            var controller = new KitchenChiefController(model);

            // Act
            // Run WatchLoop in a separate task to simulate the background task
            var watchLoopTask = Task.Run(() => controller.WatchLoop());

            // Allow some time for the task to process
            Thread.Sleep(16000); // Wait long enough for the loop to execute

            // Assert
            Assert.Single(model.kitchen.kitchenChef.commands);
            Assert.Equal("Plat 1", model.kitchen.kitchenChef.commands[0].plats[0]);
            Assert.Equal(1, model.kitchen.cooks[0].commands.Count);
            Assert.Equal("Plat 1", model.kitchen.cooks[0].commands[0].plats[0]);

            // Clean up
            watchLoopTask.Dispose();
        }

        [Fact]
        public void WatchLoop_HandlesMultipleOrders()
        {
            // Arrange
            var model = new Model
            {
                kitchen = new Kitchen
                {
                    kitchenChef = new Cook { commands = new List<Order>() },
                    cooks = new List<Cook>
                    {
                        new Cook { commands = new List<Order>(), isAvailable = true },
                        new Cook { commands = new List<Order>(), isAvailable = true }
                    },
                    order = new List<Order>
                    {
                        new Order { plats = new List<string> { "Plat 1" } },
                        new Order { plats = new List<string> { "Plat 2" } }
                    }
                }
            };

            var controller = new KitchenChiefController(model);

            // Act
            var watchLoopTask = Task.Run(() => controller.WatchLoop());
            Thread.Sleep(16000); // Wait long enough for the loop to execute

            // Assert
            Assert.Equal(2, model.kitchen.kitchenChef.commands.Count);
            Assert.Equal("Plat 1", model.kitchen.kitchenChef.commands[0].plats[0]);
            Assert.Equal("Plat 2", model.kitchen.kitchenChef.commands[1].plats[0]);

            // Clean up
            watchLoopTask.Dispose();
        }

        // Testable class to simulate the environment
        private class Model
        {
            public Kitchen kitchen { get; set; } = new Kitchen();
        }

        private class Kitchen
        {
            public Cook kitchenChef { get; set; } = new Cook();
            public List<Cook> cooks { get; set; } = new List<Cook>();
            public List<Order> order { get; set; } = new List<Order>();
        }

        private class Order
        {
            public List<string> plats { get; set; } = new List<string>();
        }

        private class Cook
        {
            public List<Order> commands { get; set; } = new List<Order>();
            public bool isAvailable { get; set; }
        }
    }
}