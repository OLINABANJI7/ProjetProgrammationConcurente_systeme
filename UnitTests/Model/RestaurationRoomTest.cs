using Project;
using Xunit;

namespace Project.Tests.Model
{
    public class RestaurationRoomTest
    {
        [Fact]
        public void Constructor_ShouldInitializeRestaurationRoom()
        {
            var restaurationRoom = new RestaurationRoom();

            Assert.NotNull(restaurationRoom.squares);
            Assert.Equal(2, restaurationRoom.squares.Count);
            Assert.NotNull(restaurationRoom.butler);
            Assert.NotNull(restaurationRoom.clerk);
            Assert.NotNull(restaurationRoom.clients);
            Assert.Equal(1, restaurationRoom.clients.Count);
        }
    }
}
