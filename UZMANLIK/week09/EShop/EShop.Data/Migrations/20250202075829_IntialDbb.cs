using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class IntialDbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2fe392f-4f60-4963-ba3a-ea52b71fb53e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5367e9ae-400f-4c71-bef9-19c8dd4c1da7", "AQAAAAIAAYagAAAAEA+CGOWL8n4+F+OP/SzMDxZ96uxWehywFO5h1uLrmJMVev1GsuXoO2npOrlkgBQZCw==", "c18c9f0b-aead-4c26-ad7e-21efadcc4b1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4757375-a497-496b-85dc-a510027bd9b1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5bece75-3f35-4d01-8a18-7dc5fa351536", "AQAAAAIAAYagAAAAEAUtt3dIRD4t/uD8ga6DEfQ4gVItJB9QIzj3L9znaoTshzU4v6qAT+fvoSNM5gX4oQ==", "c00ec6cb-cf7b-4183-bb60-0c76df217de8" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 520, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 520, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 58, 28, 402, DateTimeKind.Utc).AddTicks(1068));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2fe392f-4f60-4963-ba3a-ea52b71fb53e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23387f9c-3f10-4326-9eb4-d570d0219bd8", "AQAAAAIAAYagAAAAEKkMCDPmQp9AfDmgWiQiWuLJX7VQc5hp06RHrDVuR1d+vKhxCSMVWIpgRtyw0XfdKg==", "7f97e749-bcfa-4222-a82b-1747cd5951f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4757375-a497-496b-85dc-a510027bd9b1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dddc3a51-2d1a-4969-9fb4-6dcfc6ae5b66", "AQAAAAIAAYagAAAAEOJsSWGXFm+gh8hWSkGrWqb6OpPZ//QGZjzRcITi3iqNrx0G6n2mc1oBFghM5posEw==", "3ebd223b-0031-458d-8dab-3699aba816c8" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 971, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 971, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 53, 42, 507, DateTimeKind.Utc).AddTicks(5218));
        }
    }
}
