using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3.Server.Data.Migrations
{
    public partial class AddApplicationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Travellers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TPhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travellers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    StaffPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEmailID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staffs_Travellers_TEmailID",
                        column: x => x.TEmailID,
                        principalTable: "Travellers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfTravellers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LengthOfTrip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEmailID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Routes_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routes_Travellers_TEmailID",
                        column: x => x.TEmailID,
                        principalTable: "Travellers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEmailID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trips_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trips_Travellers_TEmailID",
                        column: x => x.TEmailID,
                        principalTable: "Travellers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_StaffID",
                table: "Routes",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_TEmailID",
                table: "Routes",
                column: "TEmailID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_TEmailID",
                table: "Staffs",
                column: "TEmailID");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_StaffID",
                table: "Trips",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_TEmailID",
                table: "Trips",
                column: "TEmailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Travellers");
        }
    }
}
