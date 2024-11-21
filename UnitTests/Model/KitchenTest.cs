using Project;
using Xunit;

namespace Project.Tests.Model
{
    public class KitchenTest
    {
        [Fact]
        public void DefaultConstructor_ShouldInitializeComponents()
        {
            // Act
            var kitchen = new Kitchen();

            // Assert
            Assert.NotNull(kitchen); // Vérifie que l'objet Kitchen est créé

            // Vérifie que le chef de cuisine est instancié
            Assert.NotNull(kitchen.kitchenChef);
            Assert.Equal(1055, kitchen.kitchenChef.posX);
            Assert.Equal(110, kitchen.kitchenChef.posY);

            // Vérifie que la liste des cuisiniers est créée et contient les bons éléments
            Assert.NotNull(kitchen.cooks);
            Assert.Equal(2, kitchen.cooks.Count); // Vérifie qu'il y a 2 cuisiniers

            Assert.Equal(955, kitchen.cooks[0].posX);
            Assert.Equal(110, kitchen.cooks[0].posY);

            Assert.Equal(1212, kitchen.cooks[1].posX);
            Assert.Equal(110, kitchen.cooks[1].posY);

            // Vérifie que le plongeur est instancié
            Assert.NotNull(kitchen.plong);

            // Vérifie que la liste des commandes est créée
            Assert.NotNull(kitchen.order);
            Assert.Empty(kitchen.order); // Par défaut, elle doit être vide
        }
    }
}
