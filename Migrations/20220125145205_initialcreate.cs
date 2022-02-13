using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OwlOProjectA.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owlees",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NRIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Owl_Points = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    Citizenship = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Inventory_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mentor_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owlees", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    Vouchers_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Voucher_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Voucher_Company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Voucher_Cost = table.Column<int>(type: "int", nullable: false),
                    Voucher_Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Voucher_Expiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Super_Deal = table.Column<bool>(type: "bit", nullable: false),
                    DiscountDeal_Percentage = table.Column<double>(type: "float", nullable: false),
                    Inventory_ID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.Vouchers_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owlees");

            migrationBuilder.DropTable(
                name: "Vouchers");
        }
    }
}
