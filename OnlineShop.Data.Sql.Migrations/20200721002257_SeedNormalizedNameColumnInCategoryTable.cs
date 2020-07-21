using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Data.Sql.Migrations
{
    public partial class SeedNormalizedNameColumnInCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update Category SET NormalizedName = UPPER(Name)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update Category SET NormalizedName = NULL");
        }
    }
}
