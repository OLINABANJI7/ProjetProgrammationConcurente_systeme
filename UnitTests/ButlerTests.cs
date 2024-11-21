using Project;
using Xunit;
using SpriteLibrary;

namespace Project.Tests
{
    public class ButlerTests
    {
        [Fact]
        public void Constructor_ShouldInitializePosXAndPosY()
        {
            // Arrange
            int initialPosX = 5;
            int initialPosY = 10;

            // Act
            Butler butler = new Butler(initialPosX, initialPosY);

            // Assert
            Assert.Equal(initialPosX, butler.posX);
            Assert.Equal(initialPosY, butler.posY);
            Assert.Null(butler.sprite); // sprite n'est pas défini dans le constructeur
        }

        [Fact]
        public void Set_PosX_ShouldUpdateValue()
        {
            // Arrange
            Butler butler = new Butler(0, 0);

            // Act
            butler.posX = 20;

            // Assert
            Assert.Equal(20, butler.posX);
        }

        [Fact]
        public void Set_PosY_ShouldUpdateValue()
        {
            // Arrange
            Butler butler = new Butler(0, 0);

            // Act
            butler.posY = 15;

            // Assert
            Assert.Equal(15, butler.posY);
        }

    }
}
