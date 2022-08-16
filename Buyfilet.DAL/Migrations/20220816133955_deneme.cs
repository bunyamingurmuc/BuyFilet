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
                    StockCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    WithOutDiscount = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Products_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
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
                name: "QuestionAndAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(1700)", maxLength: 1700, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(1700)", maxLength: 1700, nullable: false),
                    ResponseTime = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    BFUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAndAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAndAnswers_BFUsers_BFUserId",
                        column: x => x.BFUserId,
                        principalTable: "BFUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_QuestionAndAnswers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_QuestionAndAnswers_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variants_Products_ProductId",
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
                    { 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1230), "admin", false },
                    { 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1231), "member", false },
                    { 3, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1232), "customer representative", false },
                    { 4, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1232), "seller", false }
                });

            migrationBuilder.InsertData(
                table: "BFUsers",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "Password", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1322), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1324), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 3, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1325), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 4, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1326), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 5, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1326), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 6, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1327), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 7, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1328), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 8, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1328), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 9, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1329), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 10, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1329), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 11, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1330), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 12, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1331), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 13, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1331), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 14, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1353), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 15, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1354), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 16, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1355), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 17, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1356), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 18, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1356), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 19, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1357), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 20, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1357), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Definition", "ImportanceNumber", "IsDeleted", "NumberOfSales" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(165), "Elektronik", 0, false, 1111 },
                    { 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(167), "Giyim", 0, false, 1222 },
                    { 3, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(168), "Moda", 0, false, 1333 },
                    { 4, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(168), "Ev, Yaşam, Kırtasiye, Ofis", 0, false, 1444 },
                    { 5, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(169), "Beyaz Eşya", 0, false, 1555 },
                    { 6, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(169), "Oto, Bahçe, Yapı Market", 0, false, 1666 },
                    { 7, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(170), "Anne, Bebek, Oyuncak", 0, false, 1777 },
                    { 8, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(170), "Spor, Outdoor", 0, false, 1888 },
                    { 9, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(171), "Kozmetik, Kişisel Bakım", 0, false, 1999 },
                    { 10, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(171), "Süpermarket, Pet Shop", 0, false, 11110 }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Address", "CreatedDate", "IsApproved", "IsDeleted", "Logo", "Name", "Surname", "TcNo" },
                values: new object[,]
                {
                    { 1, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1909), false, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 2, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1911), true, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 3, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1913), false, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 4, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1913), true, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L }
                });

            migrationBuilder.InsertData(
                table: "BFUserRole",
                columns: new[] { "BFRoleId", "BFUserId", "CreatedDate", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1418), 0, false },
                    { 1, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1418), 0, false },
                    { 1, 3, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1419), 0, false },
                    { 1, 4, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1420), 0, false },
                    { 1, 5, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1420), 0, false },
                    { 2, 6, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1421), 0, false },
                    { 2, 7, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1421), 0, false },
                    { 2, 8, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1422), 0, false },
                    { 2, 9, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1422), 0, false },
                    { 2, 10, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1422), 0, false },
                    { 3, 11, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1423), 0, false },
                    { 3, 12, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1423), 0, false },
                    { 3, 13, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1424), 0, false },
                    { 3, 14, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1424), 0, false },
                    { 3, 15, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1425), 0, false },
                    { 4, 16, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1425), 0, false },
                    { 4, 17, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1426), 0, false },
                    { 4, 18, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1426), 0, false },
                    { 4, 19, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1427), 0, false },
                    { 4, 20, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1427), 0, false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImagePath", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9562), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 2, 2, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9577), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 3, 3, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9578), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 4, 4, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9578), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 5, 5, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9579), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 6, 6, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9579), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 7, 7, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9580), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 8, 8, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9580), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 9, 9, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9581), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 10, 10, new DateTime(2022, 8, 16, 16, 39, 55, 617, DateTimeKind.Local).AddTicks(9581), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(972), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, true, "İphone 4s", 10, 500, 0, 1500.0, 1, 5, "A58GH256A", 5000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(986), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "İphone 4s", 14, 500, 0, 2500.0, 1, 0, "A58GH256A", 5000.0 },
                    { 3, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(991), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Gömlek", 13, 500, 0, 3500.0, 1, 8, "A58GH256A", 5000.0 },
                    { 4, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(993), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 34, 500, 0, 4500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 5, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(995), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 76, 500, 0, 5500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 6, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(997), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 89, 500, 0, 6500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 7, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(998), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 67, 500, 0, 7500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 8, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1000), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedsds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 89, 500, 0, 8500.0, 1, 4, "A58GH256A", 5000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[] { 9, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1001), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, true, "Pantolon", 474, 500, 0, 9500.0, 1, 4, "A58GH256A", 5000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[,]
                {
                    { 10, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1004), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 67, 500, 0, 1500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 11, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1006), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 89, 500, 0, 11500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 12, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1008), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemesds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 12500.0, 2, 4, "A58GH256A", 5000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[,]
                {
                    { 13, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1010), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 13500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 14, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1011), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 14500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 15, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1013), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 15500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 16, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1014), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 10, 500, 0, 16500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 17, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1016), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 17500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 18, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1018), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 18500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 19, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1020), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 19500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 20, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1021), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemesds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 10, 500, 0, 20500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 21, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1023), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 22, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1024), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 23, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1046), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 24, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1048), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 25, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1051), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedsds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 26, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1053), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 27, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1054), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 28, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1056), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 29, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1057), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 30, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1059), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedsds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 31, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1060), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 32, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1063), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 33, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1064), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 34, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1066), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 35, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1067), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 36, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1069), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 37, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1070), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 38, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1071), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 39, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1073), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 40, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1074), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 4500.0, 4, 4, "A58GH256A", 5000.0 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BFUserId", "CreatedDate", "Description", "EvaluationPoint", "IsDeleted", "Mail", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2074), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 2, 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2076), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 3, 3, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2077), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 4, 4, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2077), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 5, 5, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2078), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 6, 6, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2079), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 7, 7, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2080), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 8, 8, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2080), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 9, 9, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2081), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 10, 10, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2082), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 11, 11, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2082), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 12, 12, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2083), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 13, 13, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2084), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 14, 14, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2085), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 15, 15, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2086), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 16, 16, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2110), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 17, 17, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2111), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 18, 18, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2111), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 19, 19, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2112), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 20, 20, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2113), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1492), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1494), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 3, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1495), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 4, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1495), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 5, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1496), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 6, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1496), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 7, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1497), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 8, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1498), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 9, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1498), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 10, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1499), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 11, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1499), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 12, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1500), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 2 },
                    { 13, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1500), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 3 },
                    { 14, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1501), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 4 },
                    { 15, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1501), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 5 },
                    { 16, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1503), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 6 },
                    { 17, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1503), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 7 },
                    { 18, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1504), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 8 },
                    { 19, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1504), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 9 },
                    { 20, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1506), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 10 },
                    { 21, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1506), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 11 },
                    { 22, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1507), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 12 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 23, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1507), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 13 },
                    { 24, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1508), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 14 },
                    { 25, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1508), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 15 },
                    { 26, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1509), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 16 },
                    { 27, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1509), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 17 },
                    { 28, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1510), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 18 },
                    { 29, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1510), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 19 },
                    { 30, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1511), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 20 },
                    { 31, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1512), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 21 },
                    { 32, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1513), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 22 },
                    { 33, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1514), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 23 },
                    { 34, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1514), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 24 },
                    { 35, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1515), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 25 },
                    { 36, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1515), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 26 },
                    { 37, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1516), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 27 },
                    { 38, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1516), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 28 },
                    { 39, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1517), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 29 },
                    { 40, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1517), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 30 },
                    { 41, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1518), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 31 },
                    { 42, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1518), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 32 },
                    { 43, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1520), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 33 },
                    { 44, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1520), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 34 },
                    { 45, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1521), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 35 },
                    { 46, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1521), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 36 },
                    { 47, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1522), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 37 },
                    { 48, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1522), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 38 },
                    { 49, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1523), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 39 },
                    { 50, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1524), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 40 },
                    { 51, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1524), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 1 },
                    { 52, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1525), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 2 },
                    { 53, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1525), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 3 },
                    { 54, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1526), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 4 },
                    { 55, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1526), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 5 },
                    { 56, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1527), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 6 },
                    { 57, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1527), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 7 },
                    { 58, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1528), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 8 },
                    { 59, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1529), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 9 },
                    { 60, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1529), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 10 },
                    { 61, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1530), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 1 },
                    { 62, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1531), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 2 },
                    { 63, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1532), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 3 },
                    { 64, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1532), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 65, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1533), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 5 },
                    { 66, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1533), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 6 },
                    { 67, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1534), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 7 },
                    { 68, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1534), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 8 },
                    { 69, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1568), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 9 },
                    { 70, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1569), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 10 },
                    { 71, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1570), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 11 },
                    { 72, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1570), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 12 },
                    { 73, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1572), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 13 },
                    { 74, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1572), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 14 },
                    { 75, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1573), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 15 },
                    { 76, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1573), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 16 },
                    { 77, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1574), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 17 },
                    { 78, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1574), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 18 },
                    { 79, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1575), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 19 },
                    { 80, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1575), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 20 },
                    { 81, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1576), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 21 },
                    { 82, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1576), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 22 },
                    { 83, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1577), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 23 },
                    { 84, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1578), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 24 },
                    { 85, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1578), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 25 },
                    { 86, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1579), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 26 },
                    { 87, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1579), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 27 },
                    { 88, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1580), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 28 },
                    { 89, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1580), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 29 },
                    { 90, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1581), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 30 },
                    { 91, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1581), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 31 },
                    { 92, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1582), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 32 },
                    { 93, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1582), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 33 },
                    { 94, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1583), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 34 },
                    { 95, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1583), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 35 },
                    { 96, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1584), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 36 },
                    { 97, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1585), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 37 },
                    { 98, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1585), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 38 },
                    { 99, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1586), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 39 },
                    { 100, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(1586), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 40 }
                });

            migrationBuilder.InsertData(
                table: "QuestionAndAnswers",
                columns: new[] { "Id", "Answer", "BFUserId", "CreatedDate", "IsDeleted", "ProductId", "Question", "ResponseTime", "SellerId" },
                values: new object[,]
                {
                    { 1, "deneme deneme deneme deneme ", 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2385), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 2, "deneme deneme deneme deneme ", 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2387), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 3, "deneme deneme deneme deneme ", 3, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2388), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 4, "deneme deneme deneme deneme ", 4, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2389), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 5, "deneme deneme deneme deneme ", 5, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2390), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 6, "deneme deneme deneme deneme ", 6, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2391), false, 1, "deneme deneme deneme ", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2164), "64GB", false, "Hafıza", 1 },
                    { 2, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2165), "64GB", false, "Hafıza", 1 },
                    { 3, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2166), "64GB", false, "Hafıza", 1 },
                    { 4, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2167), "64GB", false, "Hafıza", 1 },
                    { 5, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2167), "64GB", false, "Hafıza", 1 },
                    { 6, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2168), "64GB", false, "Renk", 1 },
                    { 7, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2168), "64GB", false, "Renk", 1 },
                    { 8, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2169), "64GB", false, "Renk", 1 },
                    { 9, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2170), "64GB", false, "Renk", 1 },
                    { 10, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2171), "64GB", false, "Renk", 1 },
                    { 11, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2172), "64GB", false, "Hafıza", 2 },
                    { 12, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2172), "64GB", false, "Hafıza", 2 },
                    { 13, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2173), "64GB", false, "Hafıza", 2 },
                    { 14, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2173), "64GB", false, "Hafıza", 2 },
                    { 15, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2174), "64GB", false, "Hafıza", 2 },
                    { 16, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2174), "64GB", false, "Hafıza", 2 },
                    { 17, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2178), "64GB", false, "Hafıza", 2 },
                    { 18, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2179), "64GB", false, "Hafıza", 2 },
                    { 19, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2179), "64GB", false, "Hafıza", 2 },
                    { 20, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2180), "64GB", false, "Hafıza", 3 },
                    { 21, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2181), "64GB", false, "Hafıza", 3 },
                    { 22, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2182), "64GB", false, "Hafıza", 3 },
                    { 23, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2182), "64GB", false, "Hafıza", 3 },
                    { 24, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2183), "64GB", false, "Hafıza", 3 },
                    { 25, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2184), "64GB", false, "Hafıza", 3 },
                    { 26, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2184), "64GB", false, "Hafıza", 3 },
                    { 27, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2185), "64GB", false, "Hafıza", 3 },
                    { 28, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2185), "64GB", false, "Hafıza", 3 },
                    { 29, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2186), "64GB", false, "Hafıza", 3 },
                    { 30, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2186), "64GB", false, "Hafıza", 4 },
                    { 31, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2187), "64GB", false, "Hafıza", 4 },
                    { 32, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2187), "64GB", false, "Hafıza", 4 },
                    { 33, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2188), "64GB", false, "Hafıza", 4 },
                    { 34, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2190), "64GB", false, "Hafıza", 4 },
                    { 35, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2190), "64GB", false, "Hafıza", 4 },
                    { 36, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2191), "64GB", false, "Hafıza", 4 },
                    { 37, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2192), "64GB", false, "Hafıza", 4 },
                    { 38, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2192), "64GB", false, "Hafıza", 4 },
                    { 39, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2193), "64GB", false, "Hafıza", 4 },
                    { 40, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2194), "64GB", false, "Hafıza", 5 },
                    { 41, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2195), "64GB", false, "Hafıza", 4 },
                    { 42, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2196), "64GB", false, "Hafıza", 4 }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "ProductId" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2196), "64GB", false, "Hafıza", 4 },
                    { 44, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2197), "64GB", false, "Hafıza", 4 },
                    { 45, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2197), "64GB", false, "Hafıza", 4 },
                    { 46, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2198), "64GB", false, "Hafıza", 4 },
                    { 47, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2199), "64GB", false, "Hafıza", 4 },
                    { 48, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2199), "64GB", false, "Hafıza", 4 },
                    { 49, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2200), "64GB", false, "Hafıza", 4 },
                    { 50, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2200), "64GB", false, "Hafıza", 5 },
                    { 51, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2201), "64GB", false, "Hafıza", 6 },
                    { 52, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2201), "64GB", false, "Hafıza", 6 },
                    { 53, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2202), "64GB", false, "Hafıza", 6 },
                    { 54, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2202), "64GB", false, "Hafıza", 6 },
                    { 55, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2203), "64GB", false, "Hafıza", 6 },
                    { 56, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2204), "64GB", false, "Hafıza", 6 },
                    { 57, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2204), "64GB", false, "Hafıza", 6 },
                    { 58, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2205), "64GB", false, "Hafıza", 6 },
                    { 59, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2205), "64GB", false, "Hafıza", 6 },
                    { 60, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2207), "64GB", false, "Hafıza", 7 },
                    { 61, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2207), "64GB", false, "Hafıza", 8 },
                    { 62, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2208), "64GB", false, "Hafıza", 8 },
                    { 63, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2208), "64GB", false, "Hafıza", 8 },
                    { 64, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2209), "64GB", false, "Hafıza", 8 },
                    { 65, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2210), "64GB", false, "Hafıza", 8 },
                    { 66, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2210), "64GB", false, "Hafıza", 8 },
                    { 67, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2211), "64GB", false, "Hafıza", 8 },
                    { 68, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2211), "64GB", false, "Hafıza", 8 },
                    { 69, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2212), "64GB", false, "Hafıza", 8 },
                    { 70, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2212), "64GB", false, "Hafıza", 8 },
                    { 71, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2213), "64GB", false, "Hafıza", 8 },
                    { 72, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2214), "64GB", false, "Hafıza", 8 },
                    { 73, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2214), "64GB", false, "Hafıza", 8 },
                    { 74, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2215), "64GB", false, "Hafıza", 8 },
                    { 75, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2215), "64GB", false, "Hafıza", 8 },
                    { 76, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2216), "64GB", false, "Hafıza", 8 },
                    { 77, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2216), "64GB", false, "Hafıza", 8 },
                    { 78, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2217), "64GB", false, "Hafıza", 8 },
                    { 79, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2217), "64GB", false, "Hafıza", 8 },
                    { 80, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2218), "64GB", false, "Hafıza", 9 },
                    { 81, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2219), "64GB", false, "Hafıza", 9 },
                    { 82, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2219), "64GB", false, "Hafıza", 9 },
                    { 83, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2220), "64GB", false, "Hafıza", 9 },
                    { 84, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2220), "64GB", false, "Hafıza", 9 }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "ProductId" },
                values: new object[,]
                {
                    { 85, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2221), "64GB", false, "Hafıza", 9 },
                    { 86, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2221), "64GB", false, "Hafıza", 9 },
                    { 87, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2222), "64GB", false, "Hafıza", 9 },
                    { 88, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2222), "64GB", false, "Hafıza", 9 },
                    { 89, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2223), "64GB", false, "Hafıza", 9 },
                    { 90, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2224), "64GB", false, "Hafıza", 9 },
                    { 91, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2224), "64GB", false, "Hafıza", 10 },
                    { 92, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2225), "64GB", false, "Hafıza", 10 },
                    { 93, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2225), "64GB", false, "Hafıza", 10 },
                    { 94, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2226), "64GB", false, "Hafıza", 10 },
                    { 95, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2226), "64GB", false, "Hafıza", 10 },
                    { 96, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2246), "64GB", false, "Hafıza", 10 },
                    { 97, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2247), "64GB", false, "Hafıza", 10 },
                    { 98, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2247), "64GB", false, "Hafıza", 10 },
                    { 99, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2248), "64GB", false, "Hafıza", 10 },
                    { 100, new DateTime(2022, 8, 16, 16, 39, 55, 618, DateTimeKind.Local).AddTicks(2249), "64GB", false, "Hafıza", 10 }
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
                name: "IX_Products_SellerId",
                table: "Products",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAndAnswers_BFUserId",
                table: "QuestionAndAnswers",
                column: "BFUserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAndAnswers_ProductId",
                table: "QuestionAndAnswers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAndAnswers_SellerId",
                table: "QuestionAndAnswers",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Variants_ProductId",
                table: "Variants",
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
                name: "QuestionAndAnswers");

            migrationBuilder.DropTable(
                name: "Variants");

            migrationBuilder.DropTable(
                name: "BFRoles");

            migrationBuilder.DropTable(
                name: "BFUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
