using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class createstoredprocs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create stored procedure that return table contain
            // the 3 most frequently-appearing companions; then separately
            // return a second table that contain 
            // the 3 most frequently-appearing enemies
            migrationBuilder.Sql(
                @"CREATE OR ALTER PROCEDURE spSummariseEpisodes
                    AS BEGIN

                      SELECT TOP 3 EpisodeCompanions.CompanionId,
		                     Companions.CompanionName,
		                     COUNT(EpisodeCompanions.CompanionId) AS CompanionAppearing
                      FROM EpisodeCompanions
                      INNER JOIN Companions ON EpisodeCompanions.CompanionId = Companions.CompanionId
                      GROUP BY EpisodeCompanions.CompanionId, Companions.CompanionName
                      ORDER BY CompanionAppearing DESC;

                      SELECT TOP 3 EpisodeEnemies.EnemyId,
		                     COUNT(EpisodeEnemies.EnemyId) AS EnemyAppearing,
		                     Enemies.EnemyName
                      FROM EpisodeEnemies
                      INNER JOIN Enemies ON EpisodeEnemies.EnemyId = Enemies.EnemyId
                      GROUP BY EpisodeEnemies.EnemyId, Enemies.EnemyName
                      ORDER BY EnemyAppearing DESC;

                    END;"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE IF EXISTS dbo.spSummariseEpisodes;");
        }
    }
}
