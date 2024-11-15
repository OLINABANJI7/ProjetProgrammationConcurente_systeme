using Model;

namespace Tests
{
    public class OrderFactoryTests
    {
        [Fact]
        public void CreateOrder_ShouldReturnNewOrder()
        {
            // Arrange
            var client = new Client();
            var factory = new OrderFactory();

            // Act
            var order = factory.createOrder(client);

            // Assert
            Assert.NotNull(order);
            Assert.Equal(client, order.client);
        }
    }
}
