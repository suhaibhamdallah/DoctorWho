using Xunit;

namespace DoctorWho.Db.Tests
{
    public class ScalarFunction_fnCompanionsShould
    {
        private SqlCommander _sqlCommander;

        public ScalarFunction_fnCompanionsShould()
        {
            _sqlCommander = new SqlCommander();
        }

        [Fact]
        public void fnCompanionsShouldHave1Tables()
        {
            // -- Arrange
            var resultSet = _sqlCommander.ExecuteSqlCommand("SELECT dbo.fnCompanions(1) as result");

            // -- Assert
            Assert.Single(resultSet.Tables);
        }

        [Fact]
        public void fnCompanionsShouldHave1RowInTable()
        {
            // -- Arrange
            var resultSet = _sqlCommander.ExecuteSqlCommand("SELECT dbo.fnCompanions(1) as result");

            // -- Assert
            Assert.Equal(1, resultSet.Tables[0].Rows.Count);
        }
    }
}
