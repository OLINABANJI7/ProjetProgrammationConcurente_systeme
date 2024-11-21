using Project;
using Xunit;
using SpriteLibrary;

namespace Project.Tests
{
    public class ClerkTest
    {
        [Fact]
        public void Constructor_ShouldInitializeSpriteToNull()
        {
            // Arrange
            int initialPosX = 5;
            int initialPosY = 10;

            // Act
            Clerk clerk = new Clerk(initialPosX, initialPosY);

            // Assert
            Assert.Null(clerk.sprite); // sprite n'est pas initialisé dans le constructeur
        }
    }
}
