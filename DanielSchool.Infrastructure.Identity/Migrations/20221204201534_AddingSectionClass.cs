using Microsoft.EntityFrameworkCore.Migrations;

namespace DanielSchool.Infrastructure.Identity.Migrations
{
    public partial class AddingSectionClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Seccion",
                schema: "Identity",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seccion",
                schema: "Identity",
                table: "Usuario");
        }
    }
}
