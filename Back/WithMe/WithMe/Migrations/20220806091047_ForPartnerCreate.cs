using Microsoft.EntityFrameworkCore.Migrations;

namespace WithMe.Migrations
{
    public partial class ForPartnerCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForPartners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpanText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    FirstPartnerImageURl = table.Column<string>(nullable: true),
                    SecondPartnerImageURL = table.Column<string>(nullable: true),
                    ThirdPartnerImageURL = table.Column<string>(nullable: true),
                    FourthPartnerImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForPartners", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForPartners");
        }
    }
}
