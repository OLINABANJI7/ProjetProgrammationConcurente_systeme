using Model;

namespace Tests
{
    public class TableTests
    {
        [Fact]
        public void Reserve_ShouldSetIsAvailableToFalse()
        {
            // Arrange
            var table = new Table(1, 4);

            // Act
            table.reserve();

            // Assert
            Assert.False(table.isAvailable);
        }

        [Fact]
        public void Free_ShouldSetIsAvailableToTrue()
        {
            // Arrange
            var table = new Table(1, 4, false);

            // Act
            table.free();

            // Assert
            Assert.True(table.isAvailable);
        }
    }
}
