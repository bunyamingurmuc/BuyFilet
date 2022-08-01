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
                    { 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4200), "admin", false },
                    { 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4202), "member", false },
                    { 3, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4203), "customer representative", false },
                    { 4, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4204), "seller", false }
                });

            migrationBuilder.InsertData(
                table: "BFUsers",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "Password", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4339), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4341), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 3, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4342), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 4, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4343), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 5, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4344), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 6, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4345), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 7, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4346), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 8, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4347), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 9, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4347), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 10, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4348), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 11, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4349), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 12, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4350), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 13, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4351), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 14, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4352), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 15, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4352), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 16, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4353), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 17, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4354), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 18, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4355), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 19, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4356), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 20, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4356), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Definition", "ImportanceNumber", "IsDeleted", "NumberOfSales" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2610), "Elektronik", 0, false, 1111 },
                    { 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2615), "Giyim", 0, false, 1222 },
                    { 3, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2616), "Moda", 0, false, 1333 },
                    { 4, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2616), "Ev, Yaşam, Kırtasiye, Ofis", 0, false, 1444 },
                    { 5, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2617), "Beyaz Eşya", 0, false, 1555 },
                    { 6, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2618), "Oto, Bahçe, Yapı Market", 0, false, 1666 },
                    { 7, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2619), "Anne, Bebek, Oyuncak", 0, false, 1777 },
                    { 8, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2620), "Spor, Outdoor", 0, false, 1888 },
                    { 9, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2620), "Kozmetik, Kişisel Bakım", 0, false, 1999 },
                    { 10, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2621), "Süpermarket, Pet Shop", 0, false, 11110 }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Address", "CreatedDate", "IsApproved", "IsDeleted", "Logo", "Name", "Surname", "TcNo" },
                values: new object[,]
                {
                    { 1, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6434), false, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 2, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6439), true, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 3, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6441), false, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 4, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6442), true, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L }
                });

            migrationBuilder.InsertData(
                table: "BFUserRole",
                columns: new[] { "BFRoleId", "BFUserId", "CreatedDate", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4447), 0, false },
                    { 1, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4449), 0, false },
                    { 1, 3, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4450), 0, false },
                    { 1, 4, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4450), 0, false },
                    { 1, 5, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4451), 0, false },
                    { 2, 6, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4452), 0, false },
                    { 2, 7, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4452), 0, false },
                    { 2, 8, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4453), 0, false },
                    { 2, 9, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4454), 0, false },
                    { 2, 10, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4454), 0, false },
                    { 3, 11, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4455), 0, false },
                    { 3, 12, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4456), 0, false },
                    { 3, 13, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4456), 0, false },
                    { 3, 14, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4457), 0, false },
                    { 3, 15, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4458), 0, false },
                    { 4, 16, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4458), 0, false },
                    { 4, 17, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4459), 0, false },
                    { 4, 18, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4460), 0, false },
                    { 4, 19, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4460), 0, false },
                    { 4, 20, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(4461), 0, false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImagePath", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2028), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 2, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2044), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 3, 3, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2045), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 4, 4, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2046), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 5, 5, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2046), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 6, 6, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2047), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 7, 7, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2048), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 8, 8, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2049), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 9, 9, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2049), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 10, 10, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(2050), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3876), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, true, "İphone 4s", 10, 500, 0, 1, 5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3883), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "İphone 4s", 14, 500, 0, 1, 0 },
                    { 3, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3886), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Gömlek", 13, 500, 0, 1, 8 },
                    { 4, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3888), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 34, 500, 0, 1, 4 },
                    { 5, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3889), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 76, 500, 0, 1, 4 },
                    { 6, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3891), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 89, 500, 0, 1, 4 },
                    { 7, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3893), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 67, 500, 0, 1, 4 },
                    { 8, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3895), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 89, 500, 0, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[] { 9, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3899), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, true, "Pantolon", 474, 500, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[,]
                {
                    { 10, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3901), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 67, 500, 0, 1, 4 },
                    { 11, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3902), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 89, 500, 0, 2, 4 },
                    { 12, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3904), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "SellerId", "Stock" },
                values: new object[,]
                {
                    { 13, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3905), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 14, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3907), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 15, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3909), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 16, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3910), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 17, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3912), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 18, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3913), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 19, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3915), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 20, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3916), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 10, 500, 0, 2, 4 },
                    { 21, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3918), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 22, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3920), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 23, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3922), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 24, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3924), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 25, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3925), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 26, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3927), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 27, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3929), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 28, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3932), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 29, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3934), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 30, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3935), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 3, 4 },
                    { 31, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3941), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 32, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3942), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 33, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3944), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, true, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 34, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3945), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 35, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3947), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 36, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3991), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 37, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3993), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 38, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3995), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 39, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3996), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 },
                    { 40, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(3998), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, false, false, false, true, "Pantolon", 10, 500, 0, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BFUserId", "CreatedDate", "Description", "EvaluationPoint", "IsDeleted", "Mail", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6840), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 2, 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6843), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 3, 3, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6845), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 4, 4, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6846), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 5, 5, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6847), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 6, 6, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6848), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 7, 7, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6849), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 8, 8, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6850), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 9, 9, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6851), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 10, 10, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6852), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 11, 11, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6853), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 12, 12, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6854), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 13, 13, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6855), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 14, 14, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6856), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 15, 15, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6856), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 16, 16, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6857), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 17, 17, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6858), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 18, 18, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6859), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 19, 19, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6860), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 20, 20, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(6861), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5457), "https://productimages.hepsiburada.net/s/189/550/110000155170579.jpg/format:webp", false, 1 },
                    { 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5458), "https://productimages.hepsiburada.net/s/189/550/110000155170580.jpg/format:webp", false, 1 },
                    { 3, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5459), "https://productimages.hepsiburada.net/s/189/550/110000155170581.jpg/format:webp", false, 1 },
                    { 4, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5460), "https://productimages.hepsiburada.net/s/189/550/110000155170582.jpg/format:webp", false, 1 },
                    { 5, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5461), "https://productimages.hepsiburada.net/s/189/550/110000155170583.jpg/format:webp", false, 1 },
                    { 6, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5462), "https://productimages.hepsiburada.net/s/189/550/110000155170584.jpg/format:webp", false, 1 },
                    { 7, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5463), "https://productimages.hepsiburada.net/s/189/550/110000155170585.jpg/format:webp", false, 1 },
                    { 8, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5463), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 9, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5464), "https://productimages.hepsiburada.net/s/189/550/110000155170587.jpg/format:webp", false, 9 },
                    { 10, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5465), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 11, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5465), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 12, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5466), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 2 },
                    { 13, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5467), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 3 },
                    { 14, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5468), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 4 },
                    { 15, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5468), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 5 },
                    { 16, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5469), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 6 },
                    { 17, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5470), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 7 },
                    { 18, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5470), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 8 },
                    { 19, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5471), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 9 },
                    { 20, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5472), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 10 },
                    { 21, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5472), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 11 },
                    { 22, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5473), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 12 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 23, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5474), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 13 },
                    { 24, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5475), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 14 },
                    { 25, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5475), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 15 },
                    { 26, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5476), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 16 },
                    { 27, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5477), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 17 },
                    { 28, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5477), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 18 },
                    { 29, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5478), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 19 },
                    { 30, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5479), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 20 },
                    { 31, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5479), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 21 },
                    { 32, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5522), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 22 },
                    { 33, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5524), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 23 },
                    { 34, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5524), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 24 },
                    { 35, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5525), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 25 },
                    { 36, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5526), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 26 },
                    { 37, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5527), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 27 },
                    { 38, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5527), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 28 },
                    { 39, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5528), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 29 },
                    { 40, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5529), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 30 },
                    { 41, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5529), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 31 },
                    { 42, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5530), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 32 },
                    { 43, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5531), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 33 },
                    { 44, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5531), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 34 },
                    { 45, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5532), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 35 },
                    { 46, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5533), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 36 },
                    { 47, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5533), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 37 },
                    { 48, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5534), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 38 },
                    { 49, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5535), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 39 },
                    { 50, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5535), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 40 },
                    { 51, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5536), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 1 },
                    { 52, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5537), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 2 },
                    { 53, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5537), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 3 },
                    { 54, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5538), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 4 },
                    { 55, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5539), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 5 },
                    { 56, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5541), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 6 },
                    { 57, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5542), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 7 },
                    { 58, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5542), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 8 },
                    { 59, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5543), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 9 },
                    { 60, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5544), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 10 },
                    { 61, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5544), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 1 },
                    { 62, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5545), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 2 },
                    { 63, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5546), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 3 },
                    { 64, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5546), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 65, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5547), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 5 },
                    { 66, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5548), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 6 },
                    { 67, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5548), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 7 },
                    { 68, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5549), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 8 },
                    { 69, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5551), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 9 },
                    { 70, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5552), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 10 },
                    { 71, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5552), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 11 },
                    { 72, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5553), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 12 },
                    { 73, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5554), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 13 },
                    { 74, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5554), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 14 },
                    { 75, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5555), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 15 },
                    { 76, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5556), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 16 },
                    { 77, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5556), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 17 },
                    { 78, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5557), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 18 },
                    { 79, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5558), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 19 },
                    { 80, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5558), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 20 },
                    { 81, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5559), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 21 },
                    { 82, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5560), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 22 },
                    { 83, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5560), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 23 },
                    { 84, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5561), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 24 },
                    { 85, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5562), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 25 },
                    { 86, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5562), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 26 },
                    { 87, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5563), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 27 },
                    { 88, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5564), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 28 },
                    { 89, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5564), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 29 },
                    { 90, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5565), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 30 },
                    { 91, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5566), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 31 },
                    { 92, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5566), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 32 },
                    { 93, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5567), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 33 },
                    { 94, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5568), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 34 },
                    { 95, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5569), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 35 },
                    { 96, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5569), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 36 },
                    { 97, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5570), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 37 },
                    { 98, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5571), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 38 },
                    { 99, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5571), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 39 },
                    { 100, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5572), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 40 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId", "WithOutDiscount" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5180), "64 GB", false, "Hafıza", 10001.0, 1, 50000.0 },
                    { 2, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5185), "64 GB", false, "Hafıza", 10002.0, 2, 50000.0 },
                    { 3, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5186), "64 GB", false, "Hafıza", 10003.0, 3, 50000.0 },
                    { 4, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5187), "64 GB", false, "Hafıza", 10004.0, 4, 50000.0 },
                    { 5, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5188), "64 GB", false, "Hafıza", 10005.0, 5, 50000.0 },
                    { 6, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5189), "64 GB", false, "Hafıza", 10006.0, 6, 50000.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId", "WithOutDiscount" },
                values: new object[,]
                {
                    { 7, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5189), "64 GB", false, "Hafıza", 10007.0, 7, 50000.0 },
                    { 8, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5190), "64 GB", false, "Hafıza", 10008.0, 8, 50000.0 },
                    { 9, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5191), "64 GB", false, "Hafıza", 10009.0, 9, 50000.0 },
                    { 10, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5192), "64 GB", false, "Hafıza", 100010.0, 10, 50000.0 },
                    { 11, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5193), "64 GB", false, "Hafıza", 100011.0, 11, 50000.0 },
                    { 12, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5194), "64 GB", false, "Hafıza", 100012.0, 12, 50000.0 },
                    { 13, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5195), "64 GB", false, "Hafıza", 100013.0, 13, 50000.0 },
                    { 14, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5196), "64 GB", false, "Hafıza", 100014.0, 14, 50000.0 },
                    { 15, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5196), "64 GB", false, "Hafıza", 100015.0, 15, 50000.0 },
                    { 16, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5198), "64 GB", false, "Hafıza", 100016.0, 16, 50000.0 },
                    { 17, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5199), "64 GB", false, "Hafıza", 100017.0, 17, 50000.0 },
                    { 18, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5200), "64 GB", false, "Hafıza", 100018.0, 18, 50000.0 },
                    { 19, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5202), "64 GB", false, "Hafıza", 100019.0, 19, 50000.0 },
                    { 20, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5203), "64 GB", false, "Hafıza", 100020.0, 20, 50000.0 },
                    { 21, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5204), "64 GB", false, "Hafıza", 10021.0, 21, 50000.0 },
                    { 22, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5205), "64 GB", false, "Hafıza", 10022.0, 22, 50000.0 },
                    { 23, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5205), "64 GB", false, "Hafıza", 10023.0, 23, 50000.0 },
                    { 24, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5206), "64 GB", false, "Hafıza", 10024.0, 24, 50000.0 },
                    { 25, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5207), "64 GB", false, "Hafıza", 10025.0, 25, 50000.0 },
                    { 26, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5208), "64 GB", false, "Hafıza", 10026.0, 26, 50000.0 },
                    { 27, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5209), "64 GB", false, "Hafıza", 10027.0, 27, 50000.0 },
                    { 28, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5210), "64 GB", false, "Hafıza", 10028.0, 28, 50000.0 },
                    { 29, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5210), "64 GB", false, "Hafıza", 10029.0, 29, 50000.0 },
                    { 30, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5211), "64 GB", false, "Hafıza", 10030.0, 30, 50000.0 },
                    { 31, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5212), "64 GB", false, "Hafıza", 1310.0, 31, 50000.0 },
                    { 32, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5213), "64 GB", false, "Hafıza", 1320.0, 32, 50000.0 },
                    { 33, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5214), "64 GB", false, "Hafıza", 1330.0, 33, 50000.0 },
                    { 34, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5215), "64 GB", false, "Hafıza", 1340.0, 34, 50000.0 },
                    { 35, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5216), "64 GB", false, "Hafıza", 1350.0, 35, 50000.0 },
                    { 36, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5217), "64 GB", false, "Hafıza", 1360.0, 36, 50000.0 },
                    { 37, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5218), "64 GB", false, "Hafıza", 1370.0, 37, 50000.0 },
                    { 38, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5219), "64 GB", false, "Hafıza", 1380.0, 38, 50000.0 },
                    { 39, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5220), "64 GB", false, "Hafıza", 1390.0, 39, 50000.0 },
                    { 40, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5225), "64 GB", false, "Hafıza", 1400.0, 40, 50000.0 },
                    { 50, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5226), "64 GB", false, "Hafıza", 1050.0, 30, 50000.0 },
                    { 51, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5227), "64 GB", false, "Hafıza", 1050.0, 1, 50000.0 },
                    { 52, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5227), "64 GB", false, "Hafıza", 1050.0, 2, 50000.0 },
                    { 53, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5228), "64 GB", false, "Hafıza", 1050.0, 3, 50000.0 },
                    { 54, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5229), "64 GB", false, "Hafıza", 1050.0, 4, 50000.0 },
                    { 55, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5230), "64 GB", false, "Hafıza", 1050.0, 5, 50000.0 },
                    { 56, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5231), "64 GB", false, "Hafıza", 1050.0, 6, 50000.0 },
                    { 57, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5232), "64 GB", false, "Hafıza", 1050.0, 7, 50000.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId", "WithOutDiscount" },
                values: new object[,]
                {
                    { 58, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5232), "64 GB", false, "Hafıza", 1050.0, 8, 50000.0 },
                    { 59, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5233), "64 GB", false, "Hafıza", 1050.0, 9, 50000.0 },
                    { 60, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5234), "64 GB", false, "Hafıza", 6000.0, 10, 50000.0 },
                    { 61, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5235), "64 GB", false, "Hafıza", 6100.0, 11, 50000.0 },
                    { 62, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5237), "64 GB", false, "Hafıza", 6200.0, 12, 50000.0 },
                    { 63, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5239), "64 GB", false, "Hafıza", 6300.0, 13, 50000.0 },
                    { 64, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5240), "64 GB", false, "Hafıza", 6400.0, 14, 50000.0 },
                    { 65, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5241), "64 GB", false, "Hafıza", 6500.0, 15, 50000.0 },
                    { 66, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5242), "64 GB", false, "Hafıza", 6600.0, 16, 50000.0 },
                    { 67, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5242), "64 GB", false, "Hafıza", 6700.0, 17, 50000.0 },
                    { 68, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5243), "64 GB", false, "Hafıza", 6800.0, 18, 50000.0 },
                    { 69, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5244), "64 GB", false, "Hafıza", 6900.0, 19, 50000.0 },
                    { 70, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5291), "64 GB", false, "Hafıza", 700.0, 20, 50000.0 },
                    { 71, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5293), "64 GB", false, "Hafıza", 710.0, 21, 50000.0 },
                    { 72, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5294), "64 GB", false, "Hafıza", 720.0, 22, 50000.0 },
                    { 73, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5295), "64 GB", false, "Hafıza", 730.0, 23, 50000.0 },
                    { 74, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5296), "64 GB", false, "Hafıza", 740.0, 24, 50000.0 },
                    { 75, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5296), "64 GB", false, "Hafıza", 750.0, 25, 50000.0 },
                    { 76, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5297), "64 GB", false, "Hafıza", 760.0, 26, 50000.0 },
                    { 77, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5298), "64 GB", false, "Hafıza", 770.0, 27, 50000.0 },
                    { 78, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5299), "64 GB", false, "Hafıza", 780.0, 28, 50000.0 },
                    { 79, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5300), "64 GB", false, "Hafıza", 790.0, 29, 50000.0 },
                    { 80, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5301), "64 GB", false, "Hafıza", 1088.0, 30, 50000.0 },
                    { 81, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5301), "64 GB", false, "Hafıza", 1188.0, 31, 50000.0 },
                    { 82, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5302), "64 GB", false, "Hafıza", 1288.0, 32, 50000.0 },
                    { 83, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5304), "64 GB", false, "Hafıza", 1388.0, 33, 50000.0 },
                    { 84, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5305), "64 GB", false, "Hafıza", 1488.0, 34, 50000.0 },
                    { 85, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5306), "64 GB", false, "Hafıza", 1588.0, 35, 50000.0 },
                    { 86, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5307), "64 GB", false, "Hafıza", 1688.0, 36, 50000.0 },
                    { 87, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5308), "64 GB", false, "Hafıza", 1788.0, 37, 50000.0 },
                    { 88, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5310), "64 GB", false, "Hafıza", 1888.0, 38, 50000.0 },
                    { 89, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5311), "64 GB", false, "Hafıza", 1988.0, 39, 50000.0 },
                    { 90, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5312), "64 GB", false, "Hafıza", 1009.0, 30, 50000.0 },
                    { 91, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5313), "64 GB", false, "Hafıza", 1009.0, 1, 50000.0 },
                    { 92, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5313), "64 GB", false, "Hafıza", 1009.0, 2, 50000.0 },
                    { 93, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5314), "64 GB", false, "Hafıza", 1009.0, 3, 50000.0 },
                    { 94, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5315), "64 GB", false, "Hafıza", 1009.0, 4, 50000.0 },
                    { 95, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5316), "64 GB", false, "Hafıza", 1009.0, 5, 50000.0 },
                    { 96, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5317), "64 GB", false, "Hafıza", 1009.0, 6, 50000.0 },
                    { 97, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5318), "64 GB", false, "Hafıza", 1009.0, 7, 50000.0 },
                    { 98, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5318), "64 GB", false, "Hafıza", 1009.0, 8, 50000.0 },
                    { 99, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5319), "64 GB", false, "Hafıza", 1009.0, 9, 50000.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId", "WithOutDiscount" },
                values: new object[,]
                {
                    { 100, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5320), "64 GB", false, "Hafıza", 10010.0, 10, 50000.0 },
                    { 111, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5321), "64 GB", false, "Hafıza", 10011.0, 11, 50000.0 },
                    { 122, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5322), "64 GB", false, "Hafıza", 10012.0, 12, 50000.0 },
                    { 133, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5323), "64 GB", false, "Hafıza", 10013.0, 13, 50000.0 },
                    { 144, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5324), "64 GB", false, "Hafıza", 10014.0, 14, 50000.0 },
                    { 155, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5324), "64 GB", false, "Hafıza", 10015.0, 15, 50000.0 },
                    { 166, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5325), "64 GB", false, "Hafıza", 10016.0, 16, 50000.0 },
                    { 177, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5326), "64 GB", false, "Hafıza", 10017.0, 17, 50000.0 },
                    { 188, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5327), "64 GB", false, "Hafıza", 10018.0, 18, 50000.0 },
                    { 199, new DateTime(2022, 8, 1, 8, 35, 2, 867, DateTimeKind.Local).AddTicks(5328), "64 GB", false, "Hafıza", 10019.0, 19, 50000.0 }
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
