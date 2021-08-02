using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class editstoredprocsandfuncs : Migration
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
		                    INNER JOIN EpisodeCompanions ON Companions.Id = EpisodeCompanions.Id
		                    WHERE EpisodeCompanions.Id = @episodeId
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
		                    INNER JOIN EpisodeEnemies ON Enemies.Id = EpisodeEnemies.Id
		                    WHERE EpisodeEnemies.Id = @episodeId
	                    );

	                    RETURN @enemy_names
                    END;"
            );

            // Create stored procedure that return table contain
            // the 3 most frequently-appearing companions; then separately
            // return a second table that contain 
            // the 3 most frequently-appearing enemies
            migrationBuilder.Sql(
                @"CREATE OR ALTER PROCEDURE spSummariseEpisodes
                    AS BEGIN

                      SELECT TOP 3 EpisodeCompanions.Id,
		                     Companions.CompanionName,
		                     COUNT(EpisodeCompanions.Id) AS CompanionAppearing
                      FROM EpisodeCompanions
                      INNER JOIN Companions ON EpisodeCompanions.Id = Companions.Id
                      GROUP BY EpisodeCompanions.Id, Companions.CompanionName
                      ORDER BY CompanionAppearing DESC;

                      SELECT TOP 3 EpisodeEnemies.Id,
		                     COUNT(EpisodeEnemies.Id) AS EnemyAppearing,
		                     Enemies.EnemyName
                      FROM EpisodeEnemies
                      INNER JOIN Enemies ON EpisodeEnemies.Id = Enemies.Id
                      GROUP BY EpisodeEnemies.Id, Enemies.EnemyName
                      ORDER BY EnemyAppearing DESC;

                    END;"
            );

            // Create view that include: 
            // 1. Author name 
            // 2. Doctor Name
            // 3. Companions
            // 4. Enemies
            migrationBuilder.Sql(
                @"CREATE OR ALTER VIEW viewEpisodes AS
                    SELECT  Doctors.DoctorName,
		                    Authors.AuthorName,
		                    dbo.fnCompanions(Episodes.Id) as Companions,
		                    dbo.fnEnemies(Episodes.Id) as Enemies
                    FROM Episodes
                    LEFT JOIN Authors ON Authors.Id = Episodes.Id
                    LEFT JOIN Doctors ON Doctors.Id = Episodes.Id;"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS dbo.fnCompanions");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS dbo.fnEnemies");
            migrationBuilder.Sql(@"DROP PROCEDURE IF EXISTS dbo.spSummariseEpisodes;");
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS dbo.viewEpisodes");
        }
    }
}
