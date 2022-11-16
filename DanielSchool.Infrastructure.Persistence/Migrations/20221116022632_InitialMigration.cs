using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanielSchool.Infrastructure.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Noticia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publish = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asignacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradoId = table.Column<int>(type: "int", nullable: false),
                    Ttle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignacion_Grado_GradoId",
                        column: x => x.GradoId,
                        principalTable: "Grado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradoId = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<int>(type: "int", nullable: false),
                    ExtraPoints = table.Column<int>(type: "int", nullable: false),
                    Comentaries = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfesorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calificacion_Grado_GradoId",
                        column: x => x.GradoId,
                        principalTable: "Grado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grado",
                columns: new[] { "Id", "Name", "Section" },
                values: new object[,]
                {
                    { 1, "4to", "A" },
                    { 16, "11vo", "B" },
                    { 15, "11vo", "A" },
                    { 14, "10mo", "B" },
                    { 13, "10mo", "A" },
                    { 12, "9no", "B" },
                    { 11, "9no", "A" },
                    { 10, "8vo", "B" },
                    { 9, "8vo", "A" },
                    { 8, "7mo", "B" },
                    { 7, "7mo", "A" },
                    { 6, "6to", "B" },
                    { 5, "6to", "A" },
                    { 4, "5to", "B" },
                    { 3, "5to", "A" },
                    { 2, "4to", "B" },
                    { 17, "12vo", "A" },
                    { 18, "12vo", "B" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignacion_GradoId",
                table: "Asignacion",
                column: "GradoId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificacion_GradoId",
                table: "Calificacion",
                column: "GradoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignacion");

            migrationBuilder.DropTable(
                name: "Calificacion");

            migrationBuilder.DropTable(
                name: "Noticia");

            migrationBuilder.DropTable(
                name: "Grado");
        }
    }
}
