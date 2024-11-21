using Project;
using Xunit;

namespace Project.Tests
{
    public class KitchenClerkTest
    {
        [Fact]
        public void DefaultConstructor_ShouldInitializeStorageArea()
        {
            // Act
            var kitchenClerk = new KitchenClerk();

            // Assert
            Assert.NotNull(kitchenClerk); // Vérifie que l'objet est créé
        }

        [Fact]
        public void ParameterizedConstructor_ShouldInitializePositionCorrectly()
        {
            // Arrange
            int expectedPosX = 10;
            int expectedPosY = 15;

            // Act
            var kitchenClerk = new KitchenClerk(expectedPosX, expectedPosY);

            // Assert
            Assert.NotNull(kitchenClerk); // Vérifie que l'objet est créé
            Assert.Equal(expectedPosX, kitchenClerk.GetType().GetProperty("posX", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(kitchenClerk));
            Assert.Equal(expectedPosY, kitchenClerk.GetType().GetProperty("posY", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(kitchenClerk));
        }
    }
}
