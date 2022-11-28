using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanielSchool.Infrastructure.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Week = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    PuntosExtras = table.Column<int>(type: "int", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DescCalificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    PuntosExtras = table.Column<int>(type: "int", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCalification = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescCalificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Publish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.InsertData(
                table: "Calificacion",
                columns: new[] { "Id", "Comentarios", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Month", "Nota", "PuntosExtras", "StudentId", "Week" },
                values: new object[,]
                {
                    { 1, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 1, 100, 0, "Estudiante_Usuario", 1 },
                    { 27, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 7, 100, 0, "Estudiante_Usuario", 3 },
                    { 28, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 7, 100, 0, "Estudiante_Usuario", 4 },
                    { 29, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 8, 100, 0, "Estudiante_Usuario", 1 },
                    { 30, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 8, 100, 0, "Estudiante_Usuario", 2 },
                    { 31, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 8, 100, 0, "Estudiante_Usuario", 3 },
                    { 32, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 8, 100, 0, "Estudiante_Usuario", 4 },
                    { 34, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 9, 100, 0, "Estudiante_Usuario", 2 },
                    { 35, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 9, 100, 0, "Estudiante_Usuario", 3 },
                    { 36, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 9, 100, 0, "Estudiante_Usuario", 4 },
                    { 37, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 10, 100, 0, "Estudiante_Usuario", 1 },
                    { 38, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 10, 100, 0, "Estudiante_Usuario", 2 },
                    { 39, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 10, 100, 0, "Estudiante_Usuario", 3 },
                    { 40, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 10, 100, 0, "Estudiante_Usuario", 4 },
                    { 41, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 11, 100, 0, "Estudiante_Usuario", 1 },
                    { 42, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 11, 100, 0, "Estudiante_Usuario", 2 },
                    { 43, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 11, 100, 0, "Estudiante_Usuario", 3 },
                    { 44, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 11, 100, 0, "Estudiante_Usuario", 4 },
                    { 45, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 12, 100, 0, "Estudiante_Usuario", 1 },
                    { 46, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 12, 100, 0, "Estudiante_Usuario", 2 },
                    { 47, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 12, 100, 0, "Estudiante_Usuario", 3 },
                    { 48, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 12, 100, 0, "Estudiante_Usuario", 4 },
                    { 26, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 7, 100, 0, "Estudiante_Usuario", 2 },
                    { 25, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 7, 100, 0, "Estudiante_Usuario", 1 },
                    { 33, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 9, 100, 0, "Estudiante_Usuario", 1 },
                    { 23, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 6, 100, 0, "Estudiante_Usuario", 3 },
                    { 2, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 1, 100, 0, "Estudiante_Usuario", 2 },
                    { 3, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 1, 100, 0, "Estudiante_Usuario", 3 },
                    { 24, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 6, 100, 0, "Estudiante_Usuario", 4 },
                    { 5, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 2, 100, 0, "Estudiante_Usuario", 1 },
                    { 6, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 2, 100, 0, "Estudiante_Usuario", 2 },
                    { 7, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 2, 100, 0, "Estudiante_Usuario", 3 },
                    { 8, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 2, 100, 0, "Estudiante_Usuario", 4 },
                    { 9, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 3, 100, 0, "Estudiante_Usuario", 1 },
                    { 10, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 3, 100, 0, "Estudiante_Usuario", 2 },
                    { 11, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 3, 100, 0, "Estudiante_Usuario", 3 },
                    { 12, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 3, 100, 0, "Estudiante_Usuario", 4 },
                    { 4, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 1, 100, 0, "Estudiante_Usuario", 4 },
                    { 14, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 4, 100, 0, "Estudiante_Usuario", 2 },
                    { 13, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 4, 100, 0, "Estudiante_Usuario", 1 },
                    { 22, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 6, 100, 0, "Estudiante_Usuario", 2 },
                    { 20, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 5, 100, 0, "Estudiante_Usuario", 4 }
                });

            migrationBuilder.InsertData(
                table: "Calificacion",
                columns: new[] { "Id", "Comentarios", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Month", "Nota", "PuntosExtras", "StudentId", "Week" },
                values: new object[,]
                {
                    { 19, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 5, 100, 0, "Estudiante_Usuario", 3 },
                    { 21, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 6, 100, 0, "Estudiante_Usuario", 1 },
                    { 17, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 5, 100, 0, "Estudiante_Usuario", 1 },
                    { 16, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 4, 100, 0, "Estudiante_Usuario", 4 },
                    { 15, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 4, 100, 0, "Estudiante_Usuario", 3 },
                    { 18, " N/A", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", null, null, 5, 100, 0, "Estudiante_Usuario", 2 }
                });

            migrationBuilder.InsertData(
                table: "Grado",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name", "Section" },
                values: new object[,]
                {
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "11vo", "B" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "8vo", "B" },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "11vo", "A" },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "10mo", "B" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "10mo", "A" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "9no", "B" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "9no", "A" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "8vo", "A" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "5to", "B" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "7mo", "A" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "6to", "B" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "6to", "A" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "5to", "A" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "4to", "B" },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "4to", "A" },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "12vo", "A" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "7mo", "B" },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "12vo", "B" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignacion_GradoId",
                table: "Asignacion",
                column: "GradoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignacion");

            migrationBuilder.DropTable(
                name: "Calificacion");

            migrationBuilder.DropTable(
                name: "DescCalificacion");

            migrationBuilder.DropTable(
                name: "Noticia");

            migrationBuilder.DropTable(
                name: "Grado");
        }
    }
}
