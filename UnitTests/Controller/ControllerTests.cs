using System;
using Project;
using Xunit;

namespace Project.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void InitPerson_CreatesExpectedEntities()
        {
            // Arrange
            var model = new Model();
            var controller = new TestableController(model);

            // Act
            controller.InitPerson();

            // Assert
            Assert.NotNull(model.restaurationRoom.butler);
            Assert.NotNull(model.restaurationRoom.headWaiter);
            Assert.NotEmpty(model.restaurationRoom.waiters);
            Assert.NotNull(model.kitchen.chief);
            Assert.NotNull(model.kitchen.cook);
            Assert.NotNull(model.kitchen.plong);
            Assert.NotEmpty(model.restaurationRoom.clients);
        }

        // Testable Controller class to bypass the UI and threading
        private class TestableController : Controller
        {
            public TestableController(Model model) : base()
            {
                this.model = model;
            }

            public new void InitPerson()
            {
                base.InitPerson();
            }
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
        public Client butler { get; set; }
        public Client headWaiter { get; set; }
        public List<Client> waiters { get; set; } = new List<Client>();
        public List<Client> clients { get; set; } = new List<Client> { new Client() };
    }

    public class Kitchen
    {
        public Client chief { get; set; }
        public Client cook { get; set; }
        public Client plong { get; set; }
    }

    public class Client
    {
        public string Name { get; set; }
        public bool ordered { get; set; }
        public Etat state { get; set; }

        public enum Etat
        {
            attente,
            assis,
            commande,
            mange,
            finisRepas,
            payer,
            Fini
        }
    }
}