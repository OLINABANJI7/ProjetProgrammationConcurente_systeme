using Xunit;

namespace Project.Tests.Model
{
    public class DishWashingTest
    {
        [Fact]
        public void Constructor_ShouldInitializeWasherUpCorrectly()
        {
            // Act
            var dishWashing = new DishWashing();

            // Assert
            Assert.NotNull(dishWashing); // Vérifie que l'objet DishWashing est créé
            var washerUpField = typeof(DishWashing)
                .GetField("washerUp", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.NotNull(washerUpField); // Vérifie que le champ washerUp existe
            var washerUp = washerUpField.GetValue(dishWashing) as WasherUp;
            Assert.NotNull(washerUp); // Vérifie que washerUp est initialisé
            Assert.Equal(1, washerUp.posX);
            Assert.Equal(2, washerUp.posY);
        }

        [Fact]
        public void DishWashing_ShouldHaveDefaultMachineStates()
        {
            // Act
            var dishWashing = new DishWashing();

            // Assert
            var washingMachineField = typeof(DishWashing)
                .GetField("washingMachine", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var dishWasherField = typeof(DishWashing)
                .GetField("dishWasher", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            Assert.NotNull(washingMachineField);
            Assert.NotNull(dishWasherField);

            Assert.False((bool)washingMachineField.GetValue(dishWashing)); // Machine à laver par défaut
            Assert.False((bool)dishWasherField.GetValue(dishWashing)); // Lave-vaisselle par défaut
        }
    }
}
