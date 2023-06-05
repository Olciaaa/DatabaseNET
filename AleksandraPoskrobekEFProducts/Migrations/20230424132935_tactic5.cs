using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AleksandraPoskrobekEFProducts.Migrations
{
    /// <inheritdoc />
    public partial class tactic5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Company_CompanyID",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CompanyID",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Companies",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Companies",
                newName: "ZipCode");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Companies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Companies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "bankAccountNumber",
                table: "Suppliers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discount = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_Companies_ID",
                        column: x => x.ID,
                        principalTable: "Companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Companies_ID",
                table: "Suppliers",
                column: "ID",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Companies_ID",
                table: "Suppliers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Company");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Companies",
                newName: "CompanyID");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Companies",
                newName: "Type");

            migrationBuilder.AlterColumn<string>(
                name: "bankAccountNumber",
                table: "Company",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Discount",
                table: "Company",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Company",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyID",
                table: "Companies",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Company_CompanyID",
                table: "Companies",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
