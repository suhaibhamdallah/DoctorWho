using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Authentication.Db.Migrations
{
    public partial class addNetworkTypePropToUserSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NetworkType",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetworkType",
                table: "AspNetUsers");
        }
    }
}
