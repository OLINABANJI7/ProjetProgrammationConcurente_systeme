using Project;
using Xunit;

namespace Project.Tests.Model
{
    public class RankTest
    {
        [Fact]
        public void Constructor_ShouldInitializeTablesForRank1()
        {
            var rank = new Rank(1);

            Assert.NotNull(rank.tables);
            Assert.Equal(9, rank.tables.Count);
        }

        [Fact]
        public void Constructor_ShouldInitializeTablesForRank2()
        {
            var rank = new Rank(2);

            Assert.NotNull(rank.tables);
            Assert.Equal(8, rank.tables.Count);
        }

        [Fact]
        public void Constructor_ShouldInitializeTablesForRank3()
        {
            var rank = new Rank(3);

            Assert.NotNull(rank.tables);
            Assert.Equal(6, rank.tables.Count);
        }

        [Fact]
        public void Constructor_ShouldInitializeTablesForRank4()
        {
            var rank = new Rank(4);

            Assert.NotNull(rank.tables);
            Assert.Equal(10, rank.tables.Count);
        }

        [Fact]
        public void Constructor_ShouldNotInitializeTablesForInvalidRank()
        {
            var rank = new Rank(0);

            Assert.NotNull(rank.tables);
            Assert.Empty(rank.tables);
        }
    }
}
