using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BFRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BFRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BFUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BFUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSales = table.Column<int>(type: "int", nullable: false),
                    ImportanceNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TcNo = table.Column<long>(type: "bigint", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BFUserRole",
                columns: table => new
                {
                    BFRoleId = table.Column<int>(type: "int", nullable: false),
                    BFUserId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BFUserRole", x => new { x.BFRoleId, x.BFUserId });
                    table.ForeignKey(
                        name: "FK_BFUserRole_BFRoles_BFRoleId",
                        column: x => x.BFRoleId,
                        principalTable: "BFRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BFUserRole_BFUsers_BFUserId",
                        column: x => x.BFUserId,
                        principalTable: "BFUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHome = table.Column<bool>(type: "bit", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IsDiscount = table.Column<bool>(type: "bit", nullable: false),
                    DiscountRate = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    IsHotProduct = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DiscountExpiresHour = table.Column<int>(type: "int", nullable: false),
                    NumberOfEvaluations = table.Column<int>(type: "int", nullable: false),
                    NumberOfClick = table.Column<int>(type: "int", nullable: false),
                    EvaluationPoint = table.Column<double>(type: "float", maxLength: 100, nullable: false),
                    Discount = table.Column<int>(type: "int", maxLength: 300, nullable: false),
                    NumberOfSales = table.Column<int>(type: "int", nullable: false),
                    Desfinition = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Detail1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Detail2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Detail3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FreeCargo = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluationPoint = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BFUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_BFUsers_BFUserId",
                        column: x => x.BFUserId,
                        principalTable: "BFUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSeller",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    SellersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSeller", x => new { x.ProductsId, x.SellersId });
                    table.ForeignKey(
                        name: "FK_ProductSeller_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSeller_Sellers_SellersId",
                        column: x => x.SellersId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WithOutDiscount = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BFRoles",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2422), "admin", false },
                    { 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2423), "member", false },
                    { 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2426), "customer representative", false },
                    { 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2426), "seller", false }
                });

            migrationBuilder.InsertData(
                table: "BFUsers",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "Password", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2522), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2523), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2524), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2525), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 5, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2525), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 6, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2528), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 7, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2529), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 8, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2530), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 9, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2530), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 10, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2531), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 11, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2532), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 12, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2532), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 13, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2533), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 14, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2534), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 15, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2534), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 16, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2535), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 17, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2535), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 18, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2536), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 19, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2537), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 20, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2537), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Definition", "ImportanceNumber", "IsDeleted", "NumberOfSales" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1391), "Elektronik", 0, false, 1111 },
                    { 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1394), "Giyim", 0, false, 1222 },
                    { 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1394), "Moda", 0, false, 1333 },
                    { 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1395), "Ev, Yaşam, Kırtasiye, Ofis", 0, false, 1444 },
                    { 5, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1395), "Beyaz Eşya", 0, false, 1555 },
                    { 6, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1396), "Oto, Bahçe, Yapı Market", 0, false, 1666 },
                    { 7, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1396), "Anne, Bebek, Oyuncak", 0, false, 1777 },
                    { 8, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1397), "Spor, Outdoor", 0, false, 1888 },
                    { 9, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1397), "Kozmetik, Kişisel Bakım", 0, false, 1999 },
                    { 10, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(1398), "Süpermarket, Pet Shop", 0, false, 11110 }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Address", "CreatedDate", "IsApproved", "IsDeleted", "Logo", "Name", "Surname", "TcNo" },
                values: new object[,]
                {
                    { 1, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3295), false, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 2, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3296), true, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 3, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3297), false, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 4, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3298), true, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L }
                });

            migrationBuilder.InsertData(
                table: "BFUserRole",
                columns: new[] { "BFRoleId", "BFUserId", "CreatedDate", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2585), 0, false },
                    { 2, 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2585), 0, false },
                    { 3, 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2586), 0, false },
                    { 4, 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2586), 0, false },
                    { 5, 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2587), 0, false },
                    { 6, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2587), 0, false },
                    { 7, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2588), 0, false },
                    { 8, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2588), 0, false },
                    { 9, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2589), 0, false },
                    { 10, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2589), 0, false },
                    { 11, 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2589), 0, false },
                    { 12, 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2590), 0, false },
                    { 13, 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2590), 0, false },
                    { 14, 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2591), 0, false },
                    { 15, 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2591), 0, false },
                    { 16, 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2592), 0, false },
                    { 17, 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2592), 0, false },
                    { 18, 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2593), 0, false },
                    { 19, 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2593), 0, false },
                    { 20, 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2593), 0, false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImagePath", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(950), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 2, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(964), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 3, 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(965), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 4, 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(965), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 5, 5, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(966), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 6, 6, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(966), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 7, 7, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(967), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 8, 8, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(967), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 9, 9, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(968), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 10, 10, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(968), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2123), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, true, "İphone 4s", 10, 500, 0, 1, 5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2128), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "İphone 4s", 14, 500, 0, 1, 0 },
                    { 3, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2154), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Gömlek", 13, 500, 0, 1, 8 },
                    { 4, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2156), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 34, 500, 0, 1, 4 },
                    { 5, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2157), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 76, 500, 0, 1, 4 },
                    { 6, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2158), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 89, 500, 0, 1, 4 },
                    { 7, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2159), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 67, 500, 0, 1, 4 },
                    { 8, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2160), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 89, 500, 0, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[] { 9, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2161), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, true, "Pantolon", 474, 500, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[,]
                {
                    { 10, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2163), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 67, 500, 0, 1, 4 },
                    { 11, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2164), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 89, 500, 0, 2, 4 },
                    { 12, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2165), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[,]
                {
                    { 13, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2167), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 14, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2168), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 15, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2169), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 16, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2170), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 17, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2174), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 18, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2175), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 19, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2176), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 20, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2178), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 21, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2179), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 22, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2180), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 23, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2181), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 24, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2182), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 25, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2183), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 26, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2184), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 27, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2187), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 28, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2189), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 29, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2190), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 30, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2191), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 31, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2192), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 32, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2193), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 33, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2194), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 34, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2197), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 35, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2198), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 36, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2199), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 37, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2200), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 38, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2254), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 39, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2256), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 40, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2257), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BFUserId", "CreatedDate", "Description", "EvaluationPoint", "IsDeleted", "Mail", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3485), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 2, 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3487), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 3, 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3488), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 4, 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3488), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 5, 5, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3489), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 6, 6, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3490), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 7, 7, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3490), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 8, 8, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3491), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 9, 9, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3492), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 10, 10, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3492), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 11, 11, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3493), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 12, 12, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3493), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 13, 13, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3494), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 14, 14, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3497), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 15, 15, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3498), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 16, 16, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3499), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 17, 17, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3499), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 18, 18, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3500), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 19, 19, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3501), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 20, 20, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(3501), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2902), "https://productimages.hepsiburada.net/s/189/550/110000155170579.jpg/format:webp", false, 1 },
                    { 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2904), "https://productimages.hepsiburada.net/s/189/550/110000155170580.jpg/format:webp", false, 1 },
                    { 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2905), "https://productimages.hepsiburada.net/s/189/550/110000155170581.jpg/format:webp", false, 1 },
                    { 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2906), "https://productimages.hepsiburada.net/s/189/550/110000155170582.jpg/format:webp", false, 1 },
                    { 5, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2906), "https://productimages.hepsiburada.net/s/189/550/110000155170583.jpg/format:webp", false, 1 },
                    { 6, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2906), "https://productimages.hepsiburada.net/s/189/550/110000155170584.jpg/format:webp", false, 1 },
                    { 7, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2907), "https://productimages.hepsiburada.net/s/189/550/110000155170585.jpg/format:webp", false, 1 },
                    { 8, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2907), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 9, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2908), "https://productimages.hepsiburada.net/s/189/550/110000155170587.jpg/format:webp", false, 9 },
                    { 10, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2908), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 11, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2909), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 12, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2909), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 2 },
                    { 13, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2910), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 3 },
                    { 14, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2910), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 4 },
                    { 15, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2911), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 5 },
                    { 16, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2912), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 6 },
                    { 17, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2913), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 7 },
                    { 18, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2913), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 8 },
                    { 19, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2914), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 9 },
                    { 20, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2914), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 10 },
                    { 21, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2915), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 11 },
                    { 22, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2915), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 12 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 23, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2916), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 13 },
                    { 24, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2916), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 14 },
                    { 25, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2917), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 15 },
                    { 26, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2917), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 16 },
                    { 27, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2919), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 17 },
                    { 28, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2920), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 18 },
                    { 29, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2920), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 19 },
                    { 30, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2921), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 20 },
                    { 31, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2921), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 21 },
                    { 32, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2922), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 22 },
                    { 33, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2922), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 23 },
                    { 34, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2923), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 24 },
                    { 35, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2941), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 25 },
                    { 36, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2942), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 26 },
                    { 37, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2942), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 27 },
                    { 38, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2943), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 28 },
                    { 39, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2943), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 29 },
                    { 40, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2944), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 30 },
                    { 41, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2944), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 31 },
                    { 42, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2945), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 32 },
                    { 43, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2945), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 33 },
                    { 44, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2946), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 34 },
                    { 45, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2946), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 35 },
                    { 46, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2951), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 36 },
                    { 47, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2952), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 37 },
                    { 48, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2952), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 38 },
                    { 49, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2953), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 39 },
                    { 50, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2953), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 40 },
                    { 51, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2954), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 1 },
                    { 52, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2954), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 2 },
                    { 53, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2955), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 3 },
                    { 54, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2955), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 4 },
                    { 55, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2956), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 5 },
                    { 56, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2956), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 6 },
                    { 57, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2957), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 7 },
                    { 58, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2957), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 8 },
                    { 59, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2958), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 9 },
                    { 60, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2958), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 10 },
                    { 61, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2958), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 1 },
                    { 62, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2959), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 2 },
                    { 63, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2959), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 3 },
                    { 64, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2960), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 65, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2960), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 5 },
                    { 66, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2961), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 6 },
                    { 67, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2961), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 7 },
                    { 68, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2962), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 8 },
                    { 69, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2962), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 9 },
                    { 70, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2963), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 10 },
                    { 71, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2963), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 11 },
                    { 72, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2964), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 12 },
                    { 73, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2964), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 13 },
                    { 74, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2965), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 14 },
                    { 75, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2965), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 15 },
                    { 76, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2966), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 16 },
                    { 77, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2966), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 17 },
                    { 78, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2967), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 18 },
                    { 79, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2967), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 19 },
                    { 80, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2968), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 20 },
                    { 81, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2968), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 21 },
                    { 82, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2969), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 22 },
                    { 83, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2969), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 23 },
                    { 84, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2970), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 24 },
                    { 85, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2970), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 25 },
                    { 86, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2971), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 26 },
                    { 87, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2971), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 27 },
                    { 88, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2971), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 28 },
                    { 89, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2972), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 29 },
                    { 90, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2972), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 30 },
                    { 91, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2973), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 31 },
                    { 92, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2973), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 32 },
                    { 93, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2974), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 33 },
                    { 94, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2974), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 34 },
                    { 95, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2975), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 35 },
                    { 96, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2975), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 36 },
                    { 97, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2976), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 37 },
                    { 98, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2976), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 38 },
                    { 99, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2977), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 39 },
                    { 100, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2977), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 40 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId", "WithOutDiscount" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2748), "64 GB", false, "Hafıza", 10001.0, 1, 50000.0 },
                    { 2, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2751), "64 GB", false, "Hafıza", 10002.0, 2, 50000.0 },
                    { 3, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2752), "64 GB", false, "Hafıza", 10003.0, 3, 50000.0 },
                    { 4, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2753), "64 GB", false, "Hafıza", 10004.0, 4, 50000.0 },
                    { 5, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2753), "64 GB", false, "Hafıza", 10005.0, 5, 50000.0 },
                    { 6, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2754), "64 GB", false, "Hafıza", 10006.0, 6, 50000.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId", "WithOutDiscount" },
                values: new object[,]
                {
                    { 7, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2754), "64 GB", false, "Hafıza", 10007.0, 7, 50000.0 },
                    { 8, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2756), "64 GB", false, "Hafıza", 10008.0, 8, 50000.0 },
                    { 9, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2757), "64 GB", false, "Hafıza", 10009.0, 9, 50000.0 },
                    { 10, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2757), "64 GB", false, "Hafıza", 100010.0, 10, 50000.0 },
                    { 11, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2758), "64 GB", false, "Hafıza", 100011.0, 11, 50000.0 },
                    { 12, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2759), "64 GB", false, "Hafıza", 100012.0, 12, 50000.0 },
                    { 13, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2759), "64 GB", false, "Hafıza", 100013.0, 13, 50000.0 },
                    { 14, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2760), "64 GB", false, "Hafıza", 100014.0, 14, 50000.0 },
                    { 15, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2760), "64 GB", false, "Hafıza", 100015.0, 15, 50000.0 },
                    { 16, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2761), "64 GB", false, "Hafıza", 100016.0, 16, 50000.0 },
                    { 17, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2762), "64 GB", false, "Hafıza", 100017.0, 17, 50000.0 },
                    { 18, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2762), "64 GB", false, "Hafıza", 100018.0, 18, 50000.0 },
                    { 19, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2763), "64 GB", false, "Hafıza", 100019.0, 19, 50000.0 },
                    { 20, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2763), "64 GB", false, "Hafıza", 100020.0, 20, 50000.0 },
                    { 21, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2765), "64 GB", false, "Hafıza", 10021.0, 21, 50000.0 },
                    { 22, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2766), "64 GB", false, "Hafıza", 10022.0, 22, 50000.0 },
                    { 23, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2766), "64 GB", false, "Hafıza", 10023.0, 23, 50000.0 },
                    { 24, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2767), "64 GB", false, "Hafıza", 10024.0, 24, 50000.0 },
                    { 25, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2767), "64 GB", false, "Hafıza", 10025.0, 25, 50000.0 },
                    { 26, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2768), "64 GB", false, "Hafıza", 10026.0, 26, 50000.0 },
                    { 27, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2769), "64 GB", false, "Hafıza", 10027.0, 27, 50000.0 },
                    { 28, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2769), "64 GB", false, "Hafıza", 10028.0, 28, 50000.0 },
                    { 29, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2770), "64 GB", false, "Hafıza", 10029.0, 29, 50000.0 },
                    { 30, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2770), "64 GB", false, "Hafıza", 10030.0, 30, 50000.0 },
                    { 31, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2771), "64 GB", false, "Hafıza", 1310.0, 31, 50000.0 },
                    { 32, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2772), "64 GB", false, "Hafıza", 1320.0, 32, 50000.0 },
                    { 33, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2772), "64 GB", false, "Hafıza", 1330.0, 33, 50000.0 },
                    { 34, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2773), "64 GB", false, "Hafıza", 1340.0, 34, 50000.0 },
                    { 35, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2773), "64 GB", false, "Hafıza", 1350.0, 35, 50000.0 },
                    { 36, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2774), "64 GB", false, "Hafıza", 1360.0, 36, 50000.0 },
                    { 37, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2775), "64 GB", false, "Hafıza", 1370.0, 37, 50000.0 },
                    { 38, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2775), "64 GB", false, "Hafıza", 1380.0, 38, 50000.0 },
                    { 39, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2776), "64 GB", false, "Hafıza", 1390.0, 39, 50000.0 },
                    { 40, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2778), "64 GB", false, "Hafıza", 1400.0, 40, 50000.0 },
                    { 50, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2778), "64 GB", false, "Hafıza", 1050.0, 30, 50000.0 },
                    { 51, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2779), "64 GB", false, "Hafıza", 1050.0, 1, 50000.0 },
                    { 52, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2779), "64 GB", false, "Hafıza", 1050.0, 2, 50000.0 },
                    { 53, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2780), "64 GB", false, "Hafıza", 1050.0, 3, 50000.0 },
                    { 54, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2781), "64 GB", false, "Hafıza", 1050.0, 4, 50000.0 },
                    { 55, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2781), "64 GB", false, "Hafıza", 1050.0, 5, 50000.0 },
                    { 56, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2782), "64 GB", false, "Hafıza", 1050.0, 6, 50000.0 },
                    { 57, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2783), "64 GB", false, "Hafıza", 1050.0, 7, 50000.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId", "WithOutDiscount" },
                values: new object[,]
                {
                    { 58, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2783), "64 GB", false, "Hafıza", 1050.0, 8, 50000.0 },
                    { 59, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2784), "64 GB", false, "Hafıza", 1050.0, 9, 50000.0 },
                    { 60, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2784), "64 GB", false, "Hafıza", 6000.0, 10, 50000.0 },
                    { 61, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2785), "64 GB", false, "Hafıza", 6100.0, 11, 50000.0 },
                    { 62, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2786), "64 GB", false, "Hafıza", 6200.0, 12, 50000.0 },
                    { 63, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2786), "64 GB", false, "Hafıza", 6300.0, 13, 50000.0 },
                    { 64, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2787), "64 GB", false, "Hafıza", 6400.0, 14, 50000.0 },
                    { 65, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2787), "64 GB", false, "Hafıza", 6500.0, 15, 50000.0 },
                    { 66, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2788), "64 GB", false, "Hafıza", 6600.0, 16, 50000.0 },
                    { 67, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2790), "64 GB", false, "Hafıza", 6700.0, 17, 50000.0 },
                    { 68, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2790), "64 GB", false, "Hafıza", 6800.0, 18, 50000.0 },
                    { 69, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2792), "64 GB", false, "Hafıza", 6900.0, 19, 50000.0 },
                    { 70, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2793), "64 GB", false, "Hafıza", 700.0, 20, 50000.0 },
                    { 71, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2794), "64 GB", false, "Hafıza", 710.0, 21, 50000.0 },
                    { 72, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2814), "64 GB", false, "Hafıza", 720.0, 22, 50000.0 },
                    { 73, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2815), "64 GB", false, "Hafıza", 730.0, 23, 50000.0 },
                    { 74, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2815), "64 GB", false, "Hafıza", 740.0, 24, 50000.0 },
                    { 75, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2816), "64 GB", false, "Hafıza", 750.0, 25, 50000.0 },
                    { 76, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2817), "64 GB", false, "Hafıza", 760.0, 26, 50000.0 },
                    { 77, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2818), "64 GB", false, "Hafıza", 770.0, 27, 50000.0 },
                    { 78, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2819), "64 GB", false, "Hafıza", 780.0, 28, 50000.0 },
                    { 79, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2820), "64 GB", false, "Hafıza", 790.0, 29, 50000.0 },
                    { 80, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2821), "64 GB", false, "Hafıza", 1088.0, 30, 50000.0 },
                    { 81, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2821), "64 GB", false, "Hafıza", 1188.0, 31, 50000.0 },
                    { 82, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2822), "64 GB", false, "Hafıza", 1288.0, 32, 50000.0 },
                    { 83, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2823), "64 GB", false, "Hafıza", 1388.0, 33, 50000.0 },
                    { 84, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2823), "64 GB", false, "Hafıza", 1488.0, 34, 50000.0 },
                    { 85, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2825), "64 GB", false, "Hafıza", 1588.0, 35, 50000.0 },
                    { 86, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2826), "64 GB", false, "Hafıza", 1688.0, 36, 50000.0 },
                    { 87, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2827), "64 GB", false, "Hafıza", 1788.0, 37, 50000.0 },
                    { 88, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2828), "64 GB", false, "Hafıza", 1888.0, 38, 50000.0 },
                    { 89, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2829), "64 GB", false, "Hafıza", 1988.0, 39, 50000.0 },
                    { 90, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2829), "64 GB", false, "Hafıza", 1009.0, 30, 50000.0 },
                    { 91, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2830), "64 GB", false, "Hafıza", 1009.0, 1, 50000.0 },
                    { 92, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2830), "64 GB", false, "Hafıza", 1009.0, 2, 50000.0 },
                    { 93, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2831), "64 GB", false, "Hafıza", 1009.0, 3, 50000.0 },
                    { 94, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2832), "64 GB", false, "Hafıza", 1009.0, 4, 50000.0 },
                    { 95, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2833), "64 GB", false, "Hafıza", 1009.0, 5, 50000.0 },
                    { 96, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2833), "64 GB", false, "Hafıza", 1009.0, 6, 50000.0 },
                    { 97, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2834), "64 GB", false, "Hafıza", 1009.0, 7, 50000.0 },
                    { 98, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2835), "64 GB", false, "Hafıza", 1009.0, 8, 50000.0 },
                    { 99, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2835), "64 GB", false, "Hafıza", 1009.0, 9, 50000.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId", "WithOutDiscount" },
                values: new object[,]
                {
                    { 100, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2836), "64 GB", false, "Hafıza", 10010.0, 10, 50000.0 },
                    { 111, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2836), "64 GB", false, "Hafıza", 10011.0, 11, 50000.0 },
                    { 122, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2837), "64 GB", false, "Hafıza", 10012.0, 12, 50000.0 },
                    { 133, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2838), "64 GB", false, "Hafıza", 10013.0, 13, 50000.0 },
                    { 144, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2839), "64 GB", false, "Hafıza", 10014.0, 14, 50000.0 },
                    { 155, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2839), "64 GB", false, "Hafıza", 10015.0, 15, 50000.0 },
                    { 166, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2840), "64 GB", false, "Hafıza", 10016.0, 16, 50000.0 },
                    { 177, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2841), "64 GB", false, "Hafıza", 10017.0, 17, 50000.0 },
                    { 188, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2841), "64 GB", false, "Hafıza", 10018.0, 18, 50000.0 },
                    { 199, new DateTime(2022, 8, 1, 6, 25, 52, 730, DateTimeKind.Local).AddTicks(2842), "64 GB", false, "Hafıza", 10019.0, 19, 50000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BFUserRole_BFUserId",
                table: "BFUserRole",
                column: "BFUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BFUserId",
                table: "Comments",
                column: "BFUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CategoryId",
                table: "Images",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSeller_SellersId",
                table: "ProductSeller",
                column: "SellersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariants",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BFUserRole");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductSeller");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "BFRoles");

            migrationBuilder.DropTable(
                name: "BFUsers");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
