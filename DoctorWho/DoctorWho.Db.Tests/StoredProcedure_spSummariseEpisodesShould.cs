using Xunit;

namespace DoctorWho.Db.Tests
{
    public class StoredProcedure_spSummariseEpisodesShould
    {
        private SqlCommander _sqlCommander;

        public StoredProcedure_spSummariseEpisodesShould()
        {
            _sqlCommander = new SqlCommander();
        }

        [Fact]
        public void spSummariseEpisodesShouldHave2Tables()
        {
            // -- Arrange
            var resultSet = _sqlCommander.ExecuteSqlCommand("EXECUTE spSummariseEpisodes");

            // -- Assert
            Assert.Equal(2, resultSet.Tables.Count);
        }

        [Fact]
        public void spSummariseEpisodesShouldHave3RowsInEachTable()
        {
            // -- Arrange
            var resultSet = _sqlCommander.ExecuteSqlCommand("EXECUTE spSummariseEpisodes");

            // -- Assert
            Assert.Equal(3, resultSet.Tables[0].Rows.Count);
            Assert.Equal(3, resultSet.Tables[1].Rows.Count);
        }
    }
}
