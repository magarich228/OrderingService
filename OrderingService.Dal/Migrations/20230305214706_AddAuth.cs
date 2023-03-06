using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderingService.Dal.Migrations
{
    /// <inheritdoc />
    public partial class AddAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4e155ff9-0ff4-40e1-8bb1-6ed2766c2011"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("34e46e30-172a-4919-81b2-871e3a60919b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4748b238-2e68-43c8-8961-e3176b5bcd7c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a8aab191-da1e-42d3-a0a1-ce5728360c30"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d550141c-ada5-4088-aa0d-35aaef6ba7aa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d7d73b97-51f5-4f60-920c-16f5b6320706"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a13e6ca-08f0-492e-a0f6-9b2aca1d58e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f0c6a25-90b9-453f-89f3-1a56f8c0c25f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70073151-e3dc-4c57-8e92-1c2cb39cad6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4931e86-e4f4-4336-a892-5a215cb7708b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e45f8511-7716-41fa-993d-2ebbd8dd50eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8ee073f-d08c-4e8d-a7b8-b12aece7a046"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("0975950a-f0e4-4c3b-95b6-c831bea945a9"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("09a157c9-07db-4685-b0b3-6628540e671d"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("0b87b8cf-00c2-42fa-9a84-06c0ae02dfee"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("0d9d69f7-3a6d-4c25-a859-af74ae913424"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("0e27c32a-d808-4771-8f92-8e11892b4de7"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("1f5dc4be-274c-463a-bfc3-f9dc28850fc3"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("23798b9f-4a2a-4ca2-907c-c31d6ee694fd"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("248ea536-e9e9-4086-9dd5-4765dbc1e301"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("375673e8-c245-40ee-ae47-de349ab7d320"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("3a105801-85bb-45a5-a94a-4d4d2a42b60e"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("40df1931-73e0-4aed-bafe-8a8b0d27f0fe"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("44e82805-75d4-4bd1-9fdc-c0510726a140"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("534bc064-1555-4c61-8ce6-93881a50bf1f"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("5f94cb2f-ca9f-4357-bd1e-785fee1bb728"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6df5faec-909f-4efc-9f38-7a6dfff5b0be"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("7d215b61-07aa-4f19-ab12-87fe4e09b0b0"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("8116ebcf-cabe-4447-b7c5-713580e4a4cd"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("90129d34-8b18-494b-9c04-20e3b4f51fbf"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("91e357b2-3f18-4511-af66-0b6f2b048f78"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("926d856d-e7a7-4302-a606-667091b324f2"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("9bee1852-16a0-418e-b513-d0e586064119"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("a1736fbc-5c14-4bdb-a8ea-49b8accf14ed"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("abd3fb27-3df9-443e-bea9-7204d29c9817"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("c48da1cd-3032-4ddd-86e8-6a57993aec3a"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("cdb1ae7d-5201-4480-8004-91bfba2060e7"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("d19f16d1-dfec-464c-a254-622691614a7a"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("d76ddf31-0b6f-4182-8f85-504c04467842"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("e2351fc9-c014-4142-b2e6-f4eec3f61846"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("f2395798-b0bf-4321-9cbe-2ef8a86f3e93"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("f7d302f8-0e34-41f3-84cf-fd35870e5a13"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("fff03144-851b-4478-a835-944ebccd2a48"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("91205e37-c197-43c1-b9d9-5ae6fb858961"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0e37779d-9348-47e2-8836-9880b7e0b268"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15d4f293-dd7e-4944-99c1-811699c8bd0e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("20b8b451-fd6a-4e20-9860-0d4bc2f02b7c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("373b7c83-1d9f-4386-a6f4-0f45aa290366"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("42cb4203-0740-4c7a-bc34-80261c7b5af5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5e77610c-2a87-481b-8435-7948b74e7a7c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7c0f0569-7584-42d0-9de2-d50a094ac1f8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("872832ee-555d-4dfc-b1fa-e2c460eaf982"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8e71748f-ce67-4997-bd33-5b035fefe618"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("94d3252b-647f-4e6f-b4a6-a91715d9e9e3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("96fe52dc-3a9b-4401-ae8d-d66e4a6aa648"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a246cd3e-f8f3-491a-bb66-06e66bc3800c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a6ed2555-adc4-4ad2-ac42-c4fa233decf1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b9a18339-1285-4260-a876-84db2086b728"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c3600c28-48e2-42fa-a266-166809391cca"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d43ab11b-1d59-4ef8-b233-b9f1d2aab6e7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff667d01-b215-48cc-ba91-a9de3edae706"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01cfc44b-b3be-487a-9057-26042ee65640"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03258a9d-94c5-4c15-8d2c-e08b808bd79c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c66710e-356d-4fa5-9ef2-a73a5fd28109"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a603c2c-10ce-4712-bb0f-00332ec1cbbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23f72594-38b6-4656-9c7e-04eb36dc7697"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3113a0b9-19a2-47e3-994d-8c65b90efbd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4adafc39-956a-4f58-a542-77be558e3417"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b4ef205-4c20-45ea-af02-5915b75804c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("502c13c1-b463-40a4-ba8a-53c61e7b498b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("660f8c46-51f6-40a2-89c9-e51e7b2e1edd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92e6a345-5014-4097-9f40-e34c82c1faa6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b8269af-e0ba-41a2-a382-da32138d88c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afe28108-822e-41d3-a2ef-358552c3d103"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0d66c85-e0a5-450b-aef5-e7dacd23c70c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b15ae1d0-935d-4d59-8091-b7508655cf72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bce208b7-1c21-41ee-9fac-bf72f8f7f457"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fce0b3e6-b473-4878-ab3b-2bf35e684fdb"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1c90bda6-30bd-4db2-82c3-bbc5e1f0df80"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4c5e197e-32c0-4c14-bb02-0046c9c7f7dd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("60039117-b92f-4309-9b0d-105870f56ed2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("63a9d3d5-084e-43a9-a47f-5ae7b373ad3b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("677225fe-0b1d-47de-be47-46c7dd9359ce"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9961c720-c1d5-417d-9438-14012033d4a4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b36f4fa7-b464-431b-8e1a-48f4520ce1c2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e96e5d97-b251-4082-8a8b-d3588f115e7f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("fa770cec-4b6f-465e-9c70-6084fd1e5ed2"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 5, 21, 47, 6, 509, DateTimeKind.Utc).AddTicks(208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 2, 0, 37, 8, 632, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.CreateTable(
                name: "ClientCredentials",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCredentials", x => new { x.ClientId, x.Username });
                    table.ForeignKey(
                        name: "FK_ClientCredentials_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FullName", "Phone" },
                values: new object[,]
                {
                    { new Guid("34fa4285-beb7-4e52-bcf4-bcd99e2d5b94"), "Лазарева Лигия Пётровна", "89506225268" },
                    { new Guid("4a57edba-bfaa-4388-860b-7e6e1ed4ba83"), "Баранова Марьяна Рудольфовна", "89506224428" },
                    { new Guid("5721c29f-1f2e-4d02-83ff-9a3f57a817e6"), "Беляков Демьян Степанович", "89606225028" },
                    { new Guid("60a287dd-fea3-43fa-9d73-eaaab0e96ab8"), "Зайцева Римма Аристарховна", "89503335028" },
                    { new Guid("851e8bb2-9498-4852-b702-242d3cef6654"), "Меркушев Бенедикт Алексеевич", "89996225028" },
                    { new Guid("87184d4b-bc15-43cc-9dd3-f61da3a35095"), "Савин Август Оскарович", "89506225026" },
                    { new Guid("8f1fe072-c8cb-4a54-8001-056c0d6ba55f"), "Ефимов Аким Лаврентьевич", "89506225027" },
                    { new Guid("af93ed71-fb44-48fc-b9c8-2d018702bcc5"), "Ларионов Аввакуум Христофорович", "89506335028" },
                    { new Guid("b2cfbca6-48d2-4d2c-89bb-4c609b71deab"), "Воронцов Любомир Антонович", "89906225025" },
                    { new Guid("c6697675-09ab-40d0-b853-f8831a989e77"), "Фёдорова Асида Федоровна", "89506225278" },
                    { new Guid("d7e0d0ca-ded9-4297-806f-c0a1739cf2a3"), "Дорофеева Георгина Онисимовна", "89506330270" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductTypeRefId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("02186c64-2c0f-4044-8d73-ff9ecd93ab9a"), "Очиститель для тканей и мебели ОС-Гель", 280m, 3, 15 },
                    { new Guid("0b0cd994-b28c-47e2-af30-e5a0d1620da2"), "Швабра Master House Джайв", 199.99m, 3, 21 },
                    { new Guid("1917cbd5-5bac-445a-82fa-0ecd9d8c7d78"), "Набор инструментов Квалитет 5027038", 5699.9m, 2, 9 },
                    { new Guid("1e40750f-4ecd-4311-94c2-4ea162371572"), "Швабра Master House Бачата", 199.99m, 3, 33 },
                    { new Guid("25a9ca45-fdef-4f7f-889b-743ec5d1cd64"), "Инвертор DEXP CAR 150W", 750m, 1, 0 },
                    { new Guid("29d2e7b0-d807-4be7-9fe0-49d0c9258db8"), "LET Prestigio PTV50SS08X", 23199.9m, 0, 7 },
                    { new Guid("35261c3a-8f69-4820-9402-a5119a8425ba"), "Газонокосилка-робот Champion RMB1828", 49499.99m, 3, 8 },
                    { new Guid("35594658-80d7-44fa-b7b4-1e553dd0c014"), "AMD Ryzen 7 4700G OEM", 15499.99m, 0, 20 },
                    { new Guid("54404b97-fa8f-44c7-9668-34833699c01f"), "LED Harper 43F660Y", 15199m, 0, 6 },
                    { new Guid("6930d738-702f-471a-9bf5-8090af76d64b"), "Набор для ухода для стеклокерамических поверхностей Fiora bio ЭКО 20-002", 199m, 3, 5 },
                    { new Guid("81ed137c-acbc-49ce-9c24-8e509035ea9a"), "IPhone 8s", 67530.50m, 0, 12 },
                    { new Guid("83d895fc-bd45-49ce-906b-e523ecf2a670"), "Паяльная станция Rexant 12-0714", 4399m, 2, 2 },
                    { new Guid("887bb68c-0914-4724-b52f-65317ccd0dd2"), "Чистящее средство для нагревательных элементов электроплит/газовых плит Topper IR 5", 50m, 3, 0 },
                    { new Guid("9de07e25-623f-4c74-b28c-a9afcd4c9ecd"), "Набор инструментов Дело Техники 600937", 3033m, 2, 30 },
                    { new Guid("b2f29dff-dc58-467c-98ce-5ba25a631ede"), "Видеорегистратор 70mai Dash Cam M300", 3199.99m, 1, 5 },
                    { new Guid("be5355e6-1fd7-4598-a536-dffbde802cd6"), "Инструмент для вскрытия техники Rexant 12-4335", 99.99m, 2, 20 },
                    { new Guid("c81d2b57-ee83-4419-a204-2a6c547d59dd"), "Набор инструментов КВТ Профи НИИ-09", 1699m, 2, 10 },
                    { new Guid("cf2f2b98-eb5e-4276-86a6-2ddf79192f9d"), "Отвертка с набором насадок Matrix 11598", 110m, 2, 25 },
                    { new Guid("e0674811-953d-44df-abda-eb0a70510739"), "Камера заднего вида Silverstone F1 Interpower IP-662 LED", 799m, 1, 6 },
                    { new Guid("e2824192-935e-49c8-9f94-fc0f3decf7f8"), "ТВ розетка одинарная Schneider Electric Glossa GSL000391", 199.99m, 3, 20 },
                    { new Guid("eb3a550f-f4ed-4836-8362-b55fc41da63a"), "ASUS VivoBook 16X M1603QA", 51699m, 0, 11 },
                    { new Guid("ef9f969e-9374-4fda-872c-f3614bfa46ca"), "Набор инструментов Swiss Tools ST-1077", 5799.99m, 2, 20 },
                    { new Guid("fcf85a09-83e9-4901-b69a-96054fbd21bf"), "Адаптер для скрытого подключения видеорегистратора Roadgid Cord DC", 1199m, 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "ClientCredentials",
                columns: new[] { "ClientId", "Username", "Password" },
                values: new object[,]
                {
                    { new Guid("34fa4285-beb7-4e52-bcf4-bcd99e2d5b94"), "user34fa4285-beb7-4e52-bcf4-bcd99e2d5b94", "qwe12345" },
                    { new Guid("4a57edba-bfaa-4388-860b-7e6e1ed4ba83"), "user4a57edba-bfaa-4388-860b-7e6e1ed4ba83", "qwe12345" },
                    { new Guid("5721c29f-1f2e-4d02-83ff-9a3f57a817e6"), "user5721c29f-1f2e-4d02-83ff-9a3f57a817e6", "qwe12345" },
                    { new Guid("60a287dd-fea3-43fa-9d73-eaaab0e96ab8"), "user60a287dd-fea3-43fa-9d73-eaaab0e96ab8", "qwe12345" },
                    { new Guid("851e8bb2-9498-4852-b702-242d3cef6654"), "user851e8bb2-9498-4852-b702-242d3cef6654", "qwe12345" },
                    { new Guid("87184d4b-bc15-43cc-9dd3-f61da3a35095"), "user87184d4b-bc15-43cc-9dd3-f61da3a35095", "qwe12345" },
                    { new Guid("8f1fe072-c8cb-4a54-8001-056c0d6ba55f"), "user8f1fe072-c8cb-4a54-8001-056c0d6ba55f", "qwe12345" },
                    { new Guid("af93ed71-fb44-48fc-b9c8-2d018702bcc5"), "useraf93ed71-fb44-48fc-b9c8-2d018702bcc5", "qwe12345" },
                    { new Guid("b2cfbca6-48d2-4d2c-89bb-4c609b71deab"), "userb2cfbca6-48d2-4d2c-89bb-4c609b71deab", "qwe12345" },
                    { new Guid("c6697675-09ab-40d0-b853-f8831a989e77"), "userc6697675-09ab-40d0-b853-f8831a989e77", "qwe12345" },
                    { new Guid("d7e0d0ca-ded9-4297-806f-c0a1739cf2a3"), "userd7e0d0ca-ded9-4297-806f-c0a1739cf2a3", "qwe12345" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "CreatedAt" },
                values: new object[,]
                {
                    { new Guid("092d65c8-2309-4cd0-888d-fb0bdbf787d4"), new Guid("c6697675-09ab-40d0-b853-f8831a989e77"), new DateTime(2022, 3, 17, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(181) },
                    { new Guid("3bd6ada7-67c7-42fc-a535-b987c21bb673"), new Guid("87184d4b-bc15-43cc-9dd3-f61da3a35095"), new DateTime(2022, 3, 25, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(187) },
                    { new Guid("58516434-b850-466a-afb1-d4beb20b070f"), new Guid("34fa4285-beb7-4e52-bcf4-bcd99e2d5b94"), new DateTime(2022, 12, 18, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(192) },
                    { new Guid("65d5510a-a600-4b1b-b1f5-debc5316b2a0"), new Guid("d7e0d0ca-ded9-4297-806f-c0a1739cf2a3"), new DateTime(2023, 11, 7, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(168) },
                    { new Guid("6b6016dc-ec6e-4dff-a0a9-fb5ac1c8161b"), new Guid("851e8bb2-9498-4852-b702-242d3cef6654"), new DateTime(2022, 11, 25, 21, 47, 4, 720, DateTimeKind.Utc).AddTicks(8813) },
                    { new Guid("6ff684fa-bf85-47bf-b78b-f1e9f25dc976"), new Guid("8f1fe072-c8cb-4a54-8001-056c0d6ba55f"), new DateTime(2023, 1, 20, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(178) },
                    { new Guid("73d13147-917f-4187-94ff-2330622fa4e1"), new Guid("60a287dd-fea3-43fa-9d73-eaaab0e96ab8"), new DateTime(2022, 7, 17, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(205) },
                    { new Guid("8d1602ca-63f3-45ee-b3af-e33e2d9145fa"), new Guid("d7e0d0ca-ded9-4297-806f-c0a1739cf2a3"), new DateTime(2023, 5, 22, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(199) },
                    { new Guid("a31861b0-3732-40d3-b2ca-9999f63c7662"), new Guid("c6697675-09ab-40d0-b853-f8831a989e77"), new DateTime(2024, 3, 29, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(171) },
                    { new Guid("a3db2e0b-fed6-4a26-9535-4a2ddbab77d0"), new Guid("b2cfbca6-48d2-4d2c-89bb-4c609b71deab"), new DateTime(2024, 2, 24, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(195) },
                    { new Guid("ab0bae64-223f-477f-9dae-33876f6efb2d"), new Guid("c6697675-09ab-40d0-b853-f8831a989e77"), new DateTime(2023, 11, 29, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(202) },
                    { new Guid("b8c709c8-3d09-4442-aa3c-eecc9d92ef84"), new Guid("b2cfbca6-48d2-4d2c-89bb-4c609b71deab"), new DateTime(2023, 7, 25, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(204) },
                    { new Guid("ba057d6f-7ed3-4751-8b9c-ec4ccee42a31"), new Guid("b2cfbca6-48d2-4d2c-89bb-4c609b71deab"), new DateTime(2022, 10, 24, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(207) },
                    { new Guid("bb27cab5-5938-4ae1-8a0d-cddad6f86eb5"), new Guid("87184d4b-bc15-43cc-9dd3-f61da3a35095"), new DateTime(2024, 1, 2, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(180) },
                    { new Guid("cad06823-eb93-4370-a8f6-3b8005a91f13"), new Guid("34fa4285-beb7-4e52-bcf4-bcd99e2d5b94"), new DateTime(2022, 7, 19, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(190) },
                    { new Guid("cf275dd4-0cdc-433e-aaa3-d754300cf486"), new Guid("5721c29f-1f2e-4d02-83ff-9a3f57a817e6"), new DateTime(2024, 2, 23, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(189) },
                    { new Guid("d139c831-dae3-49f2-8008-5d4498978b9e"), new Guid("d7e0d0ca-ded9-4297-806f-c0a1739cf2a3"), new DateTime(2024, 3, 4, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(184) },
                    { new Guid("d311cb52-1729-40aa-8277-54d89d3bd17a"), new Guid("8f1fe072-c8cb-4a54-8001-056c0d6ba55f"), new DateTime(2022, 5, 9, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(155) },
                    { new Guid("d342f791-7303-43d1-8e44-c43b34628330"), new Guid("34fa4285-beb7-4e52-bcf4-bcd99e2d5b94"), new DateTime(2023, 4, 7, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(194) },
                    { new Guid("dd20ffe8-4ab1-46b6-a32b-ff14d4b09170"), new Guid("8f1fe072-c8cb-4a54-8001-056c0d6ba55f"), new DateTime(2023, 4, 17, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(176) },
                    { new Guid("df96aae7-ff70-4005-83ff-cc19da3e6e0a"), new Guid("4a57edba-bfaa-4388-860b-7e6e1ed4ba83"), new DateTime(2022, 5, 26, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(172) },
                    { new Guid("edc81d57-3e1e-4e56-b3b5-b72dfb03e79a"), new Guid("4a57edba-bfaa-4388-860b-7e6e1ed4ba83"), new DateTime(2022, 9, 25, 21, 47, 4, 721, DateTimeKind.Utc).AddTicks(197) }
                });

            migrationBuilder.InsertData(
                table: "ProductsInOrders",
                columns: new[] { "Id", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("07e9c8fe-a041-486d-b5b7-77bdd3cd7a3b"), new Guid("a31861b0-3732-40d3-b2ca-9999f63c7662"), 3196m, new Guid("e0674811-953d-44df-abda-eb0a70510739"), 4 },
                    { new Guid("0abbf199-5fb8-4ae6-abc6-18c9a0d30f48"), new Guid("a31861b0-3732-40d3-b2ca-9999f63c7662"), 799.96m, new Guid("e2824192-935e-49c8-9f94-fc0f3decf7f8"), 4 },
                    { new Guid("11b88cde-4239-45e0-a048-95de8de17ba2"), new Guid("df96aae7-ff70-4005-83ff-cc19da3e6e0a"), 799.96m, new Guid("1e40750f-4ecd-4311-94c2-4ea162371572"), 4 },
                    { new Guid("179aef14-1867-4aa1-bfc7-ada9a8b8293a"), new Guid("a3db2e0b-fed6-4a26-9535-4a2ddbab77d0"), 51699m, new Guid("eb3a550f-f4ed-4836-8362-b55fc41da63a"), 1 },
                    { new Guid("1d92ca73-f574-4cbb-becf-df06c4eaf65d"), new Guid("58516434-b850-466a-afb1-d4beb20b070f"), 599.97m, new Guid("1e40750f-4ecd-4311-94c2-4ea162371572"), 3 },
                    { new Guid("20f481a1-ca12-4dfe-8a5b-d001252ec79c"), new Guid("6b6016dc-ec6e-4dff-a0a9-fb5ac1c8161b"), 5097m, new Guid("c81d2b57-ee83-4419-a204-2a6c547d59dd"), 3 },
                    { new Guid("31e9e5a5-ccf0-433c-9ef7-14589f975632"), new Guid("3bd6ada7-67c7-42fc-a535-b987c21bb673"), 199.99m, new Guid("e2824192-935e-49c8-9f94-fc0f3decf7f8"), 1 },
                    { new Guid("433c0590-7305-4898-b71d-a5a99dfbad30"), new Guid("6ff684fa-bf85-47bf-b78b-f1e9f25dc976"), 247499.95m, new Guid("35261c3a-8f69-4820-9402-a5119a8425ba"), 5 },
                    { new Guid("43ae5f58-5512-49ad-b237-1e1d6f5f2636"), new Guid("58516434-b850-466a-afb1-d4beb20b070f"), 250m, new Guid("887bb68c-0914-4724-b52f-65317ccd0dd2"), 5 },
                    { new Guid("5075a2e4-b75a-43af-97ae-5514343438c5"), new Guid("d311cb52-1729-40aa-8277-54d89d3bd17a"), 100m, new Guid("887bb68c-0914-4724-b52f-65317ccd0dd2"), 2 },
                    { new Guid("5e516f11-1262-4df7-90fa-3a756aa7cb34"), new Guid("edc81d57-3e1e-4e56-b3b5-b72dfb03e79a"), 799.96m, new Guid("e2824192-935e-49c8-9f94-fc0f3decf7f8"), 4 },
                    { new Guid("6343eae5-b43d-466b-bce9-9ab31028ac6b"), new Guid("d342f791-7303-43d1-8e44-c43b34628330"), 3995m, new Guid("e0674811-953d-44df-abda-eb0a70510739"), 5 },
                    { new Guid("65b1099f-75a9-4db7-b978-d1ed0be73a92"), new Guid("d311cb52-1729-40aa-8277-54d89d3bd17a"), 45597m, new Guid("54404b97-fa8f-44c7-9668-34833699c01f"), 3 },
                    { new Guid("65b8be63-1bbe-40c4-9c8e-0a050c351e2f"), new Guid("3bd6ada7-67c7-42fc-a535-b987c21bb673"), 995m, new Guid("6930d738-702f-471a-9bf5-8090af76d64b"), 5 },
                    { new Guid("6cd0c651-5768-45d2-b07f-82c2cea313cd"), new Guid("b8c709c8-3d09-4442-aa3c-eecc9d92ef84"), 3196m, new Guid("e0674811-953d-44df-abda-eb0a70510739"), 4 },
                    { new Guid("6db2e2aa-da89-424b-9eda-8d88932a9b0b"), new Guid("ab0bae64-223f-477f-9dae-33876f6efb2d"), 199.99m, new Guid("e2824192-935e-49c8-9f94-fc0f3decf7f8"), 1 },
                    { new Guid("711fb9a4-eb44-4bc6-a88a-acf68cf25a13"), new Guid("d311cb52-1729-40aa-8277-54d89d3bd17a"), 197999.96m, new Guid("35261c3a-8f69-4820-9402-a5119a8425ba"), 4 },
                    { new Guid("76646481-77ab-44e2-8f32-e1a185455459"), new Guid("bb27cab5-5938-4ae1-8a0d-cddad6f86eb5"), 398m, new Guid("6930d738-702f-471a-9bf5-8090af76d64b"), 2 },
                    { new Guid("79203193-a75b-4a38-9e18-28d14d35b99c"), new Guid("d342f791-7303-43d1-8e44-c43b34628330"), 995m, new Guid("6930d738-702f-471a-9bf5-8090af76d64b"), 5 },
                    { new Guid("7b14f92d-3407-43d3-8bad-7b2e32977043"), new Guid("3bd6ada7-67c7-42fc-a535-b987c21bb673"), 3995m, new Guid("e0674811-953d-44df-abda-eb0a70510739"), 5 },
                    { new Guid("7c436d75-e700-4377-bcda-002332ae9de9"), new Guid("ab0bae64-223f-477f-9dae-33876f6efb2d"), 199.99m, new Guid("e2824192-935e-49c8-9f94-fc0f3decf7f8"), 1 },
                    { new Guid("802e891b-d51c-4dbd-a94c-4e4e0ea6802d"), new Guid("cf275dd4-0cdc-433e-aaa3-d754300cf486"), 17099.7m, new Guid("1917cbd5-5bac-445a-82fa-0ecd9d8c7d78"), 3 },
                    { new Guid("887a1ce7-16e8-44a3-9c80-df65a57cf48c"), new Guid("d139c831-dae3-49f2-8008-5d4498978b9e"), 750m, new Guid("25a9ca45-fdef-4f7f-889b-743ec5d1cd64"), 1 },
                    { new Guid("8b231d2b-86b7-4e87-a6e3-58e1c355c04b"), new Guid("ba057d6f-7ed3-4751-8b9c-ec4ccee42a31"), 2398m, new Guid("fcf85a09-83e9-4901-b69a-96054fbd21bf"), 2 },
                    { new Guid("96626498-2638-4437-b27e-75f7530888e7"), new Guid("bb27cab5-5938-4ae1-8a0d-cddad6f86eb5"), 197999.96m, new Guid("35261c3a-8f69-4820-9402-a5119a8425ba"), 4 },
                    { new Guid("9f27a547-bbf3-4e92-9dea-5f0d1777f2f1"), new Guid("a3db2e0b-fed6-4a26-9535-4a2ddbab77d0"), 5097m, new Guid("c81d2b57-ee83-4419-a204-2a6c547d59dd"), 3 },
                    { new Guid("a856dcc7-765d-42de-9410-8e2e5b8de730"), new Guid("6b6016dc-ec6e-4dff-a0a9-fb5ac1c8161b"), 11599.98m, new Guid("ef9f969e-9374-4fda-872c-f3614bfa46ca"), 2 },
                    { new Guid("af29d2b4-f0e9-429c-b637-4893ccd8bce5"), new Guid("ba057d6f-7ed3-4751-8b9c-ec4ccee42a31"), 12132m, new Guid("9de07e25-623f-4c74-b28c-a9afcd4c9ecd"), 4 },
                    { new Guid("af86fca6-9aeb-41a7-89ed-a2c06779f15f"), new Guid("d139c831-dae3-49f2-8008-5d4498978b9e"), 258495m, new Guid("eb3a550f-f4ed-4836-8362-b55fc41da63a"), 5 },
                    { new Guid("c01e7d2c-7a22-4566-859f-9661ac1dc6d3"), new Guid("58516434-b850-466a-afb1-d4beb20b070f"), 15165m, new Guid("9de07e25-623f-4c74-b28c-a9afcd4c9ecd"), 5 },
                    { new Guid("c5389f46-37cf-4a00-9cf6-d8397cc691cd"), new Guid("d139c831-dae3-49f2-8008-5d4498978b9e"), 98999.98m, new Guid("35261c3a-8f69-4820-9402-a5119a8425ba"), 2 },
                    { new Guid("c8923a35-0767-4cf6-89ad-ec5242049242"), new Guid("cf275dd4-0cdc-433e-aaa3-d754300cf486"), 199.99m, new Guid("e2824192-935e-49c8-9f94-fc0f3decf7f8"), 1 },
                    { new Guid("cc7087fb-65de-4a0c-801a-5328fee3f14f"), new Guid("092d65c8-2309-4cd0-888d-fb0bdbf787d4"), 77499.95m, new Guid("35594658-80d7-44fa-b7b4-1e553dd0c014"), 5 },
                    { new Guid("cce2f613-23c6-45d8-b0ed-0e1e5856ebdd"), new Guid("a3db2e0b-fed6-4a26-9535-4a2ddbab77d0"), 398m, new Guid("6930d738-702f-471a-9bf5-8090af76d64b"), 2 },
                    { new Guid("dcba3f24-fa50-4d20-a6f0-705637cb3f30"), new Guid("df96aae7-ff70-4005-83ff-cc19da3e6e0a"), 1598m, new Guid("e0674811-953d-44df-abda-eb0a70510739"), 2 },
                    { new Guid("e718e903-f2a3-43e2-8c8e-ef9733c17061"), new Guid("d342f791-7303-43d1-8e44-c43b34628330"), 2250m, new Guid("25a9ca45-fdef-4f7f-889b-743ec5d1cd64"), 3 },
                    { new Guid("ec7870f9-7161-4e82-9945-b4d3347e2a8e"), new Guid("dd20ffe8-4ab1-46b6-a32b-ff14d4b09170"), 3398m, new Guid("c81d2b57-ee83-4419-a204-2a6c547d59dd"), 2 },
                    { new Guid("f212b069-eaa4-42ce-a7bd-545d83906fe2"), new Guid("ab0bae64-223f-477f-9dae-33876f6efb2d"), 4796m, new Guid("fcf85a09-83e9-4901-b69a-96054fbd21bf"), 4 },
                    { new Guid("fd263581-9d83-4d79-99a9-7426a8e46fef"), new Guid("65d5510a-a600-4b1b-b1f5-debc5316b2a0"), 270122.00m, new Guid("81ed137c-acbc-49ce-9c24-8e509035ea9a"), 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientCredentials");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("af93ed71-fb44-48fc-b9c8-2d018702bcc5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("73d13147-917f-4187-94ff-2330622fa4e1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8d1602ca-63f3-45ee-b3af-e33e2d9145fa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cad06823-eb93-4370-a8f6-3b8005a91f13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02186c64-2c0f-4044-8d73-ff9ecd93ab9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b0cd994-b28c-47e2-af30-e5a0d1620da2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29d2e7b0-d807-4be7-9fe0-49d0c9258db8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83d895fc-bd45-49ce-906b-e523ecf2a670"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2f29dff-dc58-467c-98ce-5ba25a631ede"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be5355e6-1fd7-4598-a536-dffbde802cd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf2f2b98-eb5e-4276-86a6-2ddf79192f9d"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("07e9c8fe-a041-486d-b5b7-77bdd3cd7a3b"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("0abbf199-5fb8-4ae6-abc6-18c9a0d30f48"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("11b88cde-4239-45e0-a048-95de8de17ba2"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("179aef14-1867-4aa1-bfc7-ada9a8b8293a"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("1d92ca73-f574-4cbb-becf-df06c4eaf65d"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("20f481a1-ca12-4dfe-8a5b-d001252ec79c"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("31e9e5a5-ccf0-433c-9ef7-14589f975632"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("433c0590-7305-4898-b71d-a5a99dfbad30"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("43ae5f58-5512-49ad-b237-1e1d6f5f2636"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("5075a2e4-b75a-43af-97ae-5514343438c5"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("5e516f11-1262-4df7-90fa-3a756aa7cb34"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6343eae5-b43d-466b-bce9-9ab31028ac6b"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("65b1099f-75a9-4db7-b978-d1ed0be73a92"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("65b8be63-1bbe-40c4-9c8e-0a050c351e2f"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6cd0c651-5768-45d2-b07f-82c2cea313cd"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6db2e2aa-da89-424b-9eda-8d88932a9b0b"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("711fb9a4-eb44-4bc6-a88a-acf68cf25a13"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("76646481-77ab-44e2-8f32-e1a185455459"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("79203193-a75b-4a38-9e18-28d14d35b99c"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("7b14f92d-3407-43d3-8bad-7b2e32977043"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("7c436d75-e700-4377-bcda-002332ae9de9"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("802e891b-d51c-4dbd-a94c-4e4e0ea6802d"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("887a1ce7-16e8-44a3-9c80-df65a57cf48c"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("8b231d2b-86b7-4e87-a6e3-58e1c355c04b"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("96626498-2638-4437-b27e-75f7530888e7"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("9f27a547-bbf3-4e92-9dea-5f0d1777f2f1"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("a856dcc7-765d-42de-9410-8e2e5b8de730"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("af29d2b4-f0e9-429c-b637-4893ccd8bce5"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("af86fca6-9aeb-41a7-89ed-a2c06779f15f"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("c01e7d2c-7a22-4566-859f-9661ac1dc6d3"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("c5389f46-37cf-4a00-9cf6-d8397cc691cd"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("c8923a35-0767-4cf6-89ad-ec5242049242"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("cc7087fb-65de-4a0c-801a-5328fee3f14f"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("cce2f613-23c6-45d8-b0ed-0e1e5856ebdd"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("dcba3f24-fa50-4d20-a6f0-705637cb3f30"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("e718e903-f2a3-43e2-8c8e-ef9733c17061"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("ec7870f9-7161-4e82-9945-b4d3347e2a8e"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("f212b069-eaa4-42ce-a7bd-545d83906fe2"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("fd263581-9d83-4d79-99a9-7426a8e46fef"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("60a287dd-fea3-43fa-9d73-eaaab0e96ab8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("092d65c8-2309-4cd0-888d-fb0bdbf787d4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3bd6ada7-67c7-42fc-a535-b987c21bb673"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("58516434-b850-466a-afb1-d4beb20b070f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("65d5510a-a600-4b1b-b1f5-debc5316b2a0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6b6016dc-ec6e-4dff-a0a9-fb5ac1c8161b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ff684fa-bf85-47bf-b78b-f1e9f25dc976"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a31861b0-3732-40d3-b2ca-9999f63c7662"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a3db2e0b-fed6-4a26-9535-4a2ddbab77d0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ab0bae64-223f-477f-9dae-33876f6efb2d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b8c709c8-3d09-4442-aa3c-eecc9d92ef84"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba057d6f-7ed3-4751-8b9c-ec4ccee42a31"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bb27cab5-5938-4ae1-8a0d-cddad6f86eb5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cf275dd4-0cdc-433e-aaa3-d754300cf486"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d139c831-dae3-49f2-8008-5d4498978b9e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d311cb52-1729-40aa-8277-54d89d3bd17a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d342f791-7303-43d1-8e44-c43b34628330"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("dd20ffe8-4ab1-46b6-a32b-ff14d4b09170"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("df96aae7-ff70-4005-83ff-cc19da3e6e0a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("edc81d57-3e1e-4e56-b3b5-b72dfb03e79a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1917cbd5-5bac-445a-82fa-0ecd9d8c7d78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e40750f-4ecd-4311-94c2-4ea162371572"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25a9ca45-fdef-4f7f-889b-743ec5d1cd64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35261c3a-8f69-4820-9402-a5119a8425ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35594658-80d7-44fa-b7b4-1e553dd0c014"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54404b97-fa8f-44c7-9668-34833699c01f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6930d738-702f-471a-9bf5-8090af76d64b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81ed137c-acbc-49ce-9c24-8e509035ea9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("887bb68c-0914-4724-b52f-65317ccd0dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9de07e25-623f-4c74-b28c-a9afcd4c9ecd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c81d2b57-ee83-4419-a204-2a6c547d59dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0674811-953d-44df-abda-eb0a70510739"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2824192-935e-49c8-9f94-fc0f3decf7f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb3a550f-f4ed-4836-8362-b55fc41da63a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef9f969e-9374-4fda-872c-f3614bfa46ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcf85a09-83e9-4901-b69a-96054fbd21bf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("34fa4285-beb7-4e52-bcf4-bcd99e2d5b94"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4a57edba-bfaa-4388-860b-7e6e1ed4ba83"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5721c29f-1f2e-4d02-83ff-9a3f57a817e6"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("851e8bb2-9498-4852-b702-242d3cef6654"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("87184d4b-bc15-43cc-9dd3-f61da3a35095"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8f1fe072-c8cb-4a54-8001-056c0d6ba55f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b2cfbca6-48d2-4d2c-89bb-4c609b71deab"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c6697675-09ab-40d0-b853-f8831a989e77"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d7e0d0ca-ded9-4297-806f-c0a1739cf2a3"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 2, 0, 37, 8, 632, DateTimeKind.Utc).AddTicks(2109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 5, 21, 47, 6, 509, DateTimeKind.Utc).AddTicks(208));

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
        }
    }
}
