using Project;
using Xunit;

namespace Project.Tests.Model
{
    public class WasherUpTest
    {
        [Fact]
        public void Constructor_ShouldInitializePosition()
        {
            // Arrange
            int expectedPosX = 10;
            int expectedPosY = 20;

            // Act
            var washerUp = new WasherUp(expectedPosX, expectedPosY);

            // Assert
            Assert.NotNull(washerUp);
            Assert.Equal(expectedPosX, washerUp.posX);
            Assert.Equal(expectedPosY, washerUp.posY);
        }

        [Fact]
        public void Constructor_ShouldInitializeSpriteAsNull()
        {
            // Act
            var washerUp = new WasherUp(10, 20);

            // Assert
            Assert.Null(washerUp.sprite);
        }
    }
}
