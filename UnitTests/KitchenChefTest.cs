using Project;
using SpriteLibrary;
using Xunit;

namespace Project.Tests
{
    public class KitchenChefTest
    {
        [Fact]
        public void Constructor_ShouldInitializePositionCorrectly()
        {
            // Arrange
            int expectedPosX = 10;
            int expectedPosY = 20;

            // Act
            var kitchenChef = new KitchenChef(expectedPosX, expectedPosY);

            // Assert
            Assert.NotNull(kitchenChef); // Vérifie que l'objet est créé
            Assert.Equal(expectedPosX, kitchenChef.posX); // Vérifie la position X
            Assert.Equal(expectedPosY, kitchenChef.posY); // Vérifie la position Y
        }

        [Fact]
        public void Commands_ShouldBeInitializedEmpty()
        {
            // Arrange
            var kitchenChef = new KitchenChef(0, 0);

            // Act & Assert
            Assert.NotNull(kitchenChef.commands); // Vérifie que la liste des commandes est initialisée
            Assert.Empty(kitchenChef.commands); // Vérifie que la liste est vide par défaut
        }

        [Fact]
        public void Sprite_ShouldBeNullByDefault()
        {
            // Arrange
            var kitchenChef = new KitchenChef(0, 0);

            // Act & Assert
            Assert.Null(kitchenChef.sprite); // Vérifie que sprite est null par défaut
        }
    }
}
