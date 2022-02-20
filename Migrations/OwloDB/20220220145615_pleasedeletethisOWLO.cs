using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OwlOProjectA.Migrations.OwloDB
{
    public partial class pleasedeletethisOWLO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    User_Comment = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ComName = table.Column<string>(nullable: false),
                    ComDescp = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunityPosts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PostCaption = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FAQ_ID = table.Column<string>(nullable: false),
                    FAQ_Title = table.Column<string>(maxLength: 100, nullable: false),
                    FAQ_ImagePath = table.Column<string>(nullable: true),
                    FAQ_DatePublished = table.Column<DateTime>(nullable: false),
                    FAQ_Type = table.Column<string>(nullable: false),
                    FAQ_Content = table.Column<string>(nullable: false),
                    FAQ_Author = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FAQ_ID);
                });

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
                    LuckyDraw_Expiry = table.Column<DateTime>(nullable: false),
                    LuckyDraw_OriginalQuantity = table.Column<int>(nullable: false)
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
                    Bio = table.Column<string>(maxLength: 3000, nullable: true),
                    Citizenship = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owlees", x => x.Email);
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
                    Inventory_ID = table.Column<string>(nullable: true),
                    Voucher_ImagePath = table.Column<string>(nullable: true)
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "CommunityPosts");

            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "LuckyDraws");

            migrationBuilder.DropTable(
                name: "Owlees");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "VoucherDistributions");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Workshop");
        }
    }
}
