using Microsoft.EntityFrameworkCore.Migrations;

namespace OwlOProjectA.Migrations.OwloDB
{
    public partial class PublishedAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Published",
                table: "Workshop",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Published",
                table: "Workshop");
        }
    }
}
