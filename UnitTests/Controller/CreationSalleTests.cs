using System;
using System.Collections.Generic;
using System.Drawing;
using Project;
using Xunit;

namespace Project.Tests
{
    public class CreationSalleTests
    {
        [Fact]
        public void CreateButler_SetsUpButlerCorrectly()
        {
            // Arrange
            var model = new Model
            {
                restaurationRoom = new RestaurationRoom
                {
                    butler = new Client { posX = 0, posY = 64 }
                }
            };
            var form = new Form1();
            var creationSalle = new CreationSalle(model, form);

            // Act
            creationSalle.CreateButler();

            // Assert
            Assert.NotNull(model.restaurationRoom.butler.sprite);
            Assert.Equal("Butler", model.restaurationRoom.butler.sprite.SpriteName);
            Assert.Equal(new Point(0, 64), model.restaurationRoom.butler.sprite.BaseImageLocation);
        }

        [Fact]
        public void CreateWaiters_SetsUpWaitersCorrectly()
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
                                new Waiter { posX = 288, posY = 128 }
                            }
                        }
                    }
                }
            };
            var form = new Form1();
            var creationSalle = new CreationSalle(model, form);

            // Act
            creationSalle.CreateWaiters();

            // Assert
            var waiter = model.restaurationRoom.squares[0].waiters[0];
            Assert.NotNull(waiter.sprite);
            Assert.Equal("Waiter", waiter.sprite.SpriteName);
            Assert.Equal(new Point(288, 128), waiter.sprite.BaseImageLocation);
        }

        [Fact]
        public void CreateHeadWaiter_SetsUpHeadWaiterCorrectly()
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
                            headWaiter = new Waiter { posX = 0, posY = 128 }
                        }
                    }
                }
            };
            var form = new Form1();
            var creationSalle = new CreationSalle(model, form);

            // Act
            creationSalle.CreateHeadWaiter();

            // Assert
            var headWaiter = model.restaurationRoom.squares[0].headWaiter;
            Assert.NotNull(headWaiter.sprite);
            Assert.Equal("HServeur", headWaiter.sprite.SpriteName);
            Assert.Equal(new Point(0, 128), headWaiter.sprite.BaseImageLocation);
        }
    }

    public class CreationCuisineTests
    {
        [Fact]
        public void CreateCook_SetsUpCookCorrectly()
        {
            // Arrange
            var model = new Model
            {
                kitchen = new Kitchen
                {
                    cooks = new List<Cook>
                    {
                        new Cook { posX = 96, posY = 0 }
                    }
                }
            };
            var form = new Form1();
            var creationCuisine = new CreationCuisine(model, form);

            // Act
            creationCuisine.CreateCook();

            // Assert
            var cook = model.kitchen.cooks[0];
            Assert.NotNull(cook.sprite);
            Assert.Equal("Cook", cook.sprite.SpriteName);
            Assert.Equal(new Point(96, 0), cook.sprite.BaseImageLocation);
        }

        [Fact]
        public void CreateChief_SetsUpChiefCorrectly()
        {
            // Arrange
            var model = new Model
            {
                kitchen = new Kitchen
                {
                    kitchenChef = new Cook { posX = 286, posY = 0 }
                }
            };
            var form = new Form1();
            var creationCuisine = new CreationCuisine(model, form);

            // Act
            creationCuisine.CreateChief();

            // Assert
            var chief = model.kitchen.kitchenChef;
            Assert.NotNull(chief.sprite);
            Assert.Equal("Chef", chief.sprite.SpriteName);
            Assert.Equal(new Point(286, 0), chief.sprite.BaseImageLocation);
        }

        [Fact]
        public void CreatePlong_SetsUpPlongeurCorrectly()
        {
            // Arrange
            var model = new Model
            {
                kitchen = new Kitchen
                {
                    plong = new Cook { posX = 96, posY = 128 }
                }
            };
            var form = new Form1();
            var creationCuisine = new CreationCuisine(model, form);

            // Act
            creationCuisine.CreatePlong();

            // Assert
            var plongeur = model.kitchen.plong;
            Assert.NotNull(plongeur.sprite);
            Assert.Equal("Plongeur", plongeur.sprite.SpriteName);
            Assert.Equal(new Point(96, 128), plongeur.sprite.BaseImageLocation);
        }
    }

    public class CreationClientTests
    {
        [Fact]
        public void CreateClient_SetsUpClientCorrectly()
        {
            // Arrange
            var model = new Model
            {
                restaurationRoom = new RestaurationRoom
                {
                    clients = new List<Client>
                    {
                        new Client { posX = 286, posY = 0 }
                    }
                }
            };
            var form = new Form1();
            var creationClient = new CreationClient(model, form);

            // Act
            creationClient.CreateClient();

            // Assert
            var client = model.restaurationRoom.clients[0];
            Assert.NotNull(client.sprite);
            Assert.Equal("Client", client.sprite.SpriteName);
            Assert.Equal(new Point(1375, 900), client.sprite.BaseImageLocation);
        }
    }

    // Classes simulées pour les tests
    public class Model
    {
        public RestaurationRoom restaurationRoom { get; set; } = new RestaurationRoom();
        public Kitchen kitchen { get; set; } = new Kitchen();
    }

    public class RestaurationRoom
    {
        public Client butler { get; set; } = new Client();
        public List<Square> squares { get; set; } = new List<Square>();
        public List<Client> clients { get; set; } = new List<Client>();
    }

    public class Kitchen
    {
        public List<Cook> cooks { get; set; } = new List<Cook>();
        public Cook kitchenChef { get; set; } = new Cook();
        public Cook plong { get; set; } = new Cook();
    }

    public class Square
    {
        public List<Waiter> waiters { get; set; } = new List<Waiter>();
        public Waiter headWaiter { get; set; } = new Waiter();
    }

    public class Waiter
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public Sprite sprite { get; set; }
    }

    public class Cook
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public Sprite sprite { get; set; }
    }

    public class Client
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public Sprite sprite { get; set; }
    }

    public class Sprite
    {
        public string SpriteName { get; private set; }
        public Point BaseImageLocation { get; private set; }

        public Sprite(Point location, object spriteController, object resource, int width, int height, int speed, int frameCount)
        {
            // Constructor logic
        }

        public void SetName(string name)
        {
            SpriteName = name;
        }

        public void PutBaseImageLocation(Point location)
        {
            BaseImageLocation = location;
        }

        public void MoveTo(Point location)
        {
            // Move logic
        }

        public void SetSize(Size size)
        {
            // Resize logic
        }

        public bool CannotMoveOutsideBox { get; set; }
        public bool AutomaticallyMoves { get; set; }
        public int MovementSpeed { get; set; }
    }

    public class Form1
    {
        // Simulated Form class
        public object spriteController { get; set; }
    }
}