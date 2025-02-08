using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class IntialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Properties",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Properties",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2fe392f-4f60-4963-ba3a-ea52b71fb53e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3773d10-276d-4931-ac8d-c9b44ca901ba", "AQAAAAIAAYagAAAAEFulJPm+BAKd/JRaX29M4l3loZKTZDFVzIqUuLdmQOeIjcwVCKxJJ7ydYdntIzfiIQ==", "5f80f344-7f50-4628-a352-578eba552a3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4757375-a497-496b-85dc-a510027bd9b1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "667bd2b9-5f0f-4daf-b86a-f28e31b0b51b", "AQAAAAIAAYagAAAAEPYE1bLFX3VSoDxQP9C2m6DuGFajEzTSdiixNLIx2v6jRxECxN1EpSIs2+2xkA+XXQ==", "900ce216-0c87-4939-a481-8543ef9a0e40" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 28, 100, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 28, 100, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 1, 5, 9, 10, 27, 953, DateTimeKind.Utc).AddTicks(5663));
        }
    }
}
