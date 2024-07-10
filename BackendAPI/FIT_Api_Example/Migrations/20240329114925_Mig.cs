using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CUSTOMER",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Sex = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Date_of_birth = table.Column<DateTime>(type: "date", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MATERIAL",
                columns: table => new
                {
                    Material_ID = table.Column<int>(type: "int", nullable: false),
                    Filament = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Resin = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CNCMill = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LaserCutter = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PremiumFilament = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MATERIAL", x => x.Material_ID);
                });

            migrationBuilder.CreateTable(
                name: "MEMBERSHIP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Customer_ID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Subscription = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Expiration_Date = table.Column<DateTime>(type: "date", nullable: true),
                    CrealityPrinters = table.Column<bool>(type: "bit", nullable: true),
                    Raise3D = table.Column<bool>(type: "bit", nullable: true),
                    LCDPrinters = table.Column<bool>(type: "bit", nullable: true),
                    Tools = table.Column<bool>(type: "bit", nullable: true),
                    Computers = table.Column<bool>(type: "bit", nullable: true),
                    Electronics = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEMBERSHIP", x => x.ID);
                    table.ForeignKey(
                        name: "FK__MEMBERSHI__Custo__267ABA7A",
                        column: x => x.Customer_ID,
                        principalTable: "CUSTOMER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMER_MATERIAL",
                columns: table => new
                {
                    Customer_ID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Material_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CUSTOMER__4F121DB65D928B2E", x => new { x.Customer_ID, x.Material_ID });
                    table.ForeignKey(
                        name: "FK__CUSTOMER___Custo__2B3F6F97",
                        column: x => x.Customer_ID,
                        principalTable: "CUSTOMER",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__CUSTOMER___Mater__2C3393D0",
                        column: x => x.Material_ID,
                        principalTable: "MATERIAL",
                        principalColumn: "Material_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CUSTOMER_MATERIAL_Material_ID",
                table: "CUSTOMER_MATERIAL",
                column: "Material_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MEMBERSHIP_Customer_ID",
                table: "MEMBERSHIP",
                column: "Customer_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CUSTOMER_MATERIAL");

            migrationBuilder.DropTable(
                name: "MEMBERSHIP");

            migrationBuilder.DropTable(
                name: "MATERIAL");

            migrationBuilder.DropTable(
                name: "CUSTOMER");
        }
    }
}
