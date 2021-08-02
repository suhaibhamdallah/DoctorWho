using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class makeidpropgeneric : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EpisodeId",
                table: "Episodes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EpisodeEnemyId",
                table: "EpisodeEnemies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EpisodeCompanionId",
                table: "EpisodeCompanions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EnemyId",
                table: "Enemies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Doctors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CompanionId",
                table: "Companions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Authors",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Episodes",
                newName: "EpisodeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EpisodeEnemies",
                newName: "EpisodeEnemyId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EpisodeCompanions",
                newName: "EpisodeCompanionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Enemies",
                newName: "EnemyId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctors",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Companions",
                newName: "CompanionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Authors",
                newName: "AuthorId");
        }
    }
}
