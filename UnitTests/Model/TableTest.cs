using Project;
using Xunit;

namespace Project.Tests.Model
{
    public class TableTest
    {
        [Fact]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            int expectedPosX = 100;
            int expectedPosY = 200;
            int expectedNumberOfPlace = 4;
            int expectedNumberTable = 1;

            // Act
            var table = new Table(expectedPosX, expectedPosY, expectedNumberOfPlace, expectedNumberTable);

            // Assert
            Assert.NotNull(table);
            Assert.Equal(expectedPosX, table.posX);
            Assert.Equal(expectedPosY, table.posY);
            Assert.Equal(expectedNumberOfPlace, table.numberOfPlace);
            Assert.Equal(expectedNumberTable, table.numberTable);
        }

        [Fact]
        public void Constructor_ShouldSetDefaultValues()
        {
            // Act
            var table = new Table(100, 200, 4, 1);

            // Assert
            Assert.True(table.avaible);
            Assert.False(table.bread);
            Assert.False(table.water);
            Assert.Null(table.client);
        }

        [Fact]
        public void Properties_ShouldBeSettable()
        {
            // Arrange
            var table = new Table(100, 200, 4, 1);
            var client = new Client(2);

            // Act
            table.avaible = false;
            table.bread = true;
            table.water = true;
            table.served = true;
            table.client = client;

            // Assert
            Assert.False(table.avaible);
            Assert.True(table.bread);
            Assert.True(table.water);
            Assert.True(table.served);
            Assert.Equal(client, table.client);
        }
    }
}
