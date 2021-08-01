using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class createviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create view that include: 
            // 1. Author name 
            // 2. Doctor Name
            // 3. Companions
            // 4. Enemies
            migrationBuilder.Sql(
                @"CREATE OR ALTER VIEW viewEpisodes AS
                    SELECT  Doctors.DoctorName,
		                    Authors.AuthorName,
		                    dbo.fnCompanions(Episodes.EpisodeId) as Companions,
		                    dbo.fnEnemies(Episodes.EpisodeId) as Enemies
                    FROM Episodes
                    LEFT JOIN Authors ON Authors.AuthorId = Episodes.AuthorId
                    LEFT JOIN Doctors ON Doctors.DoctorId = Episodes.DoctorId;"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS dbo.viewEpisodes");
        }
    }
}
