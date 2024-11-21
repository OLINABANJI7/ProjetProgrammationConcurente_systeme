using Project;
using Xunit;

namespace Project.Tests.Model
{
    public class WaiterTest
    {
        [Fact]
        public void Constructor_ShouldInitializePosition()
        {
            // Arrange
            int expectedPosX = 10;
            int expectedPosY = 20;

            // Act
            var waiter = new Waiter(expectedPosX, expectedPosY);

            // Assert
            Assert.NotNull(waiter);
            Assert.Equal(expectedPosX, waiter.posX);
            Assert.Equal(expectedPosY, waiter.posY);
        }

        [Fact]
        public void Constructor_ShouldInitializeSpriteAsNull()
        {
            // Act
            var waiter = new Waiter(10, 20);

            // Assert
            Assert.Null(waiter.sprite);
        }

        [Fact]
        public void Constructor_ShouldInitializeAvailableAsDefaultTrue()
        {
            // Act
            var waiter = new Waiter(10, 20);

            // Assert
            Assert.True(waiter.available);  // Default value for bool is false
        }
    }
}
