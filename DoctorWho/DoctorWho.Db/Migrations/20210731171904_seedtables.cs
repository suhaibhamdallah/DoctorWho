using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class seedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Suhaib Hamdallah" },
                    { 2, "Anas Zakarneh" },
                    { 3, "Mohammad Abu-Qasedo" },
                    { 4, "Stephen Hillenburg" },
                    { 5, "Craig McCracken" },
                    { 6, "Genndy Tartakovsky" },
                    { 7, "Alex Hirsch" },
                    { 8, "Butch Hartman" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 7, "Hasan Khalaf", null },
                    { 6, "Osaid Hamdallah", null },
                    { 5, "Yazan Fouqha", null },
                    { 8, "Rayan Hamdallah", null },
                    { 3, "Amjad Salhab", null },
                    { 2, "Jweid Hamdallah", null },
                    { 1, "Zaid Nour", null },
                    { 4, "Osaid Nour", null }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BithDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 8, new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Hamza Nour", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Laith Sharaqa", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Naresh Trehan", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Ahmad Assi", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Khalid Abbed, M.D.", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Myles. B. Abbott, M.D.", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. William A. Abdu, M.D, M.S.", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Fouad. M. Abbas, M.D.", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 7, "bla bla", "Mohammad Domidi" },
                    { 1, "bla bla", "Eric Cartman" },
                    { 2, "bla bla", "Vicky" },
                    { 3, "bla bla", "Stewie Griffin" },
                    { 4, "bla bla", "Maleficent" },
                    { 5, "bla bla", "Mr. Pickles " },
                    { 6, "bla bla", "Ahmad Nassar" },
                    { 8, "bla bla", "Ammar Omar" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeTitle", "EpisodeType", "Notes", "SeriesNumber" },
                values: new object[,]
                {
                    { 8, 8, null, new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TITLE 8", "TYPE 3", null, 2 },
                    { 1, 1, 1, new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TITLE 1", "TYPE 1", null, 1 },
                    { 2, 2, 2, new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TITLE 2", "TYPE 2", null, 1 },
                    { 3, 3, 3, new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TITLE 3", "TYPE 3", null, 1 },
                    { 4, 3, 4, new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TITLE 4", "TYPE 3", null, 1 },
                    { 5, 4, 5, new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TITLE 5", "TYPE 2", null, 2 },
                    { 6, 5, 6, new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TITLE 6", "TYPE 1", null, 2 },
                    { 7, 6, 7, new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TITLE 7", "TYPE 1", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 10, 3, 3 },
                    { 9, 4, 3 },
                    { 13, 1, 5 },
                    { 8, 3, 2 },
                    { 7, 2, 2 },
                    { 12, 2, 4 },
                    { 6, 1, 2 },
                    { 5, 5, 1 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 14, 1, 6 },
                    { 11, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 11, 2, 5 },
                    { 12, 2, 6 },
                    { 13, 3, 6 },
                    { 10, 1, 5 },
                    { 9, 1, 4 },
                    { 7, 7, 2 },
                    { 14, 2, 7 },
                    { 6, 2, 2 },
                    { 5, 1, 2 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 1, 1, 1 },
                    { 8, 1, 3 },
                    { 15, 3, 7 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 7);

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
    }
}
