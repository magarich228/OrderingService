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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 3, 2, 0, 37, 8, 632, DateTimeKind.Utc).AddTicks(2109))
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
                    { new Guid("1c90bda6-30bd-4db2-82c3-bbc5e1f0df80"), "Меркушев Бенедикт Алексеевич", "89996225028" },
                    { new Guid("4c5e197e-32c0-4c14-bb02-0046c9c7f7dd"), "Баранова Марьяна Рудольфовна", "89506224428" },
                    { new Guid("4e155ff9-0ff4-40e1-8bb1-6ed2766c2011"), "Беляков Демьян Степанович", "89606225028" },
                    { new Guid("60039117-b92f-4309-9b0d-105870f56ed2"), "Савин Август Оскарович", "89506225026" },
                    { new Guid("63a9d3d5-084e-43a9-a47f-5ae7b373ad3b"), "Дорофеева Георгина Онисимовна", "89506330270" },
                    { new Guid("677225fe-0b1d-47de-be47-46c7dd9359ce"), "Фёдорова Асида Федоровна", "89506225278" },
                    { new Guid("91205e37-c197-43c1-b9d9-5ae6fb858961"), "Зайцева Римма Аристарховна", "89503335028" },
                    { new Guid("9961c720-c1d5-417d-9438-14012033d4a4"), "Ефимов Аким Лаврентьевич", "89506225027" },
                    { new Guid("b36f4fa7-b464-431b-8e1a-48f4520ce1c2"), "Лазарева Лигия Пётровна", "89506225268" },
                    { new Guid("e96e5d97-b251-4082-8a8b-d3588f115e7f"), "Воронцов Любомир Антонович", "89906225025" },
                    { new Guid("fa770cec-4b6f-465e-9c70-6084fd1e5ed2"), "Ларионов Аввакуум Христофорович", "89506335028" }
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
                table: "Orders",
                columns: new[] { "Id", "ClientId", "CreatedAt" },
                values: new object[,]
                {
                    { new Guid("0e37779d-9348-47e2-8836-9880b7e0b268"), new Guid("fa770cec-4b6f-465e-9c70-6084fd1e5ed2"), new DateTime(2024, 3, 5, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8335) },
                    { new Guid("15d4f293-dd7e-4944-99c1-811699c8bd0e"), new Guid("b36f4fa7-b464-431b-8e1a-48f4520ce1c2"), new DateTime(2022, 12, 16, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8360) },
                    { new Guid("20b8b451-fd6a-4e20-9860-0d4bc2f02b7c"), new Guid("fa770cec-4b6f-465e-9c70-6084fd1e5ed2"), new DateTime(2023, 8, 17, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8322) },
                    { new Guid("34e46e30-172a-4919-81b2-871e3a60919b"), new Guid("60039117-b92f-4309-9b0d-105870f56ed2"), new DateTime(2022, 7, 25, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8332) },
                    { new Guid("373b7c83-1d9f-4386-a6f4-0f45aa290366"), new Guid("63a9d3d5-084e-43a9-a47f-5ae7b373ad3b"), new DateTime(2024, 3, 14, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8325) },
                    { new Guid("42cb4203-0740-4c7a-bc34-80261c7b5af5"), new Guid("9961c720-c1d5-417d-9438-14012033d4a4"), new DateTime(2023, 12, 9, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8354) },
                    { new Guid("4748b238-2e68-43c8-8961-e3176b5bcd7c"), new Guid("60039117-b92f-4309-9b0d-105870f56ed2"), new DateTime(2022, 6, 3, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8348) },
                    { new Guid("5e77610c-2a87-481b-8435-7948b74e7a7c"), new Guid("60039117-b92f-4309-9b0d-105870f56ed2"), new DateTime(2022, 2, 11, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8345) },
                    { new Guid("7c0f0569-7584-42d0-9de2-d50a094ac1f8"), new Guid("677225fe-0b1d-47de-be47-46c7dd9359ce"), new DateTime(2022, 3, 14, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8351) },
                    { new Guid("872832ee-555d-4dfc-b1fa-e2c460eaf982"), new Guid("9961c720-c1d5-417d-9438-14012033d4a4"), new DateTime(2023, 11, 13, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8344) },
                    { new Guid("8e71748f-ce67-4997-bd33-5b035fefe618"), new Guid("b36f4fa7-b464-431b-8e1a-48f4520ce1c2"), new DateTime(2022, 10, 22, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8308) },
                    { new Guid("94d3252b-647f-4e6f-b4a6-a91715d9e9e3"), new Guid("e96e5d97-b251-4082-8a8b-d3588f115e7f"), new DateTime(2023, 11, 5, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8350) },
                    { new Guid("96fe52dc-3a9b-4401-ae8d-d66e4a6aa648"), new Guid("4c5e197e-32c0-4c14-bb02-0046c9c7f7dd"), new DateTime(2022, 2, 14, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8333) },
                    { new Guid("a246cd3e-f8f3-491a-bb66-06e66bc3800c"), new Guid("677225fe-0b1d-47de-be47-46c7dd9359ce"), new DateTime(2022, 4, 15, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8339) },
                    { new Guid("a6ed2555-adc4-4ad2-ac42-c4fa233decf1"), new Guid("1c90bda6-30bd-4db2-82c3-bbc5e1f0df80"), new DateTime(2022, 8, 23, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8357) },
                    { new Guid("a8aab191-da1e-42d3-a0a1-ce5728360c30"), new Guid("91205e37-c197-43c1-b9d9-5ae6fb858961"), new DateTime(2022, 10, 1, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8326) },
                    { new Guid("b9a18339-1285-4260-a876-84db2086b728"), new Guid("9961c720-c1d5-417d-9438-14012033d4a4"), new DateTime(2022, 11, 7, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8342) },
                    { new Guid("c3600c28-48e2-42fa-a266-166809391cca"), new Guid("4c5e197e-32c0-4c14-bb02-0046c9c7f7dd"), new DateTime(2022, 1, 31, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8336) },
                    { new Guid("d43ab11b-1d59-4ef8-b233-b9f1d2aab6e7"), new Guid("4c5e197e-32c0-4c14-bb02-0046c9c7f7dd"), new DateTime(2024, 3, 11, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8359) },
                    { new Guid("d550141c-ada5-4088-aa0d-35aaef6ba7aa"), new Guid("91205e37-c197-43c1-b9d9-5ae6fb858961"), new DateTime(2024, 2, 8, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8347) },
                    { new Guid("d7d73b97-51f5-4f60-920c-16f5b6320706"), new Guid("60039117-b92f-4309-9b0d-105870f56ed2"), new DateTime(2023, 9, 11, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(6800) },
                    { new Guid("ff667d01-b215-48cc-ba91-a9de3edae706"), new Guid("4c5e197e-32c0-4c14-bb02-0046c9c7f7dd"), new DateTime(2023, 4, 8, 0, 37, 8, 17, DateTimeKind.Utc).AddTicks(8362) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductTypeRefId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("01cfc44b-b3be-487a-9057-26042ee65640"), "Видеорегистратор 70mai Dash Cam M300", 3199.99m, 1, 5 },
                    { new Guid("03258a9d-94c5-4c15-8d2c-e08b808bd79c"), "IPhone 8s", 67530.50m, 0, 12 },
                    { new Guid("0c66710e-356d-4fa5-9ef2-a73a5fd28109"), "Набор инструментов КВТ Профи НИИ-09", 1699m, 2, 10 },
                    { new Guid("1a13e6ca-08f0-492e-a0f6-9b2aca1d58e5"), "Набор инструментов Swiss Tools ST-1077", 5799.99m, 2, 20 },
                    { new Guid("1a603c2c-10ce-4712-bb0f-00332ec1cbbc"), "ТВ розетка одинарная Schneider Electric Glossa GSL000391", 199.99m, 3, 20 },
                    { new Guid("23f72594-38b6-4656-9c7e-04eb36dc7697"), "Паяльная станция Rexant 12-0714", 4399m, 2, 2 },
                    { new Guid("3113a0b9-19a2-47e3-994d-8c65b90efbd6"), "Камера заднего вида Silverstone F1 Interpower IP-662 LED", 799m, 1, 6 },
                    { new Guid("4adafc39-956a-4f58-a542-77be558e3417"), "AMD Ryzen 7 4700G OEM", 15499.99m, 0, 20 },
                    { new Guid("4b4ef205-4c20-45ea-af02-5915b75804c7"), "Набор для ухода для стеклокерамических поверхностей Fiora bio ЭКО 20-002", 199m, 3, 5 },
                    { new Guid("502c13c1-b463-40a4-ba8a-53c61e7b498b"), "Набор инструментов Дело Техники 600937", 3033m, 2, 30 },
                    { new Guid("5f0c6a25-90b9-453f-89f3-1a56f8c0c25f"), "Набор инструментов Квалитет 5027038", 5699.9m, 2, 9 },
                    { new Guid("660f8c46-51f6-40a2-89c9-e51e7b2e1edd"), "Инвертор DEXP CAR 150W", 750m, 1, 0 },
                    { new Guid("70073151-e3dc-4c57-8e92-1c2cb39cad6d"), "Швабра Master House Джайв", 199.99m, 3, 21 },
                    { new Guid("92e6a345-5014-4097-9f40-e34c82c1faa6"), "Очиститель для тканей и мебели ОС-Гель", 280m, 3, 15 },
                    { new Guid("9b8269af-e0ba-41a2-a382-da32138d88c7"), "LET Prestigio PTV50SS08X", 23199.9m, 0, 7 },
                    { new Guid("afe28108-822e-41d3-a2ef-358552c3d103"), "Швабра Master House Бачата", 199.99m, 3, 33 },
                    { new Guid("b0d66c85-e0a5-450b-aef5-e7dacd23c70c"), "LED Harper 43F660Y", 15199m, 0, 6 },
                    { new Guid("b15ae1d0-935d-4d59-8091-b7508655cf72"), "Чистящее средство для нагревательных элементов электроплит/газовых плит Topper IR 5", 50m, 3, 0 },
                    { new Guid("bce208b7-1c21-41ee-9fac-bf72f8f7f457"), "Газонокосилка-робот Champion RMB1828", 49499.99m, 3, 8 },
                    { new Guid("d4931e86-e4f4-4336-a892-5a215cb7708b"), "Отвертка с набором насадок Matrix 11598", 110m, 2, 25 },
                    { new Guid("e45f8511-7716-41fa-993d-2ebbd8dd50eb"), "Адаптер для скрытого подключения видеорегистратора Roadgid Cord DC", 1199m, 1, 10 },
                    { new Guid("e8ee073f-d08c-4e8d-a7b8-b12aece7a046"), "Инструмент для вскрытия техники Rexant 12-4335", 99.99m, 2, 20 },
                    { new Guid("fce0b3e6-b473-4878-ab3b-2bf35e684fdb"), "ASUS VivoBook 16X M1603QA", 51699m, 0, 11 }
                });

            migrationBuilder.InsertData(
                table: "ProductsInOrders",
                columns: new[] { "Id", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0975950a-f0e4-4c3b-95b6-c831bea945a9"), new Guid("c3600c28-48e2-42fa-a266-166809391cca"), 17596m, new Guid("23f72594-38b6-4656-9c7e-04eb36dc7697"), 4 },
                    { new Guid("09a157c9-07db-4685-b0b3-6628540e671d"), new Guid("a246cd3e-f8f3-491a-bb66-06e66bc3800c"), 15999.95m, new Guid("01cfc44b-b3be-487a-9057-26042ee65640"), 5 },
                    { new Guid("0b87b8cf-00c2-42fa-9a84-06c0ae02dfee"), new Guid("c3600c28-48e2-42fa-a266-166809391cca"), 599.97m, new Guid("1a603c2c-10ce-4712-bb0f-00332ec1cbbc"), 3 },
                    { new Guid("0d9d69f7-3a6d-4c25-a859-af74ae913424"), new Guid("96fe52dc-3a9b-4401-ae8d-d66e4a6aa648"), 799.96m, new Guid("afe28108-822e-41d3-a2ef-358552c3d103"), 4 },
                    { new Guid("0e27c32a-d808-4771-8f92-8e11892b4de7"), new Guid("872832ee-555d-4dfc-b1fa-e2c460eaf982"), 98999.98m, new Guid("bce208b7-1c21-41ee-9fac-bf72f8f7f457"), 2 },
                    { new Guid("1f5dc4be-274c-463a-bfc3-f9dc28850fc3"), new Guid("d43ab11b-1d59-4ef8-b233-b9f1d2aab6e7"), 3033m, new Guid("502c13c1-b463-40a4-ba8a-53c61e7b498b"), 1 },
                    { new Guid("23798b9f-4a2a-4ca2-907c-c31d6ee694fd"), new Guid("0e37779d-9348-47e2-8836-9880b7e0b268"), 46499.97m, new Guid("4adafc39-956a-4f58-a542-77be558e3417"), 3 },
                    { new Guid("248ea536-e9e9-4086-9dd5-4765dbc1e301"), new Guid("20b8b451-fd6a-4e20-9860-0d4bc2f02b7c"), 337652.50m, new Guid("03258a9d-94c5-4c15-8d2c-e08b808bd79c"), 5 },
                    { new Guid("375673e8-c245-40ee-ae47-de349ab7d320"), new Guid("a6ed2555-adc4-4ad2-ac42-c4fa233decf1"), 92799.6m, new Guid("9b8269af-e0ba-41a2-a382-da32138d88c7"), 4 },
                    { new Guid("3a105801-85bb-45a5-a94a-4d4d2a42b60e"), new Guid("96fe52dc-3a9b-4401-ae8d-d66e4a6aa648"), 51699m, new Guid("fce0b3e6-b473-4878-ab3b-2bf35e684fdb"), 1 },
                    { new Guid("40df1931-73e0-4aed-bafe-8a8b0d27f0fe"), new Guid("94d3252b-647f-4e6f-b4a6-a91715d9e9e3"), 597m, new Guid("4b4ef205-4c20-45ea-af02-5915b75804c7"), 3 },
                    { new Guid("44e82805-75d4-4bd1-9fdc-c0510726a140"), new Guid("94d3252b-647f-4e6f-b4a6-a91715d9e9e3"), 15199m, new Guid("b0d66c85-e0a5-450b-aef5-e7dacd23c70c"), 1 },
                    { new Guid("534bc064-1555-4c61-8ce6-93881a50bf1f"), new Guid("8e71748f-ce67-4997-bd33-5b035fefe618"), 1500m, new Guid("660f8c46-51f6-40a2-89c9-e51e7b2e1edd"), 2 },
                    { new Guid("5f94cb2f-ca9f-4357-bd1e-785fee1bb728"), new Guid("ff667d01-b215-48cc-ba91-a9de3edae706"), 15499.99m, new Guid("4adafc39-956a-4f58-a542-77be558e3417"), 1 },
                    { new Guid("6df5faec-909f-4efc-9f38-7a6dfff5b0be"), new Guid("96fe52dc-3a9b-4401-ae8d-d66e4a6aa648"), 148499.97m, new Guid("bce208b7-1c21-41ee-9fac-bf72f8f7f457"), 3 },
                    { new Guid("7d215b61-07aa-4f19-ab12-87fe4e09b0b0"), new Guid("5e77610c-2a87-481b-8435-7948b74e7a7c"), 1699m, new Guid("0c66710e-356d-4fa5-9ef2-a73a5fd28109"), 1 },
                    { new Guid("8116ebcf-cabe-4447-b7c5-713580e4a4cd"), new Guid("0e37779d-9348-47e2-8836-9880b7e0b268"), 840m, new Guid("92e6a345-5014-4097-9f40-e34c82c1faa6"), 3 },
                    { new Guid("90129d34-8b18-494b-9c04-20e3b4f51fbf"), new Guid("7c0f0569-7584-42d0-9de2-d50a094ac1f8"), 599.97m, new Guid("1a603c2c-10ce-4712-bb0f-00332ec1cbbc"), 3 },
                    { new Guid("91e357b2-3f18-4511-af66-0b6f2b048f78"), new Guid("b9a18339-1285-4260-a876-84db2086b728"), 799m, new Guid("3113a0b9-19a2-47e3-994d-8c65b90efbd6"), 1 },
                    { new Guid("926d856d-e7a7-4302-a606-667091b324f2"), new Guid("ff667d01-b215-48cc-ba91-a9de3edae706"), 199.99m, new Guid("1a603c2c-10ce-4712-bb0f-00332ec1cbbc"), 1 },
                    { new Guid("9bee1852-16a0-418e-b513-d0e586064119"), new Guid("0e37779d-9348-47e2-8836-9880b7e0b268"), 92799.6m, new Guid("9b8269af-e0ba-41a2-a382-da32138d88c7"), 4 },
                    { new Guid("a1736fbc-5c14-4bdb-a8ea-49b8accf14ed"), new Guid("ff667d01-b215-48cc-ba91-a9de3edae706"), 799.96m, new Guid("afe28108-822e-41d3-a2ef-358552c3d103"), 4 },
                    { new Guid("abd3fb27-3df9-443e-bea9-7204d29c9817"), new Guid("872832ee-555d-4dfc-b1fa-e2c460eaf982"), 1598m, new Guid("3113a0b9-19a2-47e3-994d-8c65b90efbd6"), 2 },
                    { new Guid("c48da1cd-3032-4ddd-86e8-6a57993aec3a"), new Guid("373b7c83-1d9f-4386-a6f4-0f45aa290366"), 75995m, new Guid("b0d66c85-e0a5-450b-aef5-e7dacd23c70c"), 5 },
                    { new Guid("cdb1ae7d-5201-4480-8004-91bfba2060e7"), new Guid("7c0f0569-7584-42d0-9de2-d50a094ac1f8"), 3196m, new Guid("3113a0b9-19a2-47e3-994d-8c65b90efbd6"), 4 },
                    { new Guid("d19f16d1-dfec-464c-a254-622691614a7a"), new Guid("20b8b451-fd6a-4e20-9860-0d4bc2f02b7c"), 200m, new Guid("b15ae1d0-935d-4d59-8091-b7508655cf72"), 4 },
                    { new Guid("d76ddf31-0b6f-4182-8f85-504c04467842"), new Guid("d43ab11b-1d59-4ef8-b233-b9f1d2aab6e7"), 148499.97m, new Guid("bce208b7-1c21-41ee-9fac-bf72f8f7f457"), 3 },
                    { new Guid("e2351fc9-c014-4142-b2e6-f4eec3f61846"), new Guid("b9a18339-1285-4260-a876-84db2086b728"), 799.96m, new Guid("afe28108-822e-41d3-a2ef-358552c3d103"), 4 },
                    { new Guid("f2395798-b0bf-4321-9cbe-2ef8a86f3e93"), new Guid("15d4f293-dd7e-4944-99c1-811699c8bd0e"), 258495m, new Guid("fce0b3e6-b473-4878-ab3b-2bf35e684fdb"), 5 },
                    { new Guid("f7d302f8-0e34-41f3-84cf-fd35870e5a13"), new Guid("5e77610c-2a87-481b-8435-7948b74e7a7c"), 1500m, new Guid("660f8c46-51f6-40a2-89c9-e51e7b2e1edd"), 2 },
                    { new Guid("fff03144-851b-4478-a835-944ebccd2a48"), new Guid("42cb4203-0740-4c7a-bc34-80261c7b5af5"), 45597m, new Guid("b0d66c85-e0a5-450b-aef5-e7dacd23c70c"), 3 }
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
