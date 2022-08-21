using Microsoft.EntityFrameworkCore.Migrations;

namespace WithMe.Migrations
{
    public partial class TitleSectionForSecondMenuPageCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TitleSectionForSecondMenuPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    FirstMenuButtonText = table.Column<string>(nullable: true),
                    ThirdMenuButtonText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleSectionForSecondMenuPages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TitleSectionForSecondMenuPages");
        }
    }
}
