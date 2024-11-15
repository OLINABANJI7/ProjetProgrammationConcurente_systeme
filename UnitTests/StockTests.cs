using FluentAssertions;
using Model;
using Xunit;

namespace Tests
{
    public class StockTests
    {
        [Fact]
        public void UpdateStock_ShouldIncreaseStockQuantity()
        {
            // Arrange
            var stock = Stock.GetInstance();
            stock.ingredients["Tomato"] = 10;

            // Act
            stock.updateStock("Tomato", 5);

            // Assert
            stock.ingredients["Tomato"].Should().Be(15);
        }

        [Fact]
        public void CheckAvailability_ShouldReturnTrueIfEnoughStock()
        {
            // Arrange
            var stock = Stock.GetInstance();
            stock.ingredients["Tomato"] = 10;

            // Act
            var result = stock.checkAvailability("Tomato", 5);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void CheckAvailability_ShouldReturnFalseIfNotEnoughStock()
        {
            // Arrange
            var stock = Stock.GetInstance();
            stock.ingredients["Tomato"] = 3;

            // Act
            var result = stock.checkAvailability("Tomato", 5);

            // Assert
            result.Should().BeFalse();
        }
    }
}
