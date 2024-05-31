using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Students",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "StudentCareers",
                newName: "StudentCareers",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Careers",
                newName: "Careers",
                newSchema: "public");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                schema: "public",
                table: "Students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                schema: "public",
                table: "Students",
                newName: "Birthdate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Students",
                schema: "public",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "StudentCareers",
                schema: "public",
                newName: "StudentCareers");

            migrationBuilder.RenameTable(
                name: "Careers",
                schema: "public",
                newName: "Careers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "Birthdate",
                table: "Students",
                newName: "Birthday");
        }
    }
}
