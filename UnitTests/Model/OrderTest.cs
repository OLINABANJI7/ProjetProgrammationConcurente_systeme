using Project;
using Xunit;

namespace Project.Tests.Model
{
    public class OrderTest
    {
        [Fact]
        public void Constructor_ShouldInitializePlats()
        {
            var order = new Order();

            Assert.NotNull(order.plats);
            Assert.Empty(order.plats);
        }

        [Fact]
        public void Constructor_ShouldAllowAddingPlats()
        {
            var order = new Order();
            order.plats.Add("A1");
            order.plats.Add("B2");

            Assert.Equal(2, order.plats.Count);
            Assert.Contains("A1", order.plats);
            Assert.Contains("B2", order.plats);
        }
    }
}
