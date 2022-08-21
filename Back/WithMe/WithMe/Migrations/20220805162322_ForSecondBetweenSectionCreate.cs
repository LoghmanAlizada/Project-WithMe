using Microsoft.EntityFrameworkCore.Migrations;

namespace WithMe.Migrations
{
    public partial class ForSecondBetweenSectionCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForSecondBetweenSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    WeekDaysTime = table.Column<string>(nullable: true),
                    WeekEndTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForSecondBetweenSections", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForSecondBetweenSections");
        }
    }
}
