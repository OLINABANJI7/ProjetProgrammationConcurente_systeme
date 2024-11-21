using Xunit;
using System.Collections.Generic;

namespace Project.Tests.Model
{
    public class MenuTest
    {
        [Fact]
        public void DefaultConstructor_ShouldInitializePlats()
        {
            // Act
            var menu = new Menu();

            // Assert
            Assert.NotNull(menu); // Vérifie que l'objet Menu est créé
            Assert.NotNull(menu.plats); // Vérifie que la liste plats est instanciée

            // Vérifie que la liste contient exactement 9 plats
            Assert.Equal(9, menu.plats.Count);

            // Vérifie que les plats ajoutés sont corrects
            var expectedPlats = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };
            Assert.Equal(expectedPlats, menu.plats); // Compare les listes
        }
    }
}
