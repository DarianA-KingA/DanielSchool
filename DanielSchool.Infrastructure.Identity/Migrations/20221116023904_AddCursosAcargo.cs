using Microsoft.EntityFrameworkCore.Migrations;

namespace DanielSchool.Infrastructure.Identity.Migrations
{
    public partial class AddCursosAcargo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GradosACargo",
                schema: "Identity",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradosACargo",
                schema: "Identity",
                table: "Usuario");
        }
    }
}
