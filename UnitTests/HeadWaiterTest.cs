using Project;
using SpriteLibrary;
using Xunit;

namespace UniProject.TeststTests
{
    public class HeadWaiterTest
    {
        [Fact]
        public void Constructor_ShouldInitializePositionCorrectly()
        {
            // Arrange
            int expectedPosX = 5;
            int expectedPosY = 10;

            // Act
            var headWaiter = new HeadWaiter(expectedPosX, expectedPosY);

            // Assert
            Assert.NotNull(headWaiter); // Vérifie que l'objet est créé
            Assert.Equal(expectedPosX, headWaiter.posX); // Vérifie la position X
            Assert.Equal(expectedPosY, headWaiter.posY); // Vérifie la position Y
        }

        [Fact]
        public void Sprite_ShouldBeNullByDefault()
        {
            // Arrange
            var headWaiter = new HeadWaiter(0, 0);

            // Act & Assert
            Assert.Null(headWaiter.sprite); 
        }

    }
}
