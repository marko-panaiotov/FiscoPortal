using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiscoPortal.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFiscalPrinterNumberAndTestClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "FiscalPrinter");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "FiscalPrinter",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "FiscalPrinter",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Client",
                table: "FiscalPrinter",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FiscalPrinterNumber",
                table: "FiscalPrinter",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Client",
                table: "FiscalPrinter");

            migrationBuilder.DropColumn(
                name: "FiscalPrinterNumber",
                table: "FiscalPrinter");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "FiscalPrinter",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "FiscalPrinter",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "FiscalPrinter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
