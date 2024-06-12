using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCareers",
                schema: "public");

            migrationBuilder.RenameColumn(
                name: "Birthdate",
                schema: "public",
                table: "Students",
                newName: "BirthDate");

            migrationBuilder.CreateTable(
                name: "CareerStudent",
                schema: "public",
                columns: table => new
                {
                    CareersId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerStudent", x => new { x.CareersId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CareerStudent_Careers_CareersId",
                        column: x => x.CareersId,
                        principalSchema: "public",
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareerStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalSchema: "public",
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareerStudent_StudentsId",
                schema: "public",
                table: "CareerStudent",
                column: "StudentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareerStudent",
                schema: "public");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                schema: "public",
                table: "Students",
                newName: "Birthdate");

            migrationBuilder.CreateTable(
                name: "StudentCareers",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CareerId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCareers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentCareers_Careers_CareerId",
                        column: x => x.CareerId,
                        principalSchema: "public",
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCareers_Students_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "public",
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCareers_CareerId",
                schema: "public",
                table: "StudentCareers",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCareers_StudentId",
                schema: "public",
                table: "StudentCareers",
                column: "StudentId");
        }
    }
}
