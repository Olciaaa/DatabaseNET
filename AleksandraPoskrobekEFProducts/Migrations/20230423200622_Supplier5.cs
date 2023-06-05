using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AleksandraPoskrobekEFProducts.Migrations
{
    /// <inheritdoc />
    public partial class Supplier5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_supplierID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "supplierID",
                table: "Products",
                newName: "SupplierID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_supplierID",
                table: "Products",
                newName: "IX_Products_SupplierID");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "Products",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "Products",
                newName: "supplierID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                newName: "IX_Products_supplierID");

            migrationBuilder.AlterColumn<int>(
                name: "supplierID",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_supplierID",
                table: "Products",
                column: "supplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
