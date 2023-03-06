using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderingService.Dal.Migrations
{
    /// <inheritdoc />
    public partial class RenameClientColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4"), "user0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("2b44f8cf-6848-4bef-8e19-86cbf68a4b38"), "user2b44f8cf-6848-4bef-8e19-86cbf68a4b38" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("37e6a4d8-201e-4c0c-be4b-e6a9ea150661"), "user37e6a4d8-201e-4c0c-be4b-e6a9ea150661" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("39540cc0-884e-4ed3-927d-4bbd3c60bf8c"), "user39540cc0-884e-4ed3-927d-4bbd3c60bf8c" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("6f1867f7-3613-4946-bd30-b391eba544e3"), "user6f1867f7-3613-4946-bd30-b391eba544e3" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("a6722490-3731-4c32-994f-d9cdc6177956"), "usera6722490-3731-4c32-994f-d9cdc6177956" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("acfef8fa-8c16-49b5-9c28-f71cd5e08027"), "useracfef8fa-8c16-49b5-9c28-f71cd5e08027" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("be64dfa7-50dc-4c15-83f1-b5136c304604"), "userbe64dfa7-50dc-4c15-83f1-b5136c304604" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("bf12d20f-fbc2-4e79-907c-9b2b26e76627"), "userbf12d20f-fbc2-4e79-907c-9b2b26e76627" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("cae2788e-e9cd-4777-beb3-f4f8305cb23b"), "usercae2788e-e9cd-4777-beb3-f4f8305cb23b" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("d732f3b3-ceb9-48ac-8012-0a71d5ca1a11"), "userd732f3b3-ceb9-48ac-8012-0a71d5ca1a11" });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("00cf9b92-6512-4ace-8346-4177972473c3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("11f53c0d-cb9d-4fa1-be1b-6f2b9dd7c3b5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1d832cd8-76d9-4aa5-b61f-90b1bcd1a197"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6f77ae1e-e91f-404d-95f9-901d843d2522"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7ece1041-5bff-4bbd-ab90-e617bf5ab90e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("956173c5-83ae-4226-bf0f-f2ab520d36f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b4ba6039-9833-4a76-8904-fac727da750e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ccb914e4-8f55-4693-8c09-e54afd119f82"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("df37f39f-1995-492e-ab64-aac4e037e452"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e7c0aaa8-c127-4e35-a5a7-0bf993c908d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1eee1463-5589-4924-89a7-138787dec704"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c9d1390-0d3b-4c8e-bbe9-1d7f19916a89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("429445da-7f29-4724-bbef-ec93c7981425"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79846436-38d6-4255-9b41-061a1322374b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9960d886-ebb9-4c0b-b4c0-13d15d3d197e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad58b674-4a47-4d34-9b67-7b4e45849f94"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dec3c83d-d254-432e-a820-201dde19af14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e19d3272-c4ec-422a-8eea-bccb4854dbc6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eafdac08-8890-4b5c-a1f7-a786151694d9"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("09b8b235-dfdf-4834-a9b5-a212d11bc85d"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("10f35968-ff2a-4614-aced-88b8b77c8fe7"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("14ac4002-2404-4f19-adf7-f97f1f49cd71"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("1c2d9a60-0425-4b14-b21f-073c5fa93675"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("21f8d556-e96c-4d97-b38f-ae01ddc25c70"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("23f4d547-9ba7-4d59-b432-5ba07c0ac735"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("303bfb76-f04b-4ee5-8ce4-46d5a78d6d2b"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("48608476-9b2b-4c64-9535-ef3d096bb864"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("602f32d7-faaf-4c53-95fd-2c7f2668018a"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6579e59e-0f7a-47dd-b4b7-53edae366db3"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6c4581ff-bc86-40e2-9ac7-80ed499606da"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6d373a94-4d35-43d6-9226-66e61f341b76"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6ddc433d-25cf-49f4-862b-4e3c35921176"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("91a02821-80af-48da-a04a-b231da2bc667"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("aa6fc293-01ec-4dba-8bb2-aea4b2448fc2"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("ac4874c9-c98c-4684-9612-741c572158f3"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("b0559478-0c0b-4b05-9ba1-b32379912143"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("c739debb-a485-4f01-b583-2cff2f3f70c8"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("d358401d-b57f-448c-ab22-a50fc4cda82a"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("f6a762eb-4e19-4f72-a686-2d995d27ea85"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("37e6a4d8-201e-4c0c-be4b-e6a9ea150661"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6f1867f7-3613-4946-bd30-b391eba544e3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a6722490-3731-4c32-994f-d9cdc6177956"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d732f3b3-ceb9-48ac-8012-0a71d5ca1a11"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2211d318-12d3-49bc-9094-c909404cbd39"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("32a55c00-475e-418a-89e3-6a396fe6e9fb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3609fba9-c39b-4ba2-b551-d9dbe84be705"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("50a10916-8493-4cd1-b7f0-3c233cb6d1ef"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("751b9c14-166c-4403-84db-a78452a2c254"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7dbe25c9-ff88-42ac-bfbf-39da813b1bd0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ab1befaf-93bd-4fe0-af35-59525ee78e29"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b0efa5a1-097e-4240-8584-1f331028f2c3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bb200105-1331-4a4b-bb49-0a216a7b59f7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ccd8b5cb-9fca-4eff-8d88-39f7aa3459f9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("dd7c5359-7809-4188-8764-c2ae74bf6cac"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("efb4511f-bd7f-4e0a-a814-323d034735d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04a68ff5-11cb-40f2-a255-023313b4d9f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4af69082-2e63-49de-b18c-960c215a18fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e92f4c8-25aa-4a49-b244-c6ee417df4b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c9369d1-3fc5-47d6-9954-69638aeb3c34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97db5d13-ec20-4bfd-b035-bc57e1319bc4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf04feb2-590d-4297-ac38-067516e17a3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce9cf65f-e543-4806-9ddf-8eee7a1d5431"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d73f1127-11f0-4bb0-a70c-2371cd1e6c41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8f88e30-0624-4311-9f4a-4c74822fe4ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3c88564-f375-472e-a639-b66a1382fff7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea105f07-4c1d-408b-8d20-ed46c81f7989"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ebfe59da-773c-421f-8818-beb494b6663d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1fcd5bc-8928-409f-add6-c26ec85f497c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f576f1cd-9e46-4c62-945e-6ef8a11e14df"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2b44f8cf-6848-4bef-8e19-86cbf68a4b38"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("39540cc0-884e-4ed3-927d-4bbd3c60bf8c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("acfef8fa-8c16-49b5-9c28-f71cd5e08027"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("be64dfa7-50dc-4c15-83f1-b5136c304604"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bf12d20f-fbc2-4e79-907c-9b2b26e76627"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cae2788e-e9cd-4777-beb3-f4f8305cb23b"));

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "ClientCredentials",
                newName: "Login");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 6, 9, 50, 52, 2, DateTimeKind.Utc).AddTicks(7564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 6, 0, 19, 12, 643, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FullName", "Phone" },
                values: new object[,]
                {
                    { new Guid("03e318e4-ec62-44d9-9b03-bb9d82f095bf"), "Лазарева Лигия Пётровна", "89506225268" },
                    { new Guid("1680c207-3d83-41af-a3e9-2294c69d503f"), "Воронцов Любомир Антонович", "89906225025" },
                    { new Guid("30c71f76-c0aa-4282-bfd9-819098097bcc"), "Баранова Марьяна Рудольфовна", "89506224428" },
                    { new Guid("34eacd12-4d0b-4442-a763-eda447b4ebb2"), "Меркушев Бенедикт Алексеевич", "89996225028" },
                    { new Guid("5bb12261-d704-4afe-85bf-a41e83f074ac"), "Ларионов Аввакуум Христофорович", "89506335028" },
                    { new Guid("65955faa-1533-4eef-b18a-07a359fa3b16"), "Зайцева Римма Аристарховна", "89503335028" },
                    { new Guid("6ca29f4a-970c-474d-a9ff-4714beb7be62"), "Савин Август Оскарович", "89506225026" },
                    { new Guid("79c604bd-57d4-497a-8993-20df12e2e58e"), "Беляков Демьян Степанович", "89606225028" },
                    { new Guid("807a2345-2063-4125-a91f-d843ca45e5c3"), "Ефимов Аким Лаврентьевич", "89506225027" },
                    { new Guid("9bdf143e-8f1c-485e-a83a-2c94fa2708a5"), "Дорофеева Георгина Онисимовна", "89506330270" },
                    { new Guid("fccf7ff0-d1f4-4007-a8e0-32bd3d88558e"), "Фёдорова Асида Федоровна", "89506225278" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductTypeRefId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0c04497a-8537-4d21-a325-48d013ef9707"), "Набор инструментов КВТ Профи НИИ-09", 1699m, 2, 10 },
                    { new Guid("1300f356-0537-4f24-b0d9-3f84c655a4d3"), "Швабра Master House Джайв", 199.99m, 3, 21 },
                    { new Guid("1effa22a-05e2-43af-8db7-9225e83903be"), "Инструмент для вскрытия техники Rexant 12-4335", 99.99m, 2, 20 },
                    { new Guid("24447a08-e8fe-4dad-b3d3-78e4e5ba88d5"), "ASUS VivoBook 16X M1603QA", 51699m, 0, 11 },
                    { new Guid("27134bfe-a2af-4c3f-a838-896f98d0ba76"), "Видеорегистратор 70mai Dash Cam M300", 3199.99m, 1, 5 },
                    { new Guid("2f186d0f-8524-47d6-a8d3-ab9036c55d03"), "Адаптер для скрытого подключения видеорегистратора Roadgid Cord DC", 1199m, 1, 10 },
                    { new Guid("3beb3098-b45f-467f-89d4-8673c21da150"), "Камера заднего вида Silverstone F1 Interpower IP-662 LED", 799m, 1, 6 },
                    { new Guid("505ec744-ad33-4b6b-a8f3-22c1db4a94c2"), "LET Prestigio PTV50SS08X", 23199.9m, 0, 7 },
                    { new Guid("63cf6371-9d33-4665-9ef8-9f69b8fceec6"), "AMD Ryzen 7 4700G OEM", 15499.99m, 0, 20 },
                    { new Guid("719cc4d6-3208-4525-b259-0839ff16c7ac"), "Очиститель для тканей и мебели ОС-Гель", 280m, 3, 15 },
                    { new Guid("772811cd-e96c-41cf-94f4-2406dd7b07ac"), "Набор инструментов Квалитет 5027038", 5699.9m, 2, 9 },
                    { new Guid("7d9df395-5669-459d-9d0b-2a9ec2972671"), "Швабра Master House Бачата", 199.99m, 3, 33 },
                    { new Guid("7dc25886-363c-43ff-b3ac-e6a54d461c23"), "Чистящее средство для нагревательных элементов электроплит/газовых плит Topper IR 5", 50m, 3, 0 },
                    { new Guid("7f868a2a-03f3-4e2a-91fc-2ec82e737a84"), "Газонокосилка-робот Champion RMB1828", 49499.99m, 3, 8 },
                    { new Guid("800ffca3-414c-4bb1-bfab-e33f3c8678f8"), "Набор для ухода для стеклокерамических поверхностей Fiora bio ЭКО 20-002", 199m, 3, 5 },
                    { new Guid("824c826c-980c-48be-bedd-3d1aa5fc2a29"), "Набор инструментов Дело Техники 600937", 3033m, 2, 30 },
                    { new Guid("93cd02e8-12d0-4d9e-95e2-89db8589dfed"), "IPhone 8s", 67530.50m, 0, 12 },
                    { new Guid("994f1902-0047-4086-bba3-0c1d9f1008dd"), "Инвертор DEXP CAR 150W", 750m, 1, 0 },
                    { new Guid("b824cfa1-1933-49ff-a7f1-3604f8ef31c0"), "LED Harper 43F660Y", 15199m, 0, 6 },
                    { new Guid("bba40a48-aab4-4a47-a6af-82068a1ad39b"), "Паяльная станция Rexant 12-0714", 4399m, 2, 2 },
                    { new Guid("deea5cbd-7ac6-45f3-9724-cc95c5b234ba"), "ТВ розетка одинарная Schneider Electric Glossa GSL000391", 199.99m, 3, 20 },
                    { new Guid("eecd98da-450e-4890-be4c-433a94513557"), "Отвертка с набором насадок Matrix 11598", 110m, 2, 25 },
                    { new Guid("fff57134-e573-488b-bd1c-275ce6a3033a"), "Набор инструментов Swiss Tools ST-1077", 5799.99m, 2, 20 }
                });

            migrationBuilder.InsertData(
                table: "ClientCredentials",
                columns: new[] { "ClientId", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("03e318e4-ec62-44d9-9b03-bb9d82f095bf"), "user03e318e4-ec62-44d9-9b03-bb9d82f095bf", "qwe12345" },
                    { new Guid("1680c207-3d83-41af-a3e9-2294c69d503f"), "user1680c207-3d83-41af-a3e9-2294c69d503f", "qwe12345" },
                    { new Guid("30c71f76-c0aa-4282-bfd9-819098097bcc"), "user30c71f76-c0aa-4282-bfd9-819098097bcc", "qwe12345" },
                    { new Guid("34eacd12-4d0b-4442-a763-eda447b4ebb2"), "user34eacd12-4d0b-4442-a763-eda447b4ebb2", "qwe12345" },
                    { new Guid("5bb12261-d704-4afe-85bf-a41e83f074ac"), "user5bb12261-d704-4afe-85bf-a41e83f074ac", "qwe12345" },
                    { new Guid("65955faa-1533-4eef-b18a-07a359fa3b16"), "user65955faa-1533-4eef-b18a-07a359fa3b16", "qwe12345" },
                    { new Guid("6ca29f4a-970c-474d-a9ff-4714beb7be62"), "user6ca29f4a-970c-474d-a9ff-4714beb7be62", "qwe12345" },
                    { new Guid("79c604bd-57d4-497a-8993-20df12e2e58e"), "user79c604bd-57d4-497a-8993-20df12e2e58e", "qwe12345" },
                    { new Guid("807a2345-2063-4125-a91f-d843ca45e5c3"), "user807a2345-2063-4125-a91f-d843ca45e5c3", "qwe12345" },
                    { new Guid("9bdf143e-8f1c-485e-a83a-2c94fa2708a5"), "user9bdf143e-8f1c-485e-a83a-2c94fa2708a5", "qwe12345" },
                    { new Guid("fccf7ff0-d1f4-4007-a8e0-32bd3d88558e"), "userfccf7ff0-d1f4-4007-a8e0-32bd3d88558e", "qwe12345" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "CreatedAt" },
                values: new object[,]
                {
                    { new Guid("1b323bf9-37a5-4e54-870e-3a02da72cc8f"), new Guid("30c71f76-c0aa-4282-bfd9-819098097bcc"), new DateTime(2023, 6, 23, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3261) },
                    { new Guid("245673a2-ae8a-452e-a770-f6a6dafa845e"), new Guid("fccf7ff0-d1f4-4007-a8e0-32bd3d88558e"), new DateTime(2023, 9, 13, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3234) },
                    { new Guid("263eeaaf-8f04-40c2-9eda-72b55e6dfa3a"), new Guid("fccf7ff0-d1f4-4007-a8e0-32bd3d88558e"), new DateTime(2022, 8, 16, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3236) },
                    { new Guid("27c00a03-9173-43af-aca3-ff0a4475762c"), new Guid("6ca29f4a-970c-474d-a9ff-4714beb7be62"), new DateTime(2022, 12, 5, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3266) },
                    { new Guid("463b5139-832e-4d72-b766-b03a654e85d1"), new Guid("79c604bd-57d4-497a-8993-20df12e2e58e"), new DateTime(2024, 1, 25, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3253) },
                    { new Guid("4b921a3e-1872-48cb-a808-654dce38e754"), new Guid("65955faa-1533-4eef-b18a-07a359fa3b16"), new DateTime(2022, 10, 29, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3242) },
                    { new Guid("543785f4-9b5b-47b3-8940-839635f4357d"), new Guid("fccf7ff0-d1f4-4007-a8e0-32bd3d88558e"), new DateTime(2023, 12, 14, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3258) },
                    { new Guid("59449844-13bb-46f4-be5a-8d22a87e4428"), new Guid("1680c207-3d83-41af-a3e9-2294c69d503f"), new DateTime(2023, 12, 30, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3256) },
                    { new Guid("6938ec58-b74b-4601-9850-bd5ca5ade238"), new Guid("34eacd12-4d0b-4442-a763-eda447b4ebb2"), new DateTime(2022, 2, 17, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3254) },
                    { new Guid("6e0ace1b-3bb6-45a6-9db5-987edb5eaf28"), new Guid("03e318e4-ec62-44d9-9b03-bb9d82f095bf"), new DateTime(2022, 7, 16, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3259) },
                    { new Guid("6f4786ba-e55f-4c28-9607-db156647e0d2"), new Guid("34eacd12-4d0b-4442-a763-eda447b4ebb2"), new DateTime(2022, 3, 2, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3222) },
                    { new Guid("7890ee03-4bdf-4fed-bfa3-e2004806d49c"), new Guid("03e318e4-ec62-44d9-9b03-bb9d82f095bf"), new DateTime(2022, 3, 22, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(1910) },
                    { new Guid("7de29a52-071a-453a-bd81-13ca85bd85d0"), new Guid("30c71f76-c0aa-4282-bfd9-819098097bcc"), new DateTime(2022, 3, 6, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3232) },
                    { new Guid("85f6ecc3-7ec8-4dd0-ac87-18623f941e71"), new Guid("9bdf143e-8f1c-485e-a83a-2c94fa2708a5"), new DateTime(2023, 12, 17, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3244) },
                    { new Guid("94dbe9f6-2f58-4504-a550-1174f8a03ec8"), new Guid("807a2345-2063-4125-a91f-d843ca45e5c3"), new DateTime(2022, 9, 8, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3268) },
                    { new Guid("9af63c03-35a8-47fe-a76b-8472a5b338cb"), new Guid("34eacd12-4d0b-4442-a763-eda447b4ebb2"), new DateTime(2022, 10, 30, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3262) },
                    { new Guid("a893c487-c401-4c3c-b482-bd4eaf81cfa1"), new Guid("34eacd12-4d0b-4442-a763-eda447b4ebb2"), new DateTime(2023, 1, 23, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3272) },
                    { new Guid("ad3e58d8-eadd-4a11-a246-53ac42b4822c"), new Guid("65955faa-1533-4eef-b18a-07a359fa3b16"), new DateTime(2022, 8, 13, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3241) },
                    { new Guid("b8c7ecd6-8e19-42d3-aaaf-c018011e6009"), new Guid("fccf7ff0-d1f4-4007-a8e0-32bd3d88558e"), new DateTime(2022, 12, 31, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3269) },
                    { new Guid("cc886bde-58bd-4ad7-b003-d22f17de11ff"), new Guid("6ca29f4a-970c-474d-a9ff-4714beb7be62"), new DateTime(2022, 4, 6, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3251) },
                    { new Guid("e775880f-bc3a-4ec4-8601-7813411f695e"), new Guid("34eacd12-4d0b-4442-a763-eda447b4ebb2"), new DateTime(2024, 1, 5, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3271) },
                    { new Guid("fda036d6-04da-44dc-bbfc-a765266d5374"), new Guid("03e318e4-ec62-44d9-9b03-bb9d82f095bf"), new DateTime(2024, 3, 20, 9, 50, 51, 300, DateTimeKind.Utc).AddTicks(3246) }
                });

            migrationBuilder.InsertData(
                table: "ProductsInOrders",
                columns: new[] { "Id", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0bea54c1-03c3-4ba2-be56-18f4f934cb2b"), new Guid("27c00a03-9173-43af-aca3-ff0a4475762c"), 8495m, new Guid("0c04497a-8537-4d21-a325-48d013ef9707"), 5 },
                    { new Guid("126e4bf9-f4e5-4b98-8519-2eb099c6d1ad"), new Guid("a893c487-c401-4c3c-b482-bd4eaf81cfa1"), 4796m, new Guid("2f186d0f-8524-47d6-a8d3-ab9036c55d03"), 4 },
                    { new Guid("24156cce-0591-4a02-bffd-54e9dd403c00"), new Guid("a893c487-c401-4c3c-b482-bd4eaf81cfa1"), 69599.7m, new Guid("505ec744-ad33-4b6b-a8f3-22c1db4a94c2"), 3 },
                    { new Guid("247b527f-53b9-4f18-9e53-e7a02cbfbcba"), new Guid("4b921a3e-1872-48cb-a808-654dce38e754"), 280m, new Guid("719cc4d6-3208-4525-b259-0839ff16c7ac"), 1 },
                    { new Guid("2755e0fa-ed9a-4172-8877-052cae6cab90"), new Guid("245673a2-ae8a-452e-a770-f6a6dafa845e"), 50m, new Guid("7dc25886-363c-43ff-b3ac-e6a54d461c23"), 1 },
                    { new Guid("29cdb5c0-6b20-4a9c-8482-6026fa0940cf"), new Guid("94dbe9f6-2f58-4504-a550-1174f8a03ec8"), 11599.98m, new Guid("fff57134-e573-488b-bd1c-275ce6a3033a"), 2 },
                    { new Guid("2a82ba8c-c01d-4ade-be44-a2d0f087d3a7"), new Guid("59449844-13bb-46f4-be5a-8d22a87e4428"), 3995m, new Guid("3beb3098-b45f-467f-89d4-8673c21da150"), 5 },
                    { new Guid("2de95e4f-0fa6-4065-9f34-bb67c89e681e"), new Guid("245673a2-ae8a-452e-a770-f6a6dafa845e"), 6399.98m, new Guid("27134bfe-a2af-4c3f-a838-896f98d0ba76"), 2 },
                    { new Guid("2fac7c0a-812a-448b-9cf0-24a383d44e7c"), new Guid("4b921a3e-1872-48cb-a808-654dce38e754"), 199.98m, new Guid("1effa22a-05e2-43af-8db7-9225e83903be"), 2 },
                    { new Guid("48748044-66dd-483b-8919-9d88e98382d5"), new Guid("6938ec58-b74b-4601-9850-bd5ca5ade238"), 1500m, new Guid("994f1902-0047-4086-bba3-0c1d9f1008dd"), 2 },
                    { new Guid("4a56d999-e835-44e0-8e2c-82df5d2275e8"), new Guid("463b5139-832e-4d72-b766-b03a654e85d1"), 8798m, new Guid("bba40a48-aab4-4a47-a6af-82068a1ad39b"), 2 },
                    { new Guid("4d9acfb3-9942-4ceb-82da-cd6343c4d4d5"), new Guid("94dbe9f6-2f58-4504-a550-1174f8a03ec8"), 11599.98m, new Guid("fff57134-e573-488b-bd1c-275ce6a3033a"), 2 },
                    { new Guid("620aeba9-fac0-4213-9d78-9130a520ca35"), new Guid("27c00a03-9173-43af-aca3-ff0a4475762c"), 1120m, new Guid("719cc4d6-3208-4525-b259-0839ff16c7ac"), 4 },
                    { new Guid("6bef5347-81b9-41e2-997e-617dfcb2bb0f"), new Guid("6f4786ba-e55f-4c28-9607-db156647e0d2"), 6399.98m, new Guid("27134bfe-a2af-4c3f-a838-896f98d0ba76"), 2 },
                    { new Guid("6c80ab02-0de4-495c-9692-9f0af3e84529"), new Guid("7de29a52-071a-453a-bd81-13ca85bd85d0"), 2398m, new Guid("2f186d0f-8524-47d6-a8d3-ab9036c55d03"), 2 },
                    { new Guid("76febb48-6c6e-45ef-8ddd-efb8036db1a8"), new Guid("cc886bde-58bd-4ad7-b003-d22f17de11ff"), 799m, new Guid("3beb3098-b45f-467f-89d4-8673c21da150"), 1 },
                    { new Guid("77a9287c-f36a-4420-a04c-23ae25745820"), new Guid("7de29a52-071a-453a-bd81-13ca85bd85d0"), 8495m, new Guid("0c04497a-8537-4d21-a325-48d013ef9707"), 5 },
                    { new Guid("934febdc-d391-429c-abd6-1bb1e870b43e"), new Guid("cc886bde-58bd-4ad7-b003-d22f17de11ff"), 4399m, new Guid("bba40a48-aab4-4a47-a6af-82068a1ad39b"), 1 },
                    { new Guid("9fecf21a-8fb0-4d38-9f22-76b730ae71a0"), new Guid("7de29a52-071a-453a-bd81-13ca85bd85d0"), 135061.00m, new Guid("93cd02e8-12d0-4d9e-95e2-89db8589dfed"), 2 },
                    { new Guid("a062e77b-906f-45df-8f33-98916f1ef561"), new Guid("245673a2-ae8a-452e-a770-f6a6dafa845e"), 398m, new Guid("800ffca3-414c-4bb1-bfab-e33f3c8678f8"), 2 },
                    { new Guid("a23e6e43-d0b2-4c58-b901-ff3f7df552a0"), new Guid("b8c7ecd6-8e19-42d3-aaaf-c018011e6009"), 4796m, new Guid("2f186d0f-8524-47d6-a8d3-ab9036c55d03"), 4 },
                    { new Guid("a94d931e-a62f-402b-89c8-8735f9dfc6e6"), new Guid("85f6ecc3-7ec8-4dd0-ac87-18623f941e71"), 202591.50m, new Guid("93cd02e8-12d0-4d9e-95e2-89db8589dfed"), 3 },
                    { new Guid("b90cfe7d-f7a7-4547-930c-3fbe74ff53f2"), new Guid("b8c7ecd6-8e19-42d3-aaaf-c018011e6009"), 9599.97m, new Guid("27134bfe-a2af-4c3f-a838-896f98d0ba76"), 3 },
                    { new Guid("bd83f3d3-c167-43d2-b088-2f3031047d92"), new Guid("94dbe9f6-2f58-4504-a550-1174f8a03ec8"), 103398m, new Guid("24447a08-e8fe-4dad-b3d3-78e4e5ba88d5"), 2 },
                    { new Guid("be24672d-38a1-41f7-8ef0-91da0cdeb1ba"), new Guid("85f6ecc3-7ec8-4dd0-ac87-18623f941e71"), 399.98m, new Guid("1300f356-0537-4f24-b0d9-3f84c655a4d3"), 2 },
                    { new Guid("bff72ec6-5bdc-4ca5-b56c-5adb83de21fd"), new Guid("e775880f-bc3a-4ec4-8601-7813411f695e"), 12132m, new Guid("824c826c-980c-48be-bedd-3d1aa5fc2a29"), 4 },
                    { new Guid("c6311e82-5b3b-448d-bd5a-c0aaabcdf372"), new Guid("fda036d6-04da-44dc-bbfc-a765266d5374"), 75995m, new Guid("b824cfa1-1933-49ff-a7f1-3604f8ef31c0"), 5 },
                    { new Guid("cac67cd4-69e7-4856-9797-3878e7fae113"), new Guid("a893c487-c401-4c3c-b482-bd4eaf81cfa1"), 4399m, new Guid("bba40a48-aab4-4a47-a6af-82068a1ad39b"), 1 },
                    { new Guid("e3f5e6e5-4f86-40bf-977a-5455cf079ecd"), new Guid("1b323bf9-37a5-4e54-870e-3a02da72cc8f"), 499.95m, new Guid("1effa22a-05e2-43af-8db7-9225e83903be"), 5 },
                    { new Guid("e64ea973-09b9-4543-9ac6-92ddfd35bf06"), new Guid("ad3e58d8-eadd-4a11-a246-53ac42b4822c"), 61999.96m, new Guid("63cf6371-9d33-4665-9ef8-9f69b8fceec6"), 4 },
                    { new Guid("fa5422ca-0682-4b5d-9161-9e346ef96886"), new Guid("e775880f-bc3a-4ec4-8601-7813411f695e"), 199.98m, new Guid("1effa22a-05e2-43af-8db7-9225e83903be"), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("03e318e4-ec62-44d9-9b03-bb9d82f095bf"), "user03e318e4-ec62-44d9-9b03-bb9d82f095bf" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("1680c207-3d83-41af-a3e9-2294c69d503f"), "user1680c207-3d83-41af-a3e9-2294c69d503f" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("30c71f76-c0aa-4282-bfd9-819098097bcc"), "user30c71f76-c0aa-4282-bfd9-819098097bcc" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("34eacd12-4d0b-4442-a763-eda447b4ebb2"), "user34eacd12-4d0b-4442-a763-eda447b4ebb2" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("5bb12261-d704-4afe-85bf-a41e83f074ac"), "user5bb12261-d704-4afe-85bf-a41e83f074ac" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("65955faa-1533-4eef-b18a-07a359fa3b16"), "user65955faa-1533-4eef-b18a-07a359fa3b16" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("6ca29f4a-970c-474d-a9ff-4714beb7be62"), "user6ca29f4a-970c-474d-a9ff-4714beb7be62" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("79c604bd-57d4-497a-8993-20df12e2e58e"), "user79c604bd-57d4-497a-8993-20df12e2e58e" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("807a2345-2063-4125-a91f-d843ca45e5c3"), "user807a2345-2063-4125-a91f-d843ca45e5c3" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("9bdf143e-8f1c-485e-a83a-2c94fa2708a5"), "user9bdf143e-8f1c-485e-a83a-2c94fa2708a5" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Login" },
                keyValues: new object[] { new Guid("fccf7ff0-d1f4-4007-a8e0-32bd3d88558e"), "userfccf7ff0-d1f4-4007-a8e0-32bd3d88558e" });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("263eeaaf-8f04-40c2-9eda-72b55e6dfa3a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("543785f4-9b5b-47b3-8940-839635f4357d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6e0ace1b-3bb6-45a6-9db5-987edb5eaf28"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7890ee03-4bdf-4fed-bfa3-e2004806d49c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9af63c03-35a8-47fe-a76b-8472a5b338cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("772811cd-e96c-41cf-94f4-2406dd7b07ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d9df395-5669-459d-9d0b-2a9ec2972671"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f868a2a-03f3-4e2a-91fc-2ec82e737a84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("deea5cbd-7ac6-45f3-9724-cc95c5b234ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eecd98da-450e-4890-be4c-433a94513557"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("0bea54c1-03c3-4ba2-be56-18f4f934cb2b"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("126e4bf9-f4e5-4b98-8519-2eb099c6d1ad"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("24156cce-0591-4a02-bffd-54e9dd403c00"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("247b527f-53b9-4f18-9e53-e7a02cbfbcba"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("2755e0fa-ed9a-4172-8877-052cae6cab90"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("29cdb5c0-6b20-4a9c-8482-6026fa0940cf"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("2a82ba8c-c01d-4ade-be44-a2d0f087d3a7"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("2de95e4f-0fa6-4065-9f34-bb67c89e681e"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("2fac7c0a-812a-448b-9cf0-24a383d44e7c"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("48748044-66dd-483b-8919-9d88e98382d5"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("4a56d999-e835-44e0-8e2c-82df5d2275e8"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("4d9acfb3-9942-4ceb-82da-cd6343c4d4d5"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("620aeba9-fac0-4213-9d78-9130a520ca35"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6bef5347-81b9-41e2-997e-617dfcb2bb0f"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("6c80ab02-0de4-495c-9692-9f0af3e84529"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("76febb48-6c6e-45ef-8ddd-efb8036db1a8"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("77a9287c-f36a-4420-a04c-23ae25745820"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("934febdc-d391-429c-abd6-1bb1e870b43e"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("9fecf21a-8fb0-4d38-9f22-76b730ae71a0"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("a062e77b-906f-45df-8f33-98916f1ef561"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("a23e6e43-d0b2-4c58-b901-ff3f7df552a0"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("a94d931e-a62f-402b-89c8-8735f9dfc6e6"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("b90cfe7d-f7a7-4547-930c-3fbe74ff53f2"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("bd83f3d3-c167-43d2-b088-2f3031047d92"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("be24672d-38a1-41f7-8ef0-91da0cdeb1ba"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("bff72ec6-5bdc-4ca5-b56c-5adb83de21fd"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("c6311e82-5b3b-448d-bd5a-c0aaabcdf372"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("cac67cd4-69e7-4856-9797-3878e7fae113"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("e3f5e6e5-4f86-40bf-977a-5455cf079ecd"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("e64ea973-09b9-4543-9ac6-92ddfd35bf06"));

            migrationBuilder.DeleteData(
                table: "ProductsInOrders",
                keyColumn: "Id",
                keyValue: new Guid("fa5422ca-0682-4b5d-9161-9e346ef96886"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5bb12261-d704-4afe-85bf-a41e83f074ac"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1b323bf9-37a5-4e54-870e-3a02da72cc8f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("245673a2-ae8a-452e-a770-f6a6dafa845e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("27c00a03-9173-43af-aca3-ff0a4475762c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("463b5139-832e-4d72-b766-b03a654e85d1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4b921a3e-1872-48cb-a808-654dce38e754"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("59449844-13bb-46f4-be5a-8d22a87e4428"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6938ec58-b74b-4601-9850-bd5ca5ade238"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6f4786ba-e55f-4c28-9607-db156647e0d2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7de29a52-071a-453a-bd81-13ca85bd85d0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("85f6ecc3-7ec8-4dd0-ac87-18623f941e71"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("94dbe9f6-2f58-4504-a550-1174f8a03ec8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a893c487-c401-4c3c-b482-bd4eaf81cfa1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ad3e58d8-eadd-4a11-a246-53ac42b4822c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b8c7ecd6-8e19-42d3-aaaf-c018011e6009"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cc886bde-58bd-4ad7-b003-d22f17de11ff"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e775880f-bc3a-4ec4-8601-7813411f695e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fda036d6-04da-44dc-bbfc-a765266d5374"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c04497a-8537-4d21-a325-48d013ef9707"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1300f356-0537-4f24-b0d9-3f84c655a4d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1effa22a-05e2-43af-8db7-9225e83903be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24447a08-e8fe-4dad-b3d3-78e4e5ba88d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27134bfe-a2af-4c3f-a838-896f98d0ba76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f186d0f-8524-47d6-a8d3-ab9036c55d03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3beb3098-b45f-467f-89d4-8673c21da150"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("505ec744-ad33-4b6b-a8f3-22c1db4a94c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63cf6371-9d33-4665-9ef8-9f69b8fceec6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("719cc4d6-3208-4525-b259-0839ff16c7ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dc25886-363c-43ff-b3ac-e6a54d461c23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("800ffca3-414c-4bb1-bfab-e33f3c8678f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("824c826c-980c-48be-bedd-3d1aa5fc2a29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93cd02e8-12d0-4d9e-95e2-89db8589dfed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("994f1902-0047-4086-bba3-0c1d9f1008dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b824cfa1-1933-49ff-a7f1-3604f8ef31c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bba40a48-aab4-4a47-a6af-82068a1ad39b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fff57134-e573-488b-bd1c-275ce6a3033a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("03e318e4-ec62-44d9-9b03-bb9d82f095bf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1680c207-3d83-41af-a3e9-2294c69d503f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("30c71f76-c0aa-4282-bfd9-819098097bcc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("34eacd12-4d0b-4442-a763-eda447b4ebb2"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("65955faa-1533-4eef-b18a-07a359fa3b16"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6ca29f4a-970c-474d-a9ff-4714beb7be62"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("79c604bd-57d4-497a-8993-20df12e2e58e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("807a2345-2063-4125-a91f-d843ca45e5c3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9bdf143e-8f1c-485e-a83a-2c94fa2708a5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("fccf7ff0-d1f4-4007-a8e0-32bd3d88558e"));

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "ClientCredentials",
                newName: "Username");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 6, 0, 19, 12, 643, DateTimeKind.Utc).AddTicks(8769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 6, 9, 50, 52, 2, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Clients",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FullName", "Phone" },
                values: new object[,]
                {
                    { new Guid("0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4"), "Дорофеева Георгина Онисимовна", "89506330270" },
                    { new Guid("2b44f8cf-6848-4bef-8e19-86cbf68a4b38"), "Фёдорова Асида Федоровна", "89506225278" },
                    { new Guid("37e6a4d8-201e-4c0c-be4b-e6a9ea150661"), "Воронцов Любомир Антонович", "89906225025" },
                    { new Guid("39540cc0-884e-4ed3-927d-4bbd3c60bf8c"), "Меркушев Бенедикт Алексеевич", "89996225028" },
                    { new Guid("6f1867f7-3613-4946-bd30-b391eba544e3"), "Баранова Марьяна Рудольфовна", "89506224428" },
                    { new Guid("a6722490-3731-4c32-994f-d9cdc6177956"), "Беляков Демьян Степанович", "89606225028" },
                    { new Guid("acfef8fa-8c16-49b5-9c28-f71cd5e08027"), "Ларионов Аввакуум Христофорович", "89506335028" },
                    { new Guid("be64dfa7-50dc-4c15-83f1-b5136c304604"), "Савин Август Оскарович", "89506225026" },
                    { new Guid("bf12d20f-fbc2-4e79-907c-9b2b26e76627"), "Лазарева Лигия Пётровна", "89506225268" },
                    { new Guid("cae2788e-e9cd-4777-beb3-f4f8305cb23b"), "Ефимов Аким Лаврентьевич", "89506225027" },
                    { new Guid("d732f3b3-ceb9-48ac-8012-0a71d5ca1a11"), "Зайцева Римма Аристарховна", "89503335028" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductTypeRefId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("04a68ff5-11cb-40f2-a255-023313b4d9f3"), "Набор инструментов Дело Техники 600937", 3033m, 2, 30 },
                    { new Guid("1eee1463-5589-4924-89a7-138787dec704"), "Чистящее средство для нагревательных элементов электроплит/газовых плит Topper IR 5", 50m, 3, 0 },
                    { new Guid("3c9d1390-0d3b-4c8e-bbe9-1d7f19916a89"), "Адаптер для скрытого подключения видеорегистратора Roadgid Cord DC", 1199m, 1, 10 },
                    { new Guid("429445da-7f29-4724-bbef-ec93c7981425"), "LET Prestigio PTV50SS08X", 23199.9m, 0, 7 },
                    { new Guid("4af69082-2e63-49de-b18c-960c215a18fd"), "Паяльная станция Rexant 12-0714", 4399m, 2, 2 },
                    { new Guid("5e92f4c8-25aa-4a49-b244-c6ee417df4b4"), "Набор для ухода для стеклокерамических поверхностей Fiora bio ЭКО 20-002", 199m, 3, 5 },
                    { new Guid("79846436-38d6-4255-9b41-061a1322374b"), "AMD Ryzen 7 4700G OEM", 15499.99m, 0, 20 },
                    { new Guid("8c9369d1-3fc5-47d6-9954-69638aeb3c34"), "ТВ розетка одинарная Schneider Electric Glossa GSL000391", 199.99m, 3, 20 },
                    { new Guid("97db5d13-ec20-4bfd-b035-bc57e1319bc4"), "Набор инструментов КВТ Профи НИИ-09", 1699m, 2, 10 },
                    { new Guid("9960d886-ebb9-4c0b-b4c0-13d15d3d197e"), "Швабра Master House Джайв", 199.99m, 3, 21 },
                    { new Guid("ad58b674-4a47-4d34-9b67-7b4e45849f94"), "Отвертка с набором насадок Matrix 11598", 110m, 2, 25 },
                    { new Guid("bf04feb2-590d-4297-ac38-067516e17a3d"), "LED Harper 43F660Y", 15199m, 0, 6 },
                    { new Guid("ce9cf65f-e543-4806-9ddf-8eee7a1d5431"), "Инвертор DEXP CAR 150W", 750m, 1, 0 },
                    { new Guid("d73f1127-11f0-4bb0-a70c-2371cd1e6c41"), "Инструмент для вскрытия техники Rexant 12-4335", 99.99m, 2, 20 },
                    { new Guid("d8f88e30-0624-4311-9f4a-4c74822fe4ea"), "Швабра Master House Бачата", 199.99m, 3, 33 },
                    { new Guid("dec3c83d-d254-432e-a820-201dde19af14"), "IPhone 8s", 67530.50m, 0, 12 },
                    { new Guid("e19d3272-c4ec-422a-8eea-bccb4854dbc6"), "Видеорегистратор 70mai Dash Cam M300", 3199.99m, 1, 5 },
                    { new Guid("e3c88564-f375-472e-a639-b66a1382fff7"), "ASUS VivoBook 16X M1603QA", 51699m, 0, 11 },
                    { new Guid("ea105f07-4c1d-408b-8d20-ed46c81f7989"), "Газонокосилка-робот Champion RMB1828", 49499.99m, 3, 8 },
                    { new Guid("eafdac08-8890-4b5c-a1f7-a786151694d9"), "Набор инструментов Swiss Tools ST-1077", 5799.99m, 2, 20 },
                    { new Guid("ebfe59da-773c-421f-8818-beb494b6663d"), "Набор инструментов Квалитет 5027038", 5699.9m, 2, 9 },
                    { new Guid("f1fcd5bc-8928-409f-add6-c26ec85f497c"), "Камера заднего вида Silverstone F1 Interpower IP-662 LED", 799m, 1, 6 },
                    { new Guid("f576f1cd-9e46-4c62-945e-6ef8a11e14df"), "Очиститель для тканей и мебели ОС-Гель", 280m, 3, 15 }
                });

            migrationBuilder.InsertData(
                table: "ClientCredentials",
                columns: new[] { "ClientId", "Username", "Password" },
                values: new object[,]
                {
                    { new Guid("0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4"), "user0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4", "qwe12345" },
                    { new Guid("2b44f8cf-6848-4bef-8e19-86cbf68a4b38"), "user2b44f8cf-6848-4bef-8e19-86cbf68a4b38", "qwe12345" },
                    { new Guid("37e6a4d8-201e-4c0c-be4b-e6a9ea150661"), "user37e6a4d8-201e-4c0c-be4b-e6a9ea150661", "qwe12345" },
                    { new Guid("39540cc0-884e-4ed3-927d-4bbd3c60bf8c"), "user39540cc0-884e-4ed3-927d-4bbd3c60bf8c", "qwe12345" },
                    { new Guid("6f1867f7-3613-4946-bd30-b391eba544e3"), "user6f1867f7-3613-4946-bd30-b391eba544e3", "qwe12345" },
                    { new Guid("a6722490-3731-4c32-994f-d9cdc6177956"), "usera6722490-3731-4c32-994f-d9cdc6177956", "qwe12345" },
                    { new Guid("acfef8fa-8c16-49b5-9c28-f71cd5e08027"), "useracfef8fa-8c16-49b5-9c28-f71cd5e08027", "qwe12345" },
                    { new Guid("be64dfa7-50dc-4c15-83f1-b5136c304604"), "userbe64dfa7-50dc-4c15-83f1-b5136c304604", "qwe12345" },
                    { new Guid("bf12d20f-fbc2-4e79-907c-9b2b26e76627"), "userbf12d20f-fbc2-4e79-907c-9b2b26e76627", "qwe12345" },
                    { new Guid("cae2788e-e9cd-4777-beb3-f4f8305cb23b"), "usercae2788e-e9cd-4777-beb3-f4f8305cb23b", "qwe12345" },
                    { new Guid("d732f3b3-ceb9-48ac-8012-0a71d5ca1a11"), "userd732f3b3-ceb9-48ac-8012-0a71d5ca1a11", "qwe12345" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "CreatedAt" },
                values: new object[,]
                {
                    { new Guid("00cf9b92-6512-4ace-8346-4177972473c3"), new Guid("6f1867f7-3613-4946-bd30-b391eba544e3"), new DateTime(2022, 10, 24, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1892) },
                    { new Guid("11f53c0d-cb9d-4fa1-be1b-6f2b9dd7c3b5"), new Guid("a6722490-3731-4c32-994f-d9cdc6177956"), new DateTime(2022, 8, 15, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1914) },
                    { new Guid("1d832cd8-76d9-4aa5-b61f-90b1bcd1a197"), new Guid("be64dfa7-50dc-4c15-83f1-b5136c304604"), new DateTime(2023, 1, 18, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1910) },
                    { new Guid("2211d318-12d3-49bc-9094-c909404cbd39"), new Guid("bf12d20f-fbc2-4e79-907c-9b2b26e76627"), new DateTime(2022, 4, 9, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1900) },
                    { new Guid("32a55c00-475e-418a-89e3-6a396fe6e9fb"), new Guid("39540cc0-884e-4ed3-927d-4bbd3c60bf8c"), new DateTime(2022, 10, 8, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1878) },
                    { new Guid("3609fba9-c39b-4ba2-b551-d9dbe84be705"), new Guid("acfef8fa-8c16-49b5-9c28-f71cd5e08027"), new DateTime(2024, 3, 6, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1885) },
                    { new Guid("50a10916-8493-4cd1-b7f0-3c233cb6d1ef"), new Guid("2b44f8cf-6848-4bef-8e19-86cbf68a4b38"), new DateTime(2023, 11, 12, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1876) },
                    { new Guid("6f77ae1e-e91f-404d-95f9-901d843d2522"), new Guid("cae2788e-e9cd-4777-beb3-f4f8305cb23b"), new DateTime(2023, 7, 7, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1908) },
                    { new Guid("751b9c14-166c-4403-84db-a78452a2c254"), new Guid("cae2788e-e9cd-4777-beb3-f4f8305cb23b"), new DateTime(2023, 11, 13, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1913) },
                    { new Guid("7dbe25c9-ff88-42ac-bfbf-39da813b1bd0"), new Guid("2b44f8cf-6848-4bef-8e19-86cbf68a4b38"), new DateTime(2023, 12, 12, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1920) },
                    { new Guid("7ece1041-5bff-4bbd-ab90-e617bf5ab90e"), new Guid("2b44f8cf-6848-4bef-8e19-86cbf68a4b38"), new DateTime(2024, 2, 9, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1889) },
                    { new Guid("956173c5-83ae-4226-bf0f-f2ab520d36f5"), new Guid("2b44f8cf-6848-4bef-8e19-86cbf68a4b38"), new DateTime(2022, 7, 5, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1904) },
                    { new Guid("ab1befaf-93bd-4fe0-af35-59525ee78e29"), new Guid("cae2788e-e9cd-4777-beb3-f4f8305cb23b"), new DateTime(2022, 10, 31, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1867) },
                    { new Guid("b0efa5a1-097e-4240-8584-1f331028f2c3"), new Guid("bf12d20f-fbc2-4e79-907c-9b2b26e76627"), new DateTime(2022, 6, 22, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1907) },
                    { new Guid("b4ba6039-9833-4a76-8904-fac727da750e"), new Guid("be64dfa7-50dc-4c15-83f1-b5136c304604"), new DateTime(2024, 3, 17, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1896) },
                    { new Guid("bb200105-1331-4a4b-bb49-0a216a7b59f7"), new Guid("be64dfa7-50dc-4c15-83f1-b5136c304604"), new DateTime(2022, 4, 23, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1898) },
                    { new Guid("ccb914e4-8f55-4693-8c09-e54afd119f82"), new Guid("0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4"), new DateTime(2022, 3, 6, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1894) },
                    { new Guid("ccd8b5cb-9fca-4eff-8d88-39f7aa3459f9"), new Guid("0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4"), new DateTime(2022, 6, 18, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(509) },
                    { new Guid("dd7c5359-7809-4188-8764-c2ae74bf6cac"), new Guid("0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4"), new DateTime(2023, 6, 20, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1905) },
                    { new Guid("df37f39f-1995-492e-ab64-aac4e037e452"), new Guid("d732f3b3-ceb9-48ac-8012-0a71d5ca1a11"), new DateTime(2022, 9, 9, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1919) },
                    { new Guid("e7c0aaa8-c127-4e35-a5a7-0bf993c908d6"), new Guid("bf12d20f-fbc2-4e79-907c-9b2b26e76627"), new DateTime(2024, 3, 23, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1891) },
                    { new Guid("efb4511f-bd7f-4e0a-a814-323d034735d5"), new Guid("0ff86f3c-4aa9-44fa-b4d3-b66be877a2d4"), new DateTime(2024, 2, 15, 0, 19, 11, 269, DateTimeKind.Utc).AddTicks(1916) }
                });

            migrationBuilder.InsertData(
                table: "ProductsInOrders",
                columns: new[] { "Id", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("09b8b235-dfdf-4834-a9b5-a212d11bc85d"), new Guid("50a10916-8493-4cd1-b7f0-3c233cb6d1ef"), 399.98m, new Guid("d8f88e30-0624-4311-9f4a-4c74822fe4ea"), 2 },
                    { new Guid("10f35968-ff2a-4614-aced-88b8b77c8fe7"), new Guid("7dbe25c9-ff88-42ac-bfbf-39da813b1bd0"), 398m, new Guid("5e92f4c8-25aa-4a49-b244-c6ee417df4b4"), 2 },
                    { new Guid("14ac4002-2404-4f19-adf7-f97f1f49cd71"), new Guid("dd7c5359-7809-4188-8764-c2ae74bf6cac"), 4399m, new Guid("4af69082-2e63-49de-b18c-960c215a18fd"), 1 },
                    { new Guid("1c2d9a60-0425-4b14-b21f-073c5fa93675"), new Guid("32a55c00-475e-418a-89e3-6a396fe6e9fb"), 258495m, new Guid("e3c88564-f375-472e-a639-b66a1382fff7"), 5 },
                    { new Guid("21f8d556-e96c-4d97-b38f-ae01ddc25c70"), new Guid("751b9c14-166c-4403-84db-a78452a2c254"), 8798m, new Guid("4af69082-2e63-49de-b18c-960c215a18fd"), 2 },
                    { new Guid("23f4d547-9ba7-4d59-b432-5ba07c0ac735"), new Guid("7dbe25c9-ff88-42ac-bfbf-39da813b1bd0"), 6066m, new Guid("04a68ff5-11cb-40f2-a255-023313b4d9f3"), 2 },
                    { new Guid("303bfb76-f04b-4ee5-8ce4-46d5a78d6d2b"), new Guid("efb4511f-bd7f-4e0a-a814-323d034735d5"), 999.95m, new Guid("8c9369d1-3fc5-47d6-9954-69638aeb3c34"), 5 },
                    { new Guid("48608476-9b2b-4c64-9535-ef3d096bb864"), new Guid("ab1befaf-93bd-4fe0-af35-59525ee78e29"), 155097m, new Guid("e3c88564-f375-472e-a639-b66a1382fff7"), 3 },
                    { new Guid("602f32d7-faaf-4c53-95fd-2c7f2668018a"), new Guid("ccd8b5cb-9fca-4eff-8d88-39f7aa3459f9"), 799m, new Guid("f1fcd5bc-8928-409f-add6-c26ec85f497c"), 1 },
                    { new Guid("6579e59e-0f7a-47dd-b4b7-53edae366db3"), new Guid("bb200105-1331-4a4b-bb49-0a216a7b59f7"), 750m, new Guid("ce9cf65f-e543-4806-9ddf-8eee7a1d5431"), 1 },
                    { new Guid("6c4581ff-bc86-40e2-9ac7-80ed499606da"), new Guid("2211d318-12d3-49bc-9094-c909404cbd39"), 280m, new Guid("f576f1cd-9e46-4c62-945e-6ef8a11e14df"), 1 },
                    { new Guid("6d373a94-4d35-43d6-9226-66e61f341b76"), new Guid("3609fba9-c39b-4ba2-b551-d9dbe84be705"), 11399.8m, new Guid("ebfe59da-773c-421f-8818-beb494b6663d"), 2 },
                    { new Guid("6ddc433d-25cf-49f4-862b-4e3c35921176"), new Guid("50a10916-8493-4cd1-b7f0-3c233cb6d1ef"), 45597m, new Guid("bf04feb2-590d-4297-ac38-067516e17a3d"), 3 },
                    { new Guid("91a02821-80af-48da-a04a-b231da2bc667"), new Guid("efb4511f-bd7f-4e0a-a814-323d034735d5"), 560m, new Guid("f576f1cd-9e46-4c62-945e-6ef8a11e14df"), 2 },
                    { new Guid("aa6fc293-01ec-4dba-8bb2-aea4b2448fc2"), new Guid("ccd8b5cb-9fca-4eff-8d88-39f7aa3459f9"), 3398m, new Guid("97db5d13-ec20-4bfd-b035-bc57e1319bc4"), 2 },
                    { new Guid("ac4874c9-c98c-4684-9612-741c572158f3"), new Guid("bb200105-1331-4a4b-bb49-0a216a7b59f7"), 199.98m, new Guid("d73f1127-11f0-4bb0-a70c-2371cd1e6c41"), 2 },
                    { new Guid("b0559478-0c0b-4b05-9ba1-b32379912143"), new Guid("efb4511f-bd7f-4e0a-a814-323d034735d5"), 49499.99m, new Guid("ea105f07-4c1d-408b-8d20-ed46c81f7989"), 1 },
                    { new Guid("c739debb-a485-4f01-b583-2cff2f3f70c8"), new Guid("32a55c00-475e-418a-89e3-6a396fe6e9fb"), 597m, new Guid("5e92f4c8-25aa-4a49-b244-c6ee417df4b4"), 3 },
                    { new Guid("d358401d-b57f-448c-ab22-a50fc4cda82a"), new Guid("b0efa5a1-097e-4240-8584-1f331028f2c3"), 796m, new Guid("5e92f4c8-25aa-4a49-b244-c6ee417df4b4"), 4 },
                    { new Guid("f6a762eb-4e19-4f72-a686-2d995d27ea85"), new Guid("7dbe25c9-ff88-42ac-bfbf-39da813b1bd0"), 399.98m, new Guid("8c9369d1-3fc5-47d6-9954-69638aeb3c34"), 2 }
                });
        }
    }
}
