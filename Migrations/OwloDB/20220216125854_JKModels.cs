using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OwlOProjectA.Migrations.OwloDB
{
    public partial class JKModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Owlees");

            migrationBuilder.DropColumn(
                name: "Inventory_ID",
                table: "Owlees");

            migrationBuilder.DropColumn(
                name: "Mentor_Email",
                table: "Owlees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Owlees");

            migrationBuilder.AddColumn<string>(
                name: "Voucher_ImagePath",
                table: "Vouchers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Booking_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    workshopID = table.Column<int>(nullable: false),
                    venueID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Booking_ID);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Venue_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Weekdays = table.Column<string>(nullable: false),
                    Weekends = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.Venue_ID);
                });

            migrationBuilder.CreateTable(
                name: "VoucherDistributions",
                columns: table => new
                {
                    VoucherDistribution_ID = table.Column<string>(nullable: false),
                    VoucherDistribution_VoucherID = table.Column<string>(maxLength: 100, nullable: false),
                    VoucherDistribution_OwnerEmail = table.Column<string>(nullable: false),
                    VoucherDistribution_VoucherName = table.Column<string>(maxLength: 100, nullable: false),
                    VoucherDistribution_VoucherCost = table.Column<int>(nullable: false),
                    VoucherDistribution_VoucherExpiry = table.Column<DateTime>(nullable: false),
                    VoucherDistribution_VoucherSuperDeal = table.Column<bool>(nullable: false),
                    VoucherDistribution_VoucherCompany = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherDistributions", x => x.VoucherDistribution_ID);
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
                    ownerEmail = table.Column<string>(nullable: false),
                    venueID = table.Column<int>(nullable: false),
                    Published = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshop", x => x.Workshop_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "VoucherDistributions");

            migrationBuilder.DropTable(
                name: "Workshop");

            migrationBuilder.DropColumn(
                name: "Voucher_ImagePath",
                table: "Vouchers");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Owlees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Inventory_ID",
                table: "Owlees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mentor_Email",
                table: "Owlees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Owlees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
