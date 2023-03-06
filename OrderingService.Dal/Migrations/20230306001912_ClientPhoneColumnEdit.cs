using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderingService.Dal.Migrations
{
    /// <inheritdoc />
    public partial class ClientPhoneColumnEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("34fa4285-beb7-4e52-bcf4-bcd99e2d5b94"), "user34fa4285-beb7-4e52-bcf4-bcd99e2d5b94" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("4a57edba-bfaa-4388-860b-7e6e1ed4ba83"), "user4a57edba-bfaa-4388-860b-7e6e1ed4ba83" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("5721c29f-1f2e-4d02-83ff-9a3f57a817e6"), "user5721c29f-1f2e-4d02-83ff-9a3f57a817e6" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("60a287dd-fea3-43fa-9d73-eaaab0e96ab8"), "user60a287dd-fea3-43fa-9d73-eaaab0e96ab8" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("851e8bb2-9498-4852-b702-242d3cef6654"), "user851e8bb2-9498-4852-b702-242d3cef6654" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("87184d4b-bc15-43cc-9dd3-f61da3a35095"), "user87184d4b-bc15-43cc-9dd3-f61da3a35095" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("8f1fe072-c8cb-4a54-8001-056c0d6ba55f"), "user8f1fe072-c8cb-4a54-8001-056c0d6ba55f" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("af93ed71-fb44-48fc-b9c8-2d018702bcc5"), "useraf93ed71-fb44-48fc-b9c8-2d018702bcc5" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("b2cfbca6-48d2-4d2c-89bb-4c609b71deab"), "userb2cfbca6-48d2-4d2c-89bb-4c609b71deab" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("c6697675-09ab-40d0-b853-f8831a989e77"), "userc6697675-09ab-40d0-b853-f8831a989e77" });

            migrationBuilder.DeleteData(
                table: "ClientCredentials",
                keyColumns: new[] { "ClientId", "Username" },
                keyValues: new object[] { new Guid("d7e0d0ca-ded9-4297-806f-c0a1739cf2a3"), "userd7e0d0ca-ded9-4297-806f-c0a1739cf2a3" });

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
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("af93ed71-fb44-48fc-b9c8-2d018702bcc5"));

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
                defaultValue: new DateTime(2023, 3, 6, 0, 19, 12, 643, DateTimeKind.Utc).AddTicks(8769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 5, 21, 47, 6, 509, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Clients",
                type: "nvarchar(450)",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 5, 21, 47, 6, 509, DateTimeKind.Utc).AddTicks(208),
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
    }
}
