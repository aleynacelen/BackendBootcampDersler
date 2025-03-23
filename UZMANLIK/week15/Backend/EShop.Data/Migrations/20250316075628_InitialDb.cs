using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApiKey = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUsedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiClients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsMenuItem = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHome = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0517f36e-53b1-4a0d-b6b3-599afdd926cf", null, "Yönetici rolü", "Admin", "ADMIN" },
                    { "c44cd475-5365-409f-845c-6ea238190b2b", null, "Normal kullanıcı rolü", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", 0, "Kadıköy", "İstanbul", "c8e130f3-fd1d-4fa3-9d00-e8ca6efea3d7", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "testuser@gmail.com", true, "Esin", 2, "Çelik", false, null, "TESTUSER@GMAIL.COM", "TESTUSER", "AQAAAAIAAYagAAAAENfrGYdT5Lr2Nc3uanUYgQsb5Poe9BeXEbdgSjin2CcxxZpDLaCc8SPK/0LE4y+h+g==", null, false, "8674e9b9-f300-43ac-9a2d-113b7d4d90c5", false, "testuser" },
                    { "d4757375-a497-496b-85dc-a510027bd9b1", 0, "Ataşehir", "İstanbul", "cd110c1e-79e1-4c3e-8cc1-be3117b8d0d6", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "testadmin@gmail.com", true, "Ali", 3, "Cabbar", false, null, "TESTADMIN@GMAIL.COM", "TESTADMIN", "AQAAAAIAAYagAAAAEOrrUnDVH/1UnWZkbn9GY+xvMMb4R0/73Fp4zO/bWHUnSzKK4FwQdGa+yZeKmJatXw==", null, false, "32475d20-8131-4392-aab3-d47ba2022af9", false, "testadmin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "ImageUrl", "IsActive", "IsDeleted", "IsMenuItem", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7705), new TimeSpan(0, 0, 0, 0, 0)), "Bilgisayarlar, akıllı telefonlar, tabletler, televizyonlar ve diğer tüm elektronik cihazlar bu kategoride bulunabilir. Teknoloji tutkunları için en yeni ve popüler ürünler burada!", "/images/categories/elektronik.png", true, false, true, "Elektronik", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), "Kadın, erkek ve çocuk giyim ürünleri, ayakkabılar, çantalar ve aksesuarlar bu kategoride. Trendleri yakalayın ve tarzınızı yansıtın!", "/images/categories/moda.png", true, false, true, "Moda", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7709), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7712), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7714), new TimeSpan(0, 0, 0, 0, 0)), "Ev dekorasyonu, mobilyalar, mutfak gereçleri, bahçe ürünleri ve daha fazlası bu kategoride. Evinizi güzelleştirmek için ihtiyacınız olan her şey burada!", "/images/categories/ev-yasam.png", true, false, true, "Ev & Yaşam", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7713), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7717), new TimeSpan(0, 0, 0, 0, 0)), "Spor ekipmanları, outdoor giyim, kamp malzemeleri, bisikletler ve fitness ürünleri bu kategoride. Aktif bir yaşam için ihtiyacınız olan her şey burada!", "/images/categories/spor-outdoor.png", true, false, true, "Spor & Outdoor", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7716), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7718), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7719), new TimeSpan(0, 0, 0, 0, 0)), "Romanlar, kişisel gelişim kitapları, akademik yayınlar, dergiler ve daha fazlası bu kategoride. Okuma tutkunları için geniş bir seçki!", "/images/categories/kitap-dergi.png", true, false, true, "Kitap & Dergi", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7719), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7721), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7723), new TimeSpan(0, 0, 0, 0, 0)), "Çocuk oyuncakları, yapbozlar, model kitler, hobi malzemeleri ve koleksiyon ürünleri bu kategoride. Hem çocuklar hem de yetişkinler için eğlenceli seçenekler!", "/images/categories/oyuncak-hobi.png", true, false, false, "Oyuncak & Hobi", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7722), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7725), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7727), new TimeSpan(0, 0, 0, 0, 0)), "Cilt bakım ürünleri, makyaj malzemeleri, parfümler, saç bakım ürünleri ve daha fazlası bu kategoride. Kendinizi şımartın ve bakım rutininizi oluşturun!", "/images/categories/kozmetik-bakim.png", true, false, false, "Kozmetik & Kişisel Bakım", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7726), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7728), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), "Valizler, sırt çantaları, seyahat aksesuarları ve seyahat planlaması için gerekli ürünler bu kategoride. Yeni yerler keşfetmeye hazır olun!", "/images/categories/seyahat-valiz.png", false, false, false, "Seyahat & Valiz", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7731), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7733), new TimeSpan(0, 0, 0, 0, 0)), "Bebek giysileri, bebek bakım ürünleri, oyuncaklar, çocuk odası dekorasyonu ve daha fazlası bu kategoride. Bebekler ve çocuklar için en kaliteli ürünler!", "/images/categories/bebek-cocuk.png", true, false, false, "Bebek & Çocuk", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7732), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7734), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7736), new TimeSpan(0, 0, 0, 0, 0)), "Araç bakım ürünleri, yedek parçalar, araç içi aksesuarlar ve otomotiv ekipmanları bu kategoride. Araç tutkunları için ihtiyaç duyulan her şey!", "/images/categories/otomotiv.png", false, false, false, "Otomotiv", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(7735), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "Name", "Price", "Properties", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8631), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8634), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/laptop.png", true, false, false, "Dizüstü Bilgisayar", 1500.00m, "16GB RAM, 512GB SSD, Intel i7 İşlemci", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8634), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8636), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8637), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/smartphone.png", true, false, false, "Akıllı Telefon", 800.00m, "128GB Depolama, 6GB RAM, 5G Desteği", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8637), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8640), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8641), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/tablet.png", true, false, false, "Tablet", 600.00m, "10.5 inç Ekran, 256GB Depolama, Kalem Desteği", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8641), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8642), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/smartwatch.png", true, false, false, "Akıllı Saat", 250.00m, "GPS, Kalp Atışı Ölçer, Suya Dayanıklı", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8643), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8646), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/earbuds.png", false, false, false, "Kablosuz Kulaklık", 150.00m, "Gürültü Önleyici, 20 Saat Pil Ömrü", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8646), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8648), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8649), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/men-jacket.png", true, false, false, "Erkek Ceket", 120.00m, "Slim Fit, Kumaş Ceket", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8649), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8650), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/women-dress.png", true, false, false, "Kadın Elbise", 80.00m, "Yazlık Desenli, Pamuklu", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8651), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8653), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8654), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/sneakers.png", true, false, false, "Spor Ayakkabı", 90.00m, "Hafif, Nefes Alabilir Taban", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8654), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8656), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8657), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/bag.png", true, false, false, "Çanta", 70.00m, "Deri, Günlük Kullanım", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8657), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8658), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8660), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/sunglasses.png", false, false, false, "Güneş Gözlüğü", 50.00m, "UV Koruma, Polarize Cam", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8659), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8661), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/dinner-set.png", true, false, false, "Yemek Takımı", 100.00m, "12 Parça, Porselen", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8662), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8664), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/sofa.png", true, false, false, "Kanepe", 500.00m, "3 Kişilik, Kumaş Kaplama", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8666), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8668), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/bed-sheet.png", true, false, false, "Yatak Örtüsü", 60.00m, "Pamuklu, 200x220 cm", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8667), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8672), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/lamp.png", true, false, false, "Masa Lambası", 40.00m, "LED, Ayarlanabilir Işık", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8671), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/vacuum.png", false, false, false, "Süpürge", 120.00m, "Elektrikli, HEPA Filtre", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8674), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8676), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/gym-bag.png", true, false, false, "Spor Çantası", 45.00m, "30 Litre, Çok Bölmeli", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/tent.png", true, false, false, "Tent", 200.00m, "4 Kişilik, Su Geçirmez", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8679), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8681), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8682), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/bike.png", true, false, false, "Bisiklet", 350.00m, "21 Vites, Dağ Bisikleti", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8682), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8683), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8685), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/treadmill.png", true, false, false, "Koşu Bandı", 600.00m, "Katlanabilir, 12 Program", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8684), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/gloves.png", false, false, false, "Spor Eldiveni", 25.00m, "Antrenman için, Ergonomik", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8688), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/novel.png", true, false, false, "Roman Kitabı", 20.00m, "En Çok Satanlar Listesinden", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8689), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8691), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8692), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/self-help.png", true, false, false, "Kişisel Gelişim Kitabı", 25.00m, "Motivasyon ve Başarı İçin", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8692), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8693), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8695), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/sci-fi.png", true, false, false, "Bilim Kurgu Kitabı", 30.00m, "Klasik Bilim Kurgu Eseri", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8694), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8696), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8698), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/magazine.png", true, false, false, "Dergi", 10.00m, "Aylık Teknoloji Dergisi", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8698), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8701), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/kids-book.png", false, false, false, "Çocuk Kitabı", 15.00m, "Resimli, Eğitici Hikayeler", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8702), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/lego.png", true, false, false, "Lego Seti", 80.00m, "1000 Parça, Yaratıcı Set", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8706), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/model-plane.png", true, false, false, "Model Uçak", 50.00m, "1:100 Ölçekli, Detaylı", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8705), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8707), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8708), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/puzzle.png", true, false, false, "Puzzle", 30.00m, "1000 Parça, Manzara Temalı", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8707), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 29, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8709), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/coloring-book.png", true, false, false, "Boyama Kitabı", 20.00m, "Yetişkinler İçin Mandala", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 30, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8711), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/rc-car.png", true, false, false, "RC Araba", 70.00m, "Uzaktan Kumandalı, Hızlı", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 31, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8714), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8715), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/moisturizer.png", true, false, false, "Nemlendirici Krem", 40.00m, "Cilt Bariyerini Güçlendirir", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8715), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 32, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8718), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/lipstick.png", true, false, false, "Ruj", 25.00m, "Uzun Süre Kalıcı, 12 Renk Seçeneği", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8717), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 33, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8720), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/perfume.png", true, false, false, "Parfüm", 60.00m, "100 ml, Günlük Kullanım", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 34, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8722), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/shampoo.png", true, false, false, "Şampuan", 15.00m, "Saç Dökülmesine Karşı Etkili", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8722), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 35, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8725), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8726), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/razor.png", true, false, false, "Tıraş Makinesi", 90.00m, "Islak & Kuru Kullanım", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8725), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 36, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8727), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8728), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/diapers.png", true, false, false, "Bebek Bezi", 40.00m, "Hipoalerjenik, 120 Adet", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8728), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 37, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8729), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8731), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/stroller.png", true, false, false, "Bebek Arabası", 200.00m, "Katlanabilir, Hafif", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8730), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 38, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8733), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/doll.png", true, false, false, "Oyuncak Bebek", 35.00m, "Gerçekçi Tasarım, 30 cm", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8733), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 39, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8734), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/kids-bike.png", true, false, false, "Çocuk Bisikleti", 100.00m, "12 inç, Yardımcı Tekerlekli", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 40, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8736), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8738), new TimeSpan(0, 0, 0, 0, 0)), "/images/products/baby-clothes.png", true, false, false, "Bebek Giysisi", 20.00m, "Pamuklu, Rahat", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 134, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c44cd475-5365-409f-845c-6ea238190b2b", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e" },
                    { "0517f36e-53b1-4a0d-b6b3-599afdd926cf", "d4757375-a497-496b-85dc-a510027bd9b1" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(872), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 2, "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(882), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "ApplicationUserId", "City", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "OrderStatus", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Address 1", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 2", new DateTimeOffset(new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 2, "Address 2", "d4757375-a497-496b-85dc-a510027bd9b1", "City 3", new DateTimeOffset(new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 3, "Address 3", "d4757375-a497-496b-85dc-a510027bd9b1", "City 4", new DateTimeOffset(new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 4, "Address 4", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 5", new DateTimeOffset(new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 5, "Address 5", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 1", new DateTimeOffset(new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 6, "Address 6", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 2", new DateTimeOffset(new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 7, "Address 7", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 3", new DateTimeOffset(new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 8, "Address 8", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 4", new DateTimeOffset(new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 9, "Address 9", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 5", new DateTimeOffset(new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 10, "Address 10", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 1", new DateTimeOffset(new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 11, "Address 11", "d4757375-a497-496b-85dc-a510027bd9b1", "City 2", new DateTimeOffset(new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 12, "Address 12", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 3", new DateTimeOffset(new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 13, "Address 13", "d4757375-a497-496b-85dc-a510027bd9b1", "City 4", new DateTimeOffset(new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 14, "Address 14", "d4757375-a497-496b-85dc-a510027bd9b1", "City 5", new DateTimeOffset(new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 15, "Address 15", "d4757375-a497-496b-85dc-a510027bd9b1", "City 1", new DateTimeOffset(new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 16, "Address 16", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 2", new DateTimeOffset(new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 17, "Address 17", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 3", new DateTimeOffset(new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 18, "Address 18", "d4757375-a497-496b-85dc-a510027bd9b1", "City 4", new DateTimeOffset(new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 19, "Address 19", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 5", new DateTimeOffset(new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 20, "Address 20", "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", "City 1", new DateTimeOffset(new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 4, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 4, 8 },
                    { 2, 9 },
                    { 3, 9 },
                    { 2, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 2, 16 },
                    { 4, 16 },
                    { 4, 17 },
                    { 4, 18 },
                    { 4, 19 },
                    { 4, 20 },
                    { 5, 21 },
                    { 5, 22 },
                    { 5, 23 },
                    { 5, 24 },
                    { 5, 25 },
                    { 9, 25 },
                    { 6, 26 },
                    { 9, 26 },
                    { 6, 27 },
                    { 6, 28 },
                    { 6, 29 },
                    { 6, 30 },
                    { 9, 30 },
                    { 7, 31 },
                    { 7, 32 },
                    { 7, 33 },
                    { 7, 34 },
                    { 7, 35 },
                    { 9, 36 },
                    { 9, 37 },
                    { 6, 38 },
                    { 9, 38 },
                    { 4, 39 },
                    { 9, 39 },
                    { 2, 40 },
                    { 9, 40 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4051), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 1, 24, 1, 37m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4061), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 1, 25, 3, 126m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4071), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 2, 31, 2, 273m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 2, 8, 4, 330m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4074), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 2, 29, 3, 79m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4086), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, 26, 4, 460m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, 21, 1, 214m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, 22, 3, 60m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4095), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, 8, 5, 62m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4098), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 3, 14, 1, 178m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4107), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 4, 21, 4, 151m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4109), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 4, 23, 2, 73m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 4, 2, 1, 496m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4112), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 4, 33, 2, 280m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 4, 5, 4, 134m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4128), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 5, 28, 2, 185m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 5, 16, 5, 451m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4133), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 5, 15, 5, 54m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4135), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 5, 4, 1, 313m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 6, 8, 3, 365m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4145), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 6, 20, 2, 161m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4166), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 6, 30, 5, 401m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4181), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 7, 7, 2, 71m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4183), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 7, 11, 5, 87m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 7, 4, 3, 14m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4187), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 7, 22, 2, 316m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 8, 27, 5, 103m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4207), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 9, 23, 1, 31m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 29, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4209), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 9, 22, 2, 90m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 30, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4227), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 9, 10, 1, 197m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 31, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4229), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 9, 11, 2, 244m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 32, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4254), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 10, 25, 3, 403m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 33, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4255), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 10, 4, 4, 275m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 34, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 10, 26, 4, 461m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 35, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4305), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 11, 10, 4, 124m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 36, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 11, 7, 4, 384m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 37, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 11, 26, 5, 301m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 38, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4309), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 11, 23, 3, 467m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 39, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4311), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 11, 26, 5, 326m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 40, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4319), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 12, 14, 3, 486m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 41, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4321), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 12, 34, 4, 136m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 42, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4329), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 13, 4, 5, 461m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 43, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4331), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 13, 36, 4, 373m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 44, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4333), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 13, 2, 1, 160m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 45, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 13, 25, 3, 123m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 46, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4336), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 13, 7, 1, 100m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 47, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 14, 19, 4, 324m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 48, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 14, 25, 3, 318m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 49, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4348), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 14, 23, 4, 134m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 50, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4350), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 14, 5, 2, 158m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 51, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4396), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 15, 3, 3, 349m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 52, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4397), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 15, 8, 5, 431m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 53, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4399), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 15, 28, 2, 147m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 54, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4400), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 15, 11, 4, 380m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 55, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 16, 14, 4, 459m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 56, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4412), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 16, 21, 3, 356m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 57, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4413), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 16, 8, 2, 381m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 58, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4424), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 17, 6, 2, 455m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 59, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4426), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 17, 12, 2, 289m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 60, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4435), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 18, 28, 5, 191m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 61, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 19, 17, 2, 294m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 62, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 19, 11, 2, 286m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 63, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 19, 18, 4, 352m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 64, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4460), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 20, 11, 3, 366m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 65, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 20, 6, 4, 333m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 66, new DateTimeOffset(new DateTime(2025, 3, 16, 7, 56, 28, 326, DateTimeKind.Unspecified).AddTicks(4465), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 20, 10, 1, 262m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ApplicationUserId",
                table: "Carts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiClients");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
