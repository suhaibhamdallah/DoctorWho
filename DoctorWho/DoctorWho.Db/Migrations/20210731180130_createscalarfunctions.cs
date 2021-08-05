using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class createscalarfunctions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create user-scalar function that print companion names by episode Id 
            migrationBuilder.Sql(
                @"CREATE OR ALTER FUNCTION fnCompanions (
	                    @episodeId int
                    )
                    RETURNS varchar(MAX) AS
                    BEGIN
	                    DECLARE @companion_names varchar(MAX)

	                    SET @companion_names = (
		                    SELECT STRING_AGG(CompanionName, ', ') AS Result FROM Companions
		                    INNER JOIN EpisodeCompanions ON Companions.CompanionId = EpisodeCompanions.CompanionId
		                    WHERE EpisodeCompanions.EpisodeId = @episodeId
	                    );

	                    RETURN @companion_names
                    END;"
            );

            // Create user-scalar function that print enemy names by episode Id 
            migrationBuilder.Sql(
                @"CREATE OR ALTER FUNCTION fnEnemies (
	                    @episodeId int
                    )
                    RETURNS varchar(MAX) AS
                    BEGIN
	                    DECLARE @enemy_names varchar(MAX)

	                    SET @enemy_names = (
		                    SELECT STRING_AGG(EnemyName, ', ') AS Result FROM Enemies
		                    INNER JOIN EpisodeEnemies ON Enemies.EnemyId = EpisodeEnemies.EnemyId
		                    WHERE EpisodeEnemies.EpisodeId = @episodeId
	                    );

	                    RETURN @enemy_names
                    END;"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS dbo.fnCompanions");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS dbo.fnEnemies");
        }
    }
}
