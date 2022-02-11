using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3.Server.Data.Migrations
{
    public partial class AddedConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "ID",
                keyValue: 1,
                column: "Country",
                value: "Australia");

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "ID",
                keyValue: 2,
                column: "Country",
                value: "Korea");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "ID",
                keyValue: 1,
                column: "Country",
                value: null);

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "ID",
                keyValue: 2,
                column: "Country",
                value: null);
        }
    }
}
