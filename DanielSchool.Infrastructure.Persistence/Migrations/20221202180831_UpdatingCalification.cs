using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanielSchool.Infrastructure.Persistence.Migrations
{
    public partial class UpdatingCalification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescCalificacion");

            migrationBuilder.DropColumn(
                name: "PuntosExtras",
                table: "Calificacion");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Calificacion",
                newName: "StudentUserName");

            migrationBuilder.AlterColumn<string>(
                name: "Nota",
                table: "Calificacion",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Meta",
                table: "Calificacion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Declarar varibales", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Diagrama de flujo", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Condicional \"if\"", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Bubcle \"while\"", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Comentarios", "Created", "Meta", "Nota" },
                values: new object[] { "N/A", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "Default", "Iniciado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Meta",
                table: "Calificacion");

            migrationBuilder.RenameColumn(
                name: "StudentUserName",
                table: "Calificacion",
                newName: "StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "Nota",
                table: "Calificacion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PuntosExtras",
                table: "Calificacion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DescCalificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCalification = table.Column<int>(type: "int", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    PuntosExtras = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescCalificacion", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });

            migrationBuilder.UpdateData(
                table: "Calificacion",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Comentarios", "Created", "Nota" },
                values: new object[] { " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 100 });
        }
    }
}
