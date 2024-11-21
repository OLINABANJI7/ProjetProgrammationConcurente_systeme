using Project;
using Xunit;

namespace Project.Tests.Model
{
    public class SquareTest
    {
        [Fact]
        public void Constructor_ShouldInitializeSquare1()
        {
            var square = new Square(1);

            Assert.NotNull(square.ranks);
            Assert.Equal(2, square.ranks.Count);
            Assert.NotNull(square.headWaiter);
            Assert.NotNull(square.waiters);
            Assert.Equal(2, square.waiters.Count);
        }

        [Fact]
        public void Constructor_ShouldInitializeSquare2()
        {
            var square = new Square(2);

            Assert.NotNull(square.ranks);
            Assert.Equal(2, square.ranks.Count);
            Assert.NotNull(square.headWaiter);
            Assert.NotNull(square.waiters);
            Assert.Equal(2, square.waiters.Count);
        }

        [Fact]
        public void Constructor_ShouldInitializeWithNullRanksForDefault()
        {
            var square = new Square(0);

            Assert.Null(square.ranks);
        }
    }
}
