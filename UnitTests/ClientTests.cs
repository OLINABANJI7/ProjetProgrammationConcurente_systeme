using Model;
using FluentAssertions;

namespace Tests
{
    public class ClientTests
    {
        [Fact]
        public void PlaceOrder_ShouldCreateOrder()
        {
            // Arrange
            var client = new Client();

            // Act
            var order = client.placeOrder();

            // Assert
            order.Should().NotBeNull();
            order.client.Should().Be(client);
        }
    }
}
