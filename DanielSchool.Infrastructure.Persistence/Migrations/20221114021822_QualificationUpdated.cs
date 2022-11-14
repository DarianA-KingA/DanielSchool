using Microsoft.EntityFrameworkCore.Migrations;

namespace DanielSchool.Infrastructure.Persistence.Migrations
{
    public partial class QualificationUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comentaries",
                table: "Calificacion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfesorId",
                table: "Calificacion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Calificacion",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentaries",
                table: "Calificacion");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Calificacion");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Calificacion");
        }
    }
}
