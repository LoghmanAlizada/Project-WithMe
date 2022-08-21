using Microsoft.EntityFrameworkCore.Migrations;

namespace WithMe.Migrations
{
    public partial class addmigrationDessertsSectionForThirdMenuCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DessertsSectionForThirdMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionTitle = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DessertsSectionForThirdMenus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DessertsSectionForThirdMenus");
        }
    }
}
