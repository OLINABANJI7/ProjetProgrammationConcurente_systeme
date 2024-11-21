using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Project;
using Xunit;

namespace Project.Tests.Controller
{
    public class TableControllerTests
    {
        [Fact]
        public void WatchLoop_ProcessesClientOrdersAndServesBread()
        {
            // Arrange
            var model = new Model
            {
                restaurationRoom = new RestaurationRoom
                {
                    squares = new List<Square>
                    {
                        new Square
                        {
                            waiters = new List<Waiter>
                            {
                                new Waiter { available = true, sprite = new Sprite() }
                            },
                            ranks = new List<Rank>
                            {
                                new Rank
                                {
                                    tables = new List<Table>
                                    {
                                        new Table
                                        {
                                            numberTable = 1,
                                            client = new Client { ordered = false },
                                            bread = false,
                                            served = false
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            var controller = new TableController(model);

            // Act
            var watchLoopTask = Task.Run(() => controller.WatchLoop());
            Thread.Sleep(6000); // Wait long enough for the loop to process

            // Assert
            var table = model.restaurationRoom.squares[0].ranks[0].tables[0];
            Assert.True(table.client.ordered);
            Assert.True(table.bread);
            Assert.False(table.served); // Assuming served is not handled in this short wait
            watchLoopTask.Dispose(); // Clean up the task
        }

        [Fact]
        public void WatchLoop_ServesFoodWhenClientOrders()
        {
            // Arrange
            var model = new Model
            {
                restaurationRoom = new RestaurationRoom
                {
                    squares = new List<Square>
                    {
                        new Square
                        {
                            waiters = new List<Waiter>
                            {
                                new Waiter { available = true, sprite = new Sprite() }
                            },
                            ranks = new List<Rank>
                            {
                                new Rank
                                {
                                    tables = new List<Table>
                                    {
                                        new Table
                                        {
                                            numberTable = 1,
                                            client = new Client { ordered = true },
                                            bread = true,
                                            served = false
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            var controller = new TableController(model);

            // Act
            var watchLoopTask = Task.Run(() => controller.WatchLoop());
            Thread.Sleep(6000); // Wait long enough for the loop to process

            // Assert
            var table = model.restaurationRoom.squares[0].ranks[0].tables[0];
            Assert.True(table.served); // Assuming the food service logic is executed
            watchLoopTask.Dispose(); // Clean up the task
        }

        // Testable classes to simulate the environment
        private class Model
        {
            public RestaurationRoom restaurationRoom { get; set; } = new RestaurationRoom();
        }

        private class RestaurationRoom
        {
            public List<Square> squares { get; set; } = new List<Square>();
        }

        private class Square
        {
            public List<Waiter> waiters { get; set; } = new List<Waiter>();
            public List<Rank> ranks { get; set; } = new List<Rank>();
        }

        private class Waiter
        {
            public bool available { get; set; }
            public Sprite sprite { get; set; }
        }

        private class Rank
        {
            public List<Table> tables { get; set; } = new List<Table>();
        }

        private class Table
        {
            public int numberTable { get; set; }
            public Client client { get; set; }
            public bool bread { get; set; }
            public bool served { get; set; }
        }

        private class Client
        {
            public bool ordered { get; set; }
        }

        private class Sprite
        {
            // Simulated Sprite class
        }

        private class Commandes
        {
            public Commandes(Model model) { }
            public void Go4Bread(Sprite sprite) { }
            public void GoToTable(Sprite sprite, int tableNumber) { }
            public void GoToKitchenPLAT(Sprite sprite) { }
        }
    }
}