using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Students",
                schema: "public",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "CareerStudent",
                schema: "public",
                newName: "CareerStudent");

            migrationBuilder.RenameTable(
                name: "Careers",
                schema: "public",
                newName: "Careers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Students",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "CareerStudent",
                newName: "CareerStudent",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Careers",
                newName: "Careers",
                newSchema: "public");
        }
    }
}
