using Xunit;
using p=Project;

namespace Project.Tests.Model
{
    public class ModelTest
    {
        [Fact]
        public void DefaultConstructor_ShouldInitializeComponents()
        {
            var model = new p.Model();

            Assert.NotNull(model);
            Assert.NotNull(model.restaurationRoom);
            Assert.NotNull(model.kitchen);
            Assert.NotNull(model.menu);
        }

        [Fact]
        public void DefaultConstructor_ShouldInitializeMenuWithPlats()
        {
            var model = new p.Model();

            Assert.NotNull(model.menu.plats);
            Assert.NotEmpty(model.menu.plats);
        }

        [Fact]
        public void DefaultConstructor_ShouldInitializeKitchenComponents()
        {
            var model = new p.Model();

            Assert.NotNull(model.kitchen.kitchenChef);
            Assert.NotNull(model.kitchen.cooks);
            Assert.NotEmpty(model.kitchen.cooks);
            Assert.NotNull(model.kitchen.plong);
        }

        [Fact]
        public void DefaultConstructor_ShouldInitializeRestaurationRoom()
        {
            var model = new p.Model();

            Assert.NotNull(model.restaurationRoom);
        }
    }
}
