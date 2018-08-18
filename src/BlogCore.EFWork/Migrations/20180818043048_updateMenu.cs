using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCore.EFWork.Migrations
{
    public partial class updateMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MenuCode",
                table: "Menus",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuCode",
                table: "Menus");
        }
    }
}
