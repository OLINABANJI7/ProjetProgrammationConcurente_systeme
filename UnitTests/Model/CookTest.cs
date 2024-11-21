using Xunit;
using System.Collections.Generic;

namespace Project.Tests.Model
{
    public class CookTest
    {
        [Fact]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            int initialPosX = 10;
            int initialPosY = 20;

            // Act
            var cook = new Cook(initialPosX, initialPosY);

            // Assert
            Assert.Equal(initialPosX, cook.posX);
            Assert.Equal(initialPosY, cook.posY);
            Assert.True(cook.isAvailable); // Vérifie que le cuisinier est disponible par défaut
            Assert.NotNull(cook.commands); // Vérifie que la liste des commandes est initialisée
            Assert.Empty(cook.commands); // La liste des commandes est vide au début
        }
    }
}
