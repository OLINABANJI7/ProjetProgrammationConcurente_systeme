using Project;
using Xunit;

namespace Project.Tests
{
    public class KitchenClerkTest
    {
        [Fact]
        public void DefaultConstructor_ShouldInitializeObject()
        {
            // Act
            var kitchenClerk = new KitchenClerk();

            // Assert
            Assert.NotNull(kitchenClerk); // Vérifie que l'objet est instancié
        }

        [Fact]
        public void ParameterizedConstructor_ShouldSetPosXAndPosY()
        {
            // Arrange
            int expectedPosX = 10;
            int expectedPosY = 15;

            // Act
            var kitchenClerk = new KitchenClerk(expectedPosX, expectedPosY);

            // Assert
            Assert.NotNull(kitchenClerk); // Vérifie que l'objet est instancié

            // Vérifie les valeurs des propriétés privées posX et posY
            var actualPosX = kitchenClerk.GetType().GetProperty("posX", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(kitchenClerk);
            var actualPosY = kitchenClerk.GetType().GetProperty("posY", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(kitchenClerk);

            Assert.Equal(expectedPosX, actualPosX);
            Assert.Equal(expectedPosY, actualPosY);
        }
    }
}
