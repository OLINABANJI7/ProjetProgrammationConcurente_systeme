using System;
using System.Collections.Generic;
using Project;
using Xunit;

namespace Project.Tests.Controller
{
    public class CommandesTests
    {
        [Fact]
        public void LetsOrder_AddsOrderToKitchen_WhenCalled()
        {
            // Arrange
            var model = new Model
            {
                kitchen = new Kitchen
                {
                    order = new List<Order>()
                },
                menu = new Menu
                {
                    plats = new List<Plat>
                    {
                        new Plat { Name = "Plat 1" },
                        new Plat { Name = "Plat 2" },
                        new Plat { Name = "Plat 3" },
                        new Plat { Name = "Plat 4" },
                        new Plat { Name = "Plat 5" },
                        new Plat { Name = "Plat 6" },
                        new Plat { Name = "Plat 7" },
                        new Plat { Name = "Plat 8" }
                    }
                }
            };

            var client = new Client { ordered = false };
            var commandes = new Commandes(model);

            // Act
            commandes.LetsOrder(client);

            // Assert
            Assert.True(client.ordered);
            Assert.Single(model.kitchen.order);
            Assert.NotEmpty(model.kitchen.order[0].plats);
        }
    }

    // Classes simulées pour les tests
    public class Model
    {
        public Kitchen kitchen { get; set; }
        public Menu menu { get; set; }
    }

    public class Kitchen
    {
        public List<Order> order { get; set; }
    }

    public class Order
    {
        public List<Plat> plats { get; set; } = new List<Plat>();
    }

    public class Menu
    {
        public List<Plat> plats { get; set; }
    }

    public class Plat
    {
        public string Name { get; set; }
    }

    public class Client
    {
        public bool ordered { get; set; }
    }
}