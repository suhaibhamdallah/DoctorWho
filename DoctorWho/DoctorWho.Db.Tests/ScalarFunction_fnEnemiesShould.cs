using Xunit;

namespace DoctorWho.Db.Tests
{
    public class ScalarFunction_fnEnemiesShould
    {
        private SqlCommander _sqlCommander;

        public ScalarFunction_fnEnemiesShould()
        {
            _sqlCommander = new SqlCommander();
        }

        [Fact]
        public void fnEnemiesShouldHave1Tables()
        {
            // -- Arrange
            var resultSet = _sqlCommander.ExecuteSqlCommand("SELECT dbo.fnEnemies(1) as result");

            // -- Assert
            Assert.Single(resultSet.Tables);
        }

        [Fact]
        public void fnEnemiesShouldHave1RowInTable()
        {
            // -- Arrange
            var resultSet = _sqlCommander.ExecuteSqlCommand("SELECT dbo.fnEnemies(1) as result");

            // -- Assert
            Assert.Equal(1, resultSet.Tables[0].Rows.Count);
        }
    }
}
