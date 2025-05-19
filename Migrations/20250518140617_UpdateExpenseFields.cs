using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExpenseFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date",
                table: "Expenses",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "Expenses",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Expenses",
                newName: "Amount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Expenses",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Expenses",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Expenses",
                newName: "amount");
        }
    }
}
