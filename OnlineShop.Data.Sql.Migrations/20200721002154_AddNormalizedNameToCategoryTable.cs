using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Data.Sql.Migrations
{
    public partial class AddNormalizedNameToCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "Category");
        }
    }
}
