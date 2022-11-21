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
                    Agosto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Septiembre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Octubre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Noviembre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diciembre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frebrero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marzo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abril = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mayo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Junio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Julio = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                columns: new[] { "Id", "Abril", "Agosto", "Created", "CreatedBy", "Diciembre", "Enero", "Frebrero", "Julio", "Junio", "LastModified", "LastModifiedBy", "Marzo", "Mayo", "Noviembre", "Octubre", "Septiembre", "StudentId" },
                values: new object[] { 1, "33,34,35,36", "1,2,3,4", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "17,18,19,20", "21,22,23,24", "25,26,27,28", "45,46,47,48", "41,42,43,44", null, null, "29,30,31,32", "37,38,39,40", "13,14,15,16", "9,10,11,12", "5,6,7,8", "Estudiante_Usuario" });

            migrationBuilder.InsertData(
                table: "DescCalificacion",
                columns: new[] { "Id", "Comentarios", "Created", "CreatedBy", "IdCalification", "LastModified", "LastModifiedBy", "Nota", "PuntosExtras" },
                values: new object[,]
                {
                    { 27, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 28, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 29, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 30, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 31, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 32, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 34, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 35, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 36, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 37, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 38, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 39, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 40, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 41, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 42, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 43, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 44, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 45, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 46, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 47, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 48, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 26, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 25, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 33, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 23, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 1, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 2, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 3, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 24, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 5, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 6, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 7, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 8, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 9, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 10, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 11, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 4, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 13, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 12, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 22, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 20, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 }
                });

            migrationBuilder.InsertData(
                table: "DescCalificacion",
                columns: new[] { "Id", "Comentarios", "Created", "CreatedBy", "IdCalification", "LastModified", "LastModifiedBy", "Nota", "PuntosExtras" },
                values: new object[,]
                {
                    { 19, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 18, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 21, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 16, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 15, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 14, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 },
                    { 17, "N/A", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Admin", 1, null, null, 100, 0 }
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
