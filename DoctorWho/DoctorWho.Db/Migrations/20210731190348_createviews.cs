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
                    SELECT  Episodes.*,
                            Doctors.DoctorName,
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
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS dbo.viewEpisodes");
        }
    }
}
