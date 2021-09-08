using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class addCreatedAtAndMofifiedAtPropsToSchemas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Episodes",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enemies",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companions",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Episodes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Enemies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Companions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
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
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 667, DateTimeKind.Local).AddTicks(8199), new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(7958), new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(7995), new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8001), new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8007), new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8014), new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8020), new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8025), new DateTime(2021, 9, 1, 9, 57, 54, 670, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(8901), new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9573), new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9605), new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9611), new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9617), new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9623), new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9629), new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Companions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9635), new DateTime(2021, 9, 1, 9, 57, 54, 671, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(407), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1531), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1584), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1591), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1598), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1604), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1611), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1618), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(2373), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3161), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3208), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3214), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3220), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3226), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3232), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3238), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3971), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6307), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6393), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6401), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6408), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6415), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6422), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6428), new DateTime(2021, 9, 1, 9, 57, 54, 672, DateTimeKind.Local).AddTicks(6431) });
        }
    }
}
