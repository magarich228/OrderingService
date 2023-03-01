using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderingService.Dal.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Products",
                newName: "ProductTypeRefId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 1, 21, 52, 32, 436, DateTimeKind.Utc).AddTicks(3288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Products_Name",
                table: "Products",
                column: "Name");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Clients_Phone",
                table: "Clients",
                column: "Phone");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                    table.UniqueConstraint("AK_ProductTypes_Name", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 0, "Электроника", "Electronics" },
                    { 1, "Автомобильные товары", "Cars" },
                    { 2, "Стройматериалы", "BuildingMaterials" },
                    { 3, "Всё для дома", "HouseHoldGoods" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeRefId",
                table: "Products",
                column: "ProductTypeRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeRefId",
                table: "Products",
                column: "ProductTypeRefId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeRefId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Products_Name",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypeRefId",
                table: "Products");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Clients_Phone",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "ProductTypeRefId",
                table: "Products",
                newName: "Type");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 1, 21, 52, 32, 436, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
