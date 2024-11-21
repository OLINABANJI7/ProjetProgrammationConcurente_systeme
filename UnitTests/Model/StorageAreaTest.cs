using Project;
using Xunit;

namespace Project.Tests.Model
{
    public class StorageAreaTest
    {
        [Fact]
        public void Constructor_ShouldInitializeIngredientsList()
        {
            // Act
            var storageArea = new StorageArea();

            // Assert
            Assert.NotNull(storageArea);
            Assert.Single(storageArea.GetType().GetField("ingredients", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(storageArea) as List<string>);
        }

        [Fact]
        public void Constructor_ShouldAddEmptyStringToIngredients()
        {
            // Act
            var storageArea = new StorageArea();

            // Assert
            var ingredients = storageArea.GetType().GetField("ingredients", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(storageArea) as List<string>;
            Assert.Contains("", ingredients);
        }
    }
}
