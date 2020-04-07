using Microsoft.EntityFrameworkCore.Migrations;

namespace tasktp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Access",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SpeakingLanguage",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Access",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpeakingLanguage",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
