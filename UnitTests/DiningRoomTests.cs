using Xunit;
using FluentAssertions;
using Model;

namespace Tests
{
    public class DiningRoomTests
    {

        [Fact]
        public void AssignTable_ShouldAddTableToClient()
        {
            // Arrange
            var diningRoom = new DiningRoom();
            var client = new Client();
            var table = new Table(1,4);

            // Act
            diningRoom.AssignTable(client, table);

            // Assert
            client.table.Should().Be(table);
            table.isAvailable.Should().BeFalse();
        }

        [Fact]
        public void FreeTable_ShouldAddTableToClient()
        {
            // Arrange
            var diningRoom = new DiningRoom();
            var table = new Table(1,4);

            // Act
            diningRoom.freeTable(table);

            // Assert
            table.isAvailable.Should().BeTrue();
        }
    }
}
