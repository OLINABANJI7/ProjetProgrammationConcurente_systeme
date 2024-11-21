using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Project;
using Xunit;

namespace Project.Tests
{
    public class CookControllerTests
    {
        [Fact]
        public void WatchLoop_MakesCookGoToFridge_WhenCookIsNotAvailable()
        {
            // Arrange
            var model = new Model
            {
                kitchen = new Kitchen
                {
                    cooks = new List<Cook>
                    {
                        new Cook
                        {
                            isAvailable = false,
                            sprite = new Sprite { SpriteName = "Cook 1" },
                            commands = new List<string> { "Order 1" }
                        }
                    }
                }
            };

            var controller = new TestableCookController(model);

            // Act
            // We run the WatchLoop in a separate task to simulate the background task
            var watchLoopTask = Task.Run(() => controller.WatchLoop());

            // Allow some time for the task to process
            Thread.Sleep(15000); // Wait long enough for the loop to execute

            // Assert
            Assert.True(model.kitchen.cooks[0].isAvailable);
            Assert.Empty(model.kitchen.cooks[0].commands);
            watchLoopTask.Dispose(); // Clean up the task
        }

        // Testable CookController class to bypass the threading and UI
        private class TestableCookController : CookController
        {
            public TestableCookController(Model model) : base(model) { }

            public new void WatchLoop()
            {
                base.WatchLoop();
            }
        }
    }

    // Classes simulées pour les tests
    public class Model
    {
        public Kitchen kitchen { get; set; } = new Kitchen();
    }

    public class Kitchen
    {
        public List<Cook> cooks { get; set; } = new List<Cook>();
    }

    public class Cook
    {
        public bool isAvailable { get; set; }
        public Sprite sprite { get; set; }
        public List<string> commands { get; set; } = new List<string>();
    }

    public class Sprite
    {
        public string SpriteName { get; set; }
    }

    public class Commandes
    {
        public Commandes(Model model) { }

        public void GoToFridge(Sprite sprite)
        {
            // Simulated logic for going to the fridge
        }

        public void GoToKitchenPLAT(Sprite sprite)
        {
            // Simulated logic for going to the kitchen to drop off plates
        }
    }
}