using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OwlOProjectA.Migrations.OwloDB
{
    public partial class WorkshopAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LuckyDraws",
                columns: table => new
                {
                    LuckyDraw_ID = table.Column<string>(nullable: false),
                    LuckyDraw_Name = table.Column<string>(maxLength: 100, nullable: false),
                    LuckyDraw_Company = table.Column<string>(maxLength: 50, nullable: false),
                    LuckyDraw_Cost = table.Column<int>(nullable: false),
                    LuckyDraw_Quantity = table.Column<int>(nullable: false),
                    LuckyDraw_Description = table.Column<string>(maxLength: 3000, nullable: false),
                    LuckyDraw_Expiry = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuckyDraws", x => x.LuckyDraw_ID);
                });

            migrationBuilder.CreateTable(
                name: "Owlees",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    NRIC = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 25, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Owl_Points = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Bio = table.Column<string>(maxLength: 3000, nullable: true),
                    Citizenship = table.Column<string>(maxLength: 100, nullable: false),
                    Inventory_ID = table.Column<string>(nullable: true),
                    Mentor_Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owlees", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    Vouchers_ID = table.Column<string>(nullable: false),
                    Voucher_Name = table.Column<string>(maxLength: 100, nullable: false),
                    Voucher_Company = table.Column<string>(maxLength: 50, nullable: false),
                    Voucher_Cost = table.Column<int>(nullable: false),
                    Voucher_Description = table.Column<string>(maxLength: 3000, nullable: false),
                    Voucher_Expiry = table.Column<DateTime>(nullable: false),
                    Super_Deal = table.Column<bool>(nullable: false),
                    DiscountDeal_Percentage = table.Column<double>(nullable: false),
                    Inventory_ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.Vouchers_ID);
                });

            migrationBuilder.CreateTable(
                name: "Workshop",
                columns: table => new
                {
                    Workshop_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Summary = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ownerEmail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshop", x => x.Workshop_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LuckyDraws");

            migrationBuilder.DropTable(
                name: "Owlees");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Workshop");
        }
    }
}
