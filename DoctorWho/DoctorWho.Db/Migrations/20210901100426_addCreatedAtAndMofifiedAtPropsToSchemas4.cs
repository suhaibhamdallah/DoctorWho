using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class addCreatedAtAndMofifiedAtPropsToSchemas4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Episodes",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Enemies",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Companions",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Episodes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Enemies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Companions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 205, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 205, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 205, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 205, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 205, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 205, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 205, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 205, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 5, 24, 206, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedAt",
                value: new DateTime(2021, 9, 1, 11, 5, 24, 207, DateTimeKind.Local).AddTicks(4016));
        }
    }
}
