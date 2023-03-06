using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderingService.Dal.Migrations
{
    /// <inheritdoc />
    public partial class Reset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.UniqueConstraint("AK_Clients_Phone", x => x.Phone);
                });

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

            migrationBuilder.CreateTable(
                name: "ClientCredentials",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCredentials", x => new { x.ClientId, x.Login });
                    table.ForeignKey(
                        name: "FK_ClientCredentials_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 3, 6, 11, 52, 19, 371, DateTimeKind.Utc).AddTicks(9507))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTypeRefId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.UniqueConstraint("AK_Products_Name", x => x.Name);
                    table.CheckConstraint("Price1", "Price > 0");
                    table.CheckConstraint("Quantity1", "Quantity >= 0");
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeRefId",
                        column: x => x.ProductTypeRefId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInOrders", x => x.Id);
                    table.CheckConstraint("Price", "Price > 0");
                    table.CheckConstraint("Quantity", "Quantity >= 0");
                    table.ForeignKey(
                        name: "FK_ProductsInOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FullName", "Phone" },
                values: new object[,]
                {
                    { new Guid("24301acc-a0d7-4f83-875c-7224d7ab4afd"), "Баранова Марьяна Рудольфовна", "89506224428" },
                    { new Guid("34845d57-b256-42a9-bfa6-423ea09bb895"), "Ларионов Аввакуум Христофорович", "89506335028" },
                    { new Guid("3629c35e-c45b-4d9d-a643-e2adc228ecd0"), "Дорофеева Георгина Онисимовна", "89506330270" },
                    { new Guid("4f5e6333-d2d5-4bdc-8055-e363eea16b34"), "Зайцева Римма Аристарховна", "89503335028" },
                    { new Guid("69ec996e-b3f1-4466-912b-aa95a68678ab"), "Савин Август Оскарович", "89506225026" },
                    { new Guid("6cf01359-7265-43f2-8126-9d64fedb5c48"), "Лазарева Лигия Пётровна", "89506225268" },
                    { new Guid("6fbcebb9-4289-454f-99a6-4c7d28eaa255"), "Воронцов Любомир Антонович", "89906225025" },
                    { new Guid("7b15078f-2266-46d6-aece-e6a3aeb6f6c4"), "Фёдорова Асида Федоровна", "89506225278" },
                    { new Guid("93ae41c8-bbc4-4b66-b6c2-6cf08cedd3a1"), "Меркушев Бенедикт Алексеевич", "89996225028" },
                    { new Guid("e2fd808b-c4c7-454e-8bbf-10d7ca215b7b"), "Беляков Демьян Степанович", "89606225028" },
                    { new Guid("e4e735a0-1afd-4477-a9e3-3fb035dcfc42"), "Ефимов Аким Лаврентьевич", "89506225027" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 0, "Электроника", "Electronics" },
                    { 1, "Автомобильные товары", "Cars" },
                    { 2, "Стройматериалы и инструменты", "BuildingMaterialsInstruments" },
                    { 3, "Всё для дома", "HouseHoldGoods" }
                });

            migrationBuilder.InsertData(
                table: "ClientCredentials",
                columns: new[] { "ClientId", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("24301acc-a0d7-4f83-875c-7224d7ab4afd"), "user24301acc-a0d7-4f83-875c-7224d7ab4afd", "qwe12345" },
                    { new Guid("34845d57-b256-42a9-bfa6-423ea09bb895"), "user34845d57-b256-42a9-bfa6-423ea09bb895", "qwe12345" },
                    { new Guid("3629c35e-c45b-4d9d-a643-e2adc228ecd0"), "user3629c35e-c45b-4d9d-a643-e2adc228ecd0", "qwe12345" },
                    { new Guid("4f5e6333-d2d5-4bdc-8055-e363eea16b34"), "user4f5e6333-d2d5-4bdc-8055-e363eea16b34", "qwe12345" },
                    { new Guid("69ec996e-b3f1-4466-912b-aa95a68678ab"), "user69ec996e-b3f1-4466-912b-aa95a68678ab", "qwe12345" },
                    { new Guid("6cf01359-7265-43f2-8126-9d64fedb5c48"), "user6cf01359-7265-43f2-8126-9d64fedb5c48", "qwe12345" },
                    { new Guid("6fbcebb9-4289-454f-99a6-4c7d28eaa255"), "user6fbcebb9-4289-454f-99a6-4c7d28eaa255", "qwe12345" },
                    { new Guid("7b15078f-2266-46d6-aece-e6a3aeb6f6c4"), "user7b15078f-2266-46d6-aece-e6a3aeb6f6c4", "qwe12345" },
                    { new Guid("93ae41c8-bbc4-4b66-b6c2-6cf08cedd3a1"), "user93ae41c8-bbc4-4b66-b6c2-6cf08cedd3a1", "qwe12345" },
                    { new Guid("e2fd808b-c4c7-454e-8bbf-10d7ca215b7b"), "usere2fd808b-c4c7-454e-8bbf-10d7ca215b7b", "qwe12345" },
                    { new Guid("e4e735a0-1afd-4477-a9e3-3fb035dcfc42"), "usere4e735a0-1afd-4477-a9e3-3fb035dcfc42", "qwe12345" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "CreatedAt" },
                values: new object[,]
                {
                    { new Guid("222d16e7-295b-4788-ad68-3d462d0ae470"), new Guid("e4e735a0-1afd-4477-a9e3-3fb035dcfc42"), new DateTime(2023, 12, 15, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4255) },
                    { new Guid("2e118b3f-d274-4b82-87c0-7b0363527d7e"), new Guid("34845d57-b256-42a9-bfa6-423ea09bb895"), new DateTime(2023, 8, 30, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4227) },
                    { new Guid("2f94af7c-e348-4b97-985f-27b0e6e2e3c9"), new Guid("24301acc-a0d7-4f83-875c-7224d7ab4afd"), new DateTime(2022, 4, 1, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4230) },
                    { new Guid("400b8f66-95d2-4631-857b-43777dbd4b0d"), new Guid("34845d57-b256-42a9-bfa6-423ea09bb895"), new DateTime(2023, 2, 24, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4265) },
                    { new Guid("40a6a28e-92d5-42bf-af85-88ad87035c2e"), new Guid("e2fd808b-c4c7-454e-8bbf-10d7ca215b7b"), new DateTime(2024, 2, 4, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4242) },
                    { new Guid("40d6d128-cee5-4bc9-ae64-f0f0218764be"), new Guid("6fbcebb9-4289-454f-99a6-4c7d28eaa255"), new DateTime(2023, 2, 15, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4253) },
                    { new Guid("47403a9a-5935-492e-b4ec-7bb7dce3053d"), new Guid("93ae41c8-bbc4-4b66-b6c2-6cf08cedd3a1"), new DateTime(2024, 1, 14, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4256) },
                    { new Guid("4bf0bdd0-b95d-4975-b062-289db0894617"), new Guid("34845d57-b256-42a9-bfa6-423ea09bb895"), new DateTime(2023, 8, 26, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4268) },
                    { new Guid("584386a9-ecb5-4e36-b8b6-bf591d0133a0"), new Guid("4f5e6333-d2d5-4bdc-8055-e363eea16b34"), new DateTime(2023, 8, 18, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4263) },
                    { new Guid("58cc1aad-045a-44f8-9ce3-7aa599b58123"), new Guid("24301acc-a0d7-4f83-875c-7224d7ab4afd"), new DateTime(2023, 7, 17, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4258) },
                    { new Guid("5ac37dd9-cd4c-4261-931b-4646cbd37e9e"), new Guid("93ae41c8-bbc4-4b66-b6c2-6cf08cedd3a1"), new DateTime(2023, 7, 17, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4250) },
                    { new Guid("5be70fc8-50b0-44ef-a2c4-c1f1f97bac97"), new Guid("93ae41c8-bbc4-4b66-b6c2-6cf08cedd3a1"), new DateTime(2023, 10, 19, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4248) },
                    { new Guid("70b4f701-15f0-48be-8d33-44d4a243ac48"), new Guid("e4e735a0-1afd-4477-a9e3-3fb035dcfc42"), new DateTime(2022, 9, 22, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4251) },
                    { new Guid("8843c7e7-4606-4266-9d74-96df3a987bdc"), new Guid("34845d57-b256-42a9-bfa6-423ea09bb895"), new DateTime(2022, 10, 12, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4213) },
                    { new Guid("9d21f72d-b841-4a3d-8c34-c546aef9fba4"), new Guid("6fbcebb9-4289-454f-99a6-4c7d28eaa255"), new DateTime(2022, 7, 16, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4239) },
                    { new Guid("b6d6d453-a060-4bdd-81bf-c62f431d7716"), new Guid("7b15078f-2266-46d6-aece-e6a3aeb6f6c4"), new DateTime(2024, 2, 14, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4240) },
                    { new Guid("c674e4f2-c27f-494b-9ddc-802c3be293ec"), new Guid("3629c35e-c45b-4d9d-a643-e2adc228ecd0"), new DateTime(2023, 9, 2, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(2851) },
                    { new Guid("c8042be5-25fc-4646-a341-e393b3701843"), new Guid("6cf01359-7265-43f2-8126-9d64fedb5c48"), new DateTime(2022, 2, 11, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4237) },
                    { new Guid("ca056694-41a9-41c3-a18f-6ca6608b168f"), new Guid("7b15078f-2266-46d6-aece-e6a3aeb6f6c4"), new DateTime(2023, 8, 14, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4267) },
                    { new Guid("cef5fc99-4456-414c-9f4a-068ceac2f110"), new Guid("6fbcebb9-4289-454f-99a6-4c7d28eaa255"), new DateTime(2023, 12, 30, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4244) },
                    { new Guid("d11bd9ed-3f1c-4908-8643-51c3fdb17c20"), new Guid("3629c35e-c45b-4d9d-a643-e2adc228ecd0"), new DateTime(2023, 10, 25, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4231) },
                    { new Guid("ef868a54-7ba6-42a1-b38d-7e094e45bbae"), new Guid("3629c35e-c45b-4d9d-a643-e2adc228ecd0"), new DateTime(2023, 1, 27, 11, 52, 18, 774, DateTimeKind.Utc).AddTicks(4260) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductTypeRefId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("14417564-1fd4-4803-b1b1-0288145f258e"), "Адаптер для скрытого подключения видеорегистратора Roadgid Cord DC", 1199m, 1, 10 },
                    { new Guid("2088847f-7b60-43e6-a8c8-3894b83b14b9"), "Чистящее средство для нагревательных элементов электроплит/газовых плит Topper IR 5", 50m, 3, 0 },
                    { new Guid("23012394-ff43-4b0b-8c2c-a85a420449ca"), "Швабра Master House Бачата", 199.99m, 3, 33 },
                    { new Guid("38d5bbdf-8d26-4a4e-a1b4-4cf31f95d0be"), "Набор инструментов Swiss Tools ST-1077", 5799.99m, 2, 20 },
                    { new Guid("3ffed479-1dfc-41a3-8836-87ef1a547f76"), "Набор инструментов Квалитет 5027038", 5699.9m, 2, 9 },
                    { new Guid("4ab47776-5c78-4876-9ad3-d0185b0ae5c8"), "Инвертор DEXP CAR 150W", 750m, 1, 0 },
                    { new Guid("58e276f3-2cd4-4b69-beda-50107b4a58f7"), "LED Harper 43F660Y", 15199m, 0, 6 },
                    { new Guid("62412ecf-2c2e-4724-b784-58affd99d590"), "LET Prestigio PTV50SS08X", 23199.9m, 0, 7 },
                    { new Guid("6d3de57c-711d-4305-8602-c9f12327a135"), "Набор инструментов КВТ Профи НИИ-09", 1699m, 2, 10 },
                    { new Guid("716b356f-af3c-4ee2-b0fb-3f8dbc21fad7"), "ASUS VivoBook 16X M1603QA", 51699m, 0, 11 },
                    { new Guid("79df991c-0ef9-44de-b582-f443190732ec"), "Очиститель для тканей и мебели ОС-Гель", 280m, 3, 15 },
                    { new Guid("80eaf80b-2672-44d9-97a5-b183b83f622b"), "Газонокосилка-робот Champion RMB1828", 49499.99m, 3, 8 },
                    { new Guid("99f346aa-bf0e-49d4-a505-b2f1f14a4ade"), "ТВ розетка одинарная Schneider Electric Glossa GSL000391", 199.99m, 3, 20 },
                    { new Guid("9fc9e275-e0c1-4d70-82ed-aec1db7f5668"), "Видеорегистратор 70mai Dash Cam M300", 3199.99m, 1, 5 },
                    { new Guid("a5f2e7c7-c0f0-4f97-a14d-02b43df393bb"), "IPhone 8s", 67530.50m, 0, 12 },
                    { new Guid("be01b729-1c56-4f3a-84c0-83f3790969fb"), "Паяльная станция Rexant 12-0714", 4399m, 2, 2 },
                    { new Guid("be0dce3a-07ee-4b53-a9f4-79e626b5ef3d"), "Швабра Master House Джайв", 199.99m, 3, 21 },
                    { new Guid("c1b502a5-27e5-48b6-a424-449e759a2179"), "Отвертка с набором насадок Matrix 11598", 110m, 2, 25 },
                    { new Guid("db2a4e37-9cdb-43b2-84f5-755b96751d51"), "Набор для ухода для стеклокерамических поверхностей Fiora bio ЭКО 20-002", 199m, 3, 5 },
                    { new Guid("e3249465-c56a-4b03-919a-6cb07d16c118"), "Набор инструментов Дело Техники 600937", 3033m, 2, 30 },
                    { new Guid("eb4415c7-3206-4ff2-af1e-505768ae76c1"), "Инструмент для вскрытия техники Rexant 12-4335", 99.99m, 2, 20 },
                    { new Guid("f0086139-f0bd-412d-8e32-fc483f8f8e2d"), "Камера заднего вида Silverstone F1 Interpower IP-662 LED", 799m, 1, 6 },
                    { new Guid("fec58d60-4d6a-4dd5-bde3-f4adc35db9f7"), "AMD Ryzen 7 4700G OEM", 15499.99m, 0, 20 }
                });

            migrationBuilder.InsertData(
                table: "ProductsInOrders",
                columns: new[] { "Id", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("039d2ecc-63f6-4b72-9f24-d5f3f7abcd03"), new Guid("584386a9-ecb5-4e36-b8b6-bf591d0133a0"), 337652.50m, new Guid("a5f2e7c7-c0f0-4f97-a14d-02b43df393bb"), 5 },
                    { new Guid("08e1c926-b739-4fa7-9204-ff25ffe84011"), new Guid("2e118b3f-d274-4b82-87c0-7b0363527d7e"), 1500m, new Guid("4ab47776-5c78-4876-9ad3-d0185b0ae5c8"), 2 },
                    { new Guid("0b0670bb-4e70-4a89-8e69-6f24438852b2"), new Guid("9d21f72d-b841-4a3d-8c34-c546aef9fba4"), 220m, new Guid("c1b502a5-27e5-48b6-a424-449e759a2179"), 2 },
                    { new Guid("0e1b3893-58cd-4c45-a5f2-af0b9b6c8e5f"), new Guid("222d16e7-295b-4788-ad68-3d462d0ae470"), 3199.99m, new Guid("9fc9e275-e0c1-4d70-82ed-aec1db7f5668"), 1 },
                    { new Guid("21548ab9-aa92-47f7-9a0b-718a98cc2a21"), new Guid("8843c7e7-4606-4266-9d74-96df3a987bdc"), 799.96m, new Guid("be0dce3a-07ee-4b53-a9f4-79e626b5ef3d"), 4 },
                    { new Guid("27794d80-5897-4221-a413-59757662b78a"), new Guid("c8042be5-25fc-4646-a341-e393b3701843"), 250m, new Guid("2088847f-7b60-43e6-a8c8-3894b83b14b9"), 5 },
                    { new Guid("37791897-aa9a-4f0b-b216-d88924556b3c"), new Guid("5be70fc8-50b0-44ef-a2c4-c1f1f97bac97"), 45597m, new Guid("58e276f3-2cd4-4b69-beda-50107b4a58f7"), 3 },
                    { new Guid("3db8096a-dff0-4342-b2c1-0e5f2bcacb6d"), new Guid("4bf0bdd0-b95d-4975-b062-289db0894617"), 2398m, new Guid("14417564-1fd4-4803-b1b1-0288145f258e"), 2 },
                    { new Guid("4a8ee7d8-59a2-42c4-811b-5295b7635acc"), new Guid("cef5fc99-4456-414c-9f4a-068ceac2f110"), 202591.50m, new Guid("a5f2e7c7-c0f0-4f97-a14d-02b43df393bb"), 3 },
                    { new Guid("821e56ab-170d-41b2-8ff7-0b1fa86f64fe"), new Guid("9d21f72d-b841-4a3d-8c34-c546aef9fba4"), 110m, new Guid("c1b502a5-27e5-48b6-a424-449e759a2179"), 1 },
                    { new Guid("822e5635-550e-47ff-9964-0cd63a06fd2f"), new Guid("40a6a28e-92d5-42bf-af85-88ad87035c2e"), 799m, new Guid("f0086139-f0bd-412d-8e32-fc483f8f8e2d"), 1 },
                    { new Guid("8ed3493e-bcc8-4043-a571-622f62bbd5f4"), new Guid("47403a9a-5935-492e-b4ec-7bb7dce3053d"), 23199.96m, new Guid("38d5bbdf-8d26-4a4e-a1b4-4cf31f95d0be"), 4 },
                    { new Guid("97fb55bb-1df5-480f-ab80-502bb62ad863"), new Guid("8843c7e7-4606-4266-9d74-96df3a987bdc"), 4796m, new Guid("14417564-1fd4-4803-b1b1-0288145f258e"), 4 },
                    { new Guid("9867d55a-c0f9-44ab-b744-7381ad97d32c"), new Guid("4bf0bdd0-b95d-4975-b062-289db0894617"), 46399.8m, new Guid("62412ecf-2c2e-4724-b784-58affd99d590"), 2 },
                    { new Guid("99058b4d-0f24-47e0-8b50-70fb22b8af96"), new Guid("400b8f66-95d2-4631-857b-43777dbd4b0d"), 46399.8m, new Guid("62412ecf-2c2e-4724-b784-58affd99d590"), 2 },
                    { new Guid("9a8a093f-a197-47d6-a852-bc2b6a80d38b"), new Guid("8843c7e7-4606-4266-9d74-96df3a987bdc"), 220m, new Guid("c1b502a5-27e5-48b6-a424-449e759a2179"), 2 },
                    { new Guid("b02539df-96c7-4f26-b5d0-ffc0cb0d1898"), new Guid("40a6a28e-92d5-42bf-af85-88ad87035c2e"), 3995m, new Guid("f0086139-f0bd-412d-8e32-fc483f8f8e2d"), 5 },
                    { new Guid("b3ca0bd4-ae38-4040-84f7-b7ca80c9fe35"), new Guid("222d16e7-295b-4788-ad68-3d462d0ae470"), 9599.97m, new Guid("9fc9e275-e0c1-4d70-82ed-aec1db7f5668"), 3 },
                    { new Guid("b685609a-5f06-405a-b7e6-4d051daf2a1c"), new Guid("9d21f72d-b841-4a3d-8c34-c546aef9fba4"), 22799.6m, new Guid("3ffed479-1dfc-41a3-8836-87ef1a547f76"), 4 },
                    { new Guid("bbed8827-79ca-470f-a2ac-0b7f4a618448"), new Guid("ca056694-41a9-41c3-a18f-6ca6608b168f"), 45597m, new Guid("58e276f3-2cd4-4b69-beda-50107b4a58f7"), 3 },
                    { new Guid("d44364a6-e4bb-46c6-bbf9-65986ab28617"), new Guid("58cc1aad-045a-44f8-9ce3-7aa599b58123"), 49499.99m, new Guid("80eaf80b-2672-44d9-97a5-b183b83f622b"), 1 },
                    { new Guid("d607848e-53cc-4b9c-b0fc-cdf2dacd5f9b"), new Guid("400b8f66-95d2-4631-857b-43777dbd4b0d"), 202591.50m, new Guid("a5f2e7c7-c0f0-4f97-a14d-02b43df393bb"), 3 },
                    { new Guid("f3806747-b0af-4b01-bd26-a596615a6077"), new Guid("cef5fc99-4456-414c-9f4a-068ceac2f110"), 440m, new Guid("c1b502a5-27e5-48b6-a424-449e759a2179"), 4 },
                    { new Guid("f41989d8-bb15-413e-9769-611db72dfc23"), new Guid("c8042be5-25fc-4646-a341-e393b3701843"), 799.96m, new Guid("23012394-ff43-4b0b-8c2c-a85a420449ca"), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeRefId",
                table: "Products",
                column: "ProductTypeRefId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInOrders_OrderId",
                table: "ProductsInOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInOrders_ProductId",
                table: "ProductsInOrders",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientCredentials");

            migrationBuilder.DropTable(
                name: "ProductsInOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
