using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class editmodelstruct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanions_Companions_CompanionId",
                table: "EpisodeCompanions");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanions_Episodes_EpisodeId",
                table: "EpisodeCompanions");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemies_Enemies_EnemyId",
                table: "EpisodeEnemies");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemies_Episodes_EpisodeId",
                table: "EpisodeEnemies");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Episodes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Episodes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EpisodeId",
                table: "EpisodeEnemies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnemyId",
                table: "EpisodeEnemies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EpisodeId",
                table: "EpisodeCompanions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanionId",
                table: "EpisodeCompanions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanions_Companions_CompanionId",
                table: "EpisodeCompanions",
                column: "CompanionId",
                principalTable: "Companions",
                principalColumn: "CompanionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanions_Episodes_EpisodeId",
                table: "EpisodeCompanions",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemies_Enemies_EnemyId",
                table: "EpisodeEnemies",
                column: "EnemyId",
                principalTable: "Enemies",
                principalColumn: "EnemyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemies_Episodes_EpisodeId",
                table: "EpisodeEnemies",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanions_Companions_CompanionId",
                table: "EpisodeCompanions");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanions_Episodes_EpisodeId",
                table: "EpisodeCompanions");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemies_Enemies_EnemyId",
                table: "EpisodeEnemies");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemies_Episodes_EpisodeId",
                table: "EpisodeEnemies");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Episodes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Episodes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EpisodeId",
                table: "EpisodeEnemies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EnemyId",
                table: "EpisodeEnemies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EpisodeId",
                table: "EpisodeCompanions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanionId",
                table: "EpisodeCompanions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanions_Companions_CompanionId",
                table: "EpisodeCompanions",
                column: "CompanionId",
                principalTable: "Companions",
                principalColumn: "CompanionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanions_Episodes_EpisodeId",
                table: "EpisodeCompanions",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemies_Enemies_EnemyId",
                table: "EpisodeEnemies",
                column: "EnemyId",
                principalTable: "Enemies",
                principalColumn: "EnemyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemies_Episodes_EpisodeId",
                table: "EpisodeEnemies",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
