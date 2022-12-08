using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanielSchool.Infrastructure.Identity.Migrations
{
    public partial class AddingGenderAndBirthdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                schema: "Identity",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                schema: "Identity",
                table: "Usuario",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                schema: "Identity",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Genero",
                schema: "Identity",
                table: "Usuario");
        }
    }
}
