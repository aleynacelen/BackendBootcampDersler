using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class IntialDbbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2fe392f-4f60-4963-ba3a-ea52b71fb53e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6790abe7-d6e3-4f41-bc8e-4d3667f8d0d2", "AQAAAAIAAYagAAAAEFWljZDFuE18haYVA5SSNd68TjvMtLuReXTqC/oWJ5LGpg0FMKOnuxNTLXJZw5Qyrg==", "a07fea46-ca39-4b91-aa98-f0703cd35095" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4757375-a497-496b-85dc-a510027bd9b1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49c60578-9346-40fc-8a84-1864f08b8c9b", "AQAAAAIAAYagAAAAEOnMaTAjKnGqMdP11lj/cFAsgs+vvZgeGbkpyF8ZFRZxXX8R2R2iDRP0DfpeoKgQCQ==", "a208408c-3508-41a5-a9dc-27102db73af9" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 239, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 239, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 43, 49, 126, DateTimeKind.Utc).AddTicks(4226));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2fe392f-4f60-4963-ba3a-ea52b71fb53e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f02e72d-490e-4e4e-b1b6-101e5d490d47", "AQAAAAIAAYagAAAAEMy1AgTQvpZl8uFQ5nTpm/QOlVwwiBtd0EM233I9btBg5OL21h4ognuKu+VFtIBKoA==", "899093da-a475-4d85-9aa3-20c59b5fc8a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4757375-a497-496b-85dc-a510027bd9b1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81c21c34-9ccf-460e-9ed2-5d90af948720", "AQAAAAIAAYagAAAAENm81w/aVmUtD/VET2p0sA3JnXDlD37G6Un0tSuGQ8Bb9/RKwzqBwBtNOwL1XueuJA==", "6def098d-ebd0-41aa-a986-352341e85a5a" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 467, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 467, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5787));
        }
    }
}
