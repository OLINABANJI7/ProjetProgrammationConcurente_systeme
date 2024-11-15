using Model;
using FluentAssertions;

namespace Tests
{
    public class OrderTests
    {
        [Fact]
        public void UpdateStatus_ShouldChangeStatus()
        {
            // Arrange
            var order = new Order();

            // Act
            order.updateStatus("Prepared");

            // Assert
            order.status.Should().Be("Prepared");
        }
    }
}
