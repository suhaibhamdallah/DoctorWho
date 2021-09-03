using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class addCreatedByPropToDbSchemas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Enemies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Enemies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Companions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Companions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 56, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 59, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 59, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 59, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 59, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 59, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 59, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 59, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 15, 28, 52, 60, DateTimeKind.Local).AddTicks(9125));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Enemies");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Enemies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 649, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 652, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 652, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 652, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 652, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 652, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 652, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 652, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 13, 4, 25, 653, DateTimeKind.Local).AddTicks(8807));
        }
    }
}
