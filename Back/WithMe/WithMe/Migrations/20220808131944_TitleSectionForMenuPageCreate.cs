using Microsoft.EntityFrameworkCore.Migrations;

namespace WithMe.Migrations
{
    public partial class TitleSectionForMenuPageCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TitleSectionForMenuPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    SecondMenuButtonText = table.Column<string>(nullable: true),
                    ThirdMenuButtonText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleSectionForMenuPages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TitleSectionForMenuPages");
        }
    }
}
