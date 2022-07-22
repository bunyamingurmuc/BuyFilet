using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class @try : Migration
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
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
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
                    IsHotProduct = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DiscountExpiresHour = table.Column<int>(type: "int", nullable: false),
                    NumberOfEvaluations = table.Column<int>(type: "int", nullable: false),
                    EvaluationPoint = table.Column<double>(type: "float", maxLength: 100, nullable: false),
                    Discount = table.Column<int>(type: "int", maxLength: 300, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    NumberOfSales = table.Column<int>(type: "int", nullable: false),
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
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    { 1, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(166), "admin", false },
                    { 2, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(170), "member", false }
                });

            migrationBuilder.InsertData(
                table: "BFUsers",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "Password", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(691), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 2, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(716), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 3, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(717), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Definition", "ImageId", "IsDeleted", "NumberOfSales" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7688), "Elektronik", 0, false, 1111 },
                    { 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7691), "Giyim", 0, false, 1222 },
                    { 3, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7692), "Moda", 0, false, 1333 },
                    { 4, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7693), "Ev, Yaşam, Kırtasiye, Ofis", 0, false, 1444 },
                    { 5, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7693), "Beyaz Eşya", 0, false, 1555 },
                    { 6, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7694), "Oto, Bahçe, Yapı Market", 0, false, 1666 },
                    { 7, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7694), "Anne, Bebek, Oyuncak", 0, false, 1777 },
                    { 8, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7695), "Spor, Outdoor", 0, false, 1888 },
                    { 9, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7696), "Kozmetik, Kişisel Bakım", 0, false, 1999 },
                    { 10, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(7697), "Süpermarket, Pet Shop", 0, false, 11110 }
                });

            migrationBuilder.InsertData(
                table: "BFUserRole",
                columns: new[] { "BFRoleId", "BFUserId", "CreatedDate", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(895), 0, false },
                    { 2, 1, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(896), 0, false },
                    { 2, 3, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(896), 0, false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImagePath", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6834), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 2, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6847), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 3, 3, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6848), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 4, 4, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6849), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 5, 5, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6850), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 6, 6, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6850), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 7, 7, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6851), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 8, 8, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6851), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 9, 9, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6852), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 10, 10, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(6853), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Discount", "DiscountExpiresHour", "EvaluationPoint", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfEvaluations", "NumberOfSales", "Stock" },
                values: new object[] { 1, 1, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9596), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, true, true, true, "İphone 4s", 500, 0, 5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Discount", "DiscountExpiresHour", "EvaluationPoint", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfEvaluations", "NumberOfSales", "Stock" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9613), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "İphone 4s", 500, 0, 0 },
                    { 3, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9614), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, true, true, "Gömlek", 500, 0, 8 },
                    { 4, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9616), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 5, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9619), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 6, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9620), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 7, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9621), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 8, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9626), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Discount", "DiscountExpiresHour", "EvaluationPoint", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfEvaluations", "NumberOfSales", "Stock" },
                values: new object[] { 9, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9627), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, true, true, true, "Pantolon", 500, 0, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Discount", "DiscountExpiresHour", "EvaluationPoint", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfEvaluations", "NumberOfSales", "Stock" },
                values: new object[,]
                {
                    { 10, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9628), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, true, true, "Pantolon", 500, 0, 4 },
                    { 11, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9630), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 12, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9633), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 13, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9634), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 14, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9635), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 15, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9639), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 16, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9640), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, true, true, "Pantolon", 500, 0, 4 },
                    { 17, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9641), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 18, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9644), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 19, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9646), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 20, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9647), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, true, true, "Pantolon", 500, 0, 4 },
                    { 21, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9648), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 22, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9649), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 23, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9650), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 24, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9651), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, true, true, "Pantolon", 500, 0, 4 },
                    { 25, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9652), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 26, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9653), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 27, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9654), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 28, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9655), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 29, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9658), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Discount", "DiscountExpiresHour", "EvaluationPoint", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfEvaluations", "NumberOfSales", "Stock" },
                values: new object[,]
                {
                    { 30, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9659), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 31, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9660), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 32, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9665), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 33, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9666), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, true, true, "Pantolon", 500, 0, 4 },
                    { 34, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9674), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 35, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9675), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 36, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9676), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 37, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9677), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 38, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9679), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 39, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9681), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 },
                    { 40, 2, new DateTime(2022, 7, 3, 23, 9, 17, 551, DateTimeKind.Local).AddTicks(9682), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme", 1000, 28, 40.0, false, false, true, "Pantolon", 500, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1714), "https://productimages.hepsiburada.net/s/189/550/110000155170579.jpg/format:webp", false, 1 },
                    { 2, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1716), "https://productimages.hepsiburada.net/s/189/550/110000155170580.jpg/format:webp", false, 1 },
                    { 3, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1717), "https://productimages.hepsiburada.net/s/189/550/110000155170581.jpg/format:webp", false, 1 },
                    { 4, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1718), "https://productimages.hepsiburada.net/s/189/550/110000155170582.jpg/format:webp", false, 1 },
                    { 5, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1719), "https://productimages.hepsiburada.net/s/189/550/110000155170583.jpg/format:webp", false, 1 },
                    { 6, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1719), "https://productimages.hepsiburada.net/s/189/550/110000155170584.jpg/format:webp", false, 1 },
                    { 7, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1720), "https://productimages.hepsiburada.net/s/189/550/110000155170585.jpg/format:webp", false, 1 },
                    { 8, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1720), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 1 },
                    { 9, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1721), "https://productimages.hepsiburada.net/s/189/550/110000155170587.jpg/format:webp", false, 9 },
                    { 10, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1722), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 1 },
                    { 11, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1722), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 1 },
                    { 12, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1723), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 2 },
                    { 13, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1724), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 3 },
                    { 14, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1724), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 4 },
                    { 15, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1725), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 5 },
                    { 16, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1725), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 6 },
                    { 17, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1726), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 7 },
                    { 18, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1727), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 8 },
                    { 19, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1727), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 9 },
                    { 20, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1728), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 10 },
                    { 21, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1729), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 11 },
                    { 22, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1729), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 12 },
                    { 23, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1730), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 13 },
                    { 24, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1730), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 14 },
                    { 25, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1731), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 15 },
                    { 26, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1732), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 16 },
                    { 27, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1732), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 17 },
                    { 28, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1733), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 18 },
                    { 29, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1734), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 19 },
                    { 30, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1734), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 20 },
                    { 31, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1735), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 21 },
                    { 32, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1735), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 22 },
                    { 33, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1736), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 23 },
                    { 34, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1737), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 24 },
                    { 35, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1737), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 25 },
                    { 36, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1738), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 26 },
                    { 37, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1739), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 27 },
                    { 38, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1739), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 28 },
                    { 39, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1779), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 29 },
                    { 40, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1782), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 30 },
                    { 41, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1784), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 31 },
                    { 42, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1785), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 32 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1785), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 33 },
                    { 44, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1786), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 34 },
                    { 45, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1787), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 35 },
                    { 46, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1788), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 36 },
                    { 47, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1788), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 37 },
                    { 48, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1789), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 38 },
                    { 49, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1791), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 39 },
                    { 50, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1792), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 40 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1344), "64 GB", false, "Hafıza", 10001.0, 1 },
                    { 2, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1354), "64 GB", false, "Hafıza", 10002.0, 2 },
                    { 3, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1355), "64 GB", false, "Hafıza", 10003.0, 3 },
                    { 4, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1356), "64 GB", false, "Hafıza", 10004.0, 4 },
                    { 5, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1356), "64 GB", false, "Hafıza", 10005.0, 5 },
                    { 6, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1357), "64 GB", false, "Hafıza", 10006.0, 6 },
                    { 7, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1358), "64 GB", false, "Hafıza", 10007.0, 7 },
                    { 8, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1362), "64 GB", false, "Hafıza", 10008.0, 8 },
                    { 9, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1364), "64 GB", false, "Hafıza", 10009.0, 9 },
                    { 10, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1365), "64 GB", false, "Hafıza", 100010.0, 10 },
                    { 11, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1366), "64 GB", false, "Hafıza", 100011.0, 11 },
                    { 12, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1367), "64 GB", false, "Hafıza", 100012.0, 12 },
                    { 13, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1368), "64 GB", false, "Hafıza", 100013.0, 13 },
                    { 14, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1372), "64 GB", false, "Hafıza", 100014.0, 14 },
                    { 15, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1372), "64 GB", false, "Hafıza", 100015.0, 15 },
                    { 16, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1377), "64 GB", false, "Hafıza", 100016.0, 16 },
                    { 17, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1379), "64 GB", false, "Hafıza", 100017.0, 17 },
                    { 18, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1379), "64 GB", false, "Hafıza", 100018.0, 18 },
                    { 19, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1380), "64 GB", false, "Hafıza", 100019.0, 19 },
                    { 20, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1381), "64 GB", false, "Hafıza", 100020.0, 20 },
                    { 21, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1382), "64 GB", false, "Hafıza", 10021.0, 21 },
                    { 22, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1382), "64 GB", false, "Hafıza", 10022.0, 22 },
                    { 23, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1383), "64 GB", false, "Hafıza", 10023.0, 23 },
                    { 24, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1388), "64 GB", false, "Hafıza", 10024.0, 24 },
                    { 25, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1389), "64 GB", false, "Hafıza", 10025.0, 25 },
                    { 26, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1390), "64 GB", false, "Hafıza", 10026.0, 26 },
                    { 27, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1391), "64 GB", false, "Hafıza", 10027.0, 27 },
                    { 28, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1392), "64 GB", false, "Hafıza", 10028.0, 28 },
                    { 29, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1393), "64 GB", false, "Hafıza", 10029.0, 29 },
                    { 30, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1394), "64 GB", false, "Hafıza", 10030.0, 30 },
                    { 31, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1396), "64 GB", false, "Hafıza", 1310.0, 31 },
                    { 32, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1396), "64 GB", false, "Hafıza", 1320.0, 32 },
                    { 33, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1397), "64 GB", false, "Hafıza", 1330.0, 33 },
                    { 34, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1398), "64 GB", false, "Hafıza", 1340.0, 34 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId" },
                values: new object[,]
                {
                    { 35, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1399), "64 GB", false, "Hafıza", 1350.0, 35 },
                    { 36, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1401), "64 GB", false, "Hafıza", 1360.0, 36 },
                    { 37, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1402), "64 GB", false, "Hafıza", 1370.0, 37 },
                    { 38, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1410), "64 GB", false, "Hafıza", 1380.0, 38 },
                    { 39, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1411), "64 GB", false, "Hafıza", 1390.0, 39 },
                    { 40, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1412), "64 GB", false, "Hafıza", 1400.0, 40 },
                    { 50, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1412), "64 GB", false, "Hafıza", 1050.0, 30 },
                    { 51, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1413), "64 GB", false, "Hafıza", 1050.0, 1 },
                    { 52, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1415), "64 GB", false, "Hafıza", 1050.0, 2 },
                    { 53, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1416), "64 GB", false, "Hafıza", 1050.0, 3 },
                    { 54, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1425), "64 GB", false, "Hafıza", 1050.0, 4 },
                    { 55, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1426), "64 GB", false, "Hafıza", 1050.0, 5 },
                    { 56, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1433), "64 GB", false, "Hafıza", 1050.0, 6 },
                    { 57, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1434), "64 GB", false, "Hafıza", 1050.0, 7 },
                    { 58, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1437), "64 GB", false, "Hafıza", 1050.0, 8 },
                    { 59, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1438), "64 GB", false, "Hafıza", 1050.0, 9 },
                    { 60, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1439), "64 GB", false, "Hafıza", 6000.0, 10 },
                    { 61, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1443), "64 GB", false, "Hafıza", 6100.0, 11 },
                    { 62, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1447), "64 GB", false, "Hafıza", 6200.0, 12 },
                    { 63, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1449), "64 GB", false, "Hafıza", 6300.0, 13 },
                    { 64, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1449), "64 GB", false, "Hafıza", 6400.0, 14 },
                    { 65, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1450), "64 GB", false, "Hafıza", 6500.0, 15 },
                    { 66, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1495), "64 GB", false, "Hafıza", 6600.0, 16 },
                    { 67, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1497), "64 GB", false, "Hafıza", 6700.0, 17 },
                    { 68, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1498), "64 GB", false, "Hafıza", 6800.0, 18 },
                    { 69, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1498), "64 GB", false, "Hafıza", 6900.0, 19 },
                    { 70, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1499), "64 GB", false, "Hafıza", 700.0, 20 },
                    { 71, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1500), "64 GB", false, "Hafıza", 710.0, 21 },
                    { 72, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1502), "64 GB", false, "Hafıza", 720.0, 22 },
                    { 73, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1503), "64 GB", false, "Hafıza", 730.0, 23 },
                    { 74, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1508), "64 GB", false, "Hafıza", 740.0, 24 },
                    { 75, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1508), "64 GB", false, "Hafıza", 750.0, 25 },
                    { 76, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1511), "64 GB", false, "Hafıza", 760.0, 26 },
                    { 77, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1511), "64 GB", false, "Hafıza", 770.0, 27 },
                    { 78, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1513), "64 GB", false, "Hafıza", 780.0, 28 },
                    { 79, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1514), "64 GB", false, "Hafıza", 790.0, 29 },
                    { 80, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1515), "64 GB", false, "Hafıza", 1088.0, 30 },
                    { 81, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1516), "64 GB", false, "Hafıza", 1188.0, 31 },
                    { 82, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1516), "64 GB", false, "Hafıza", 1288.0, 32 },
                    { 83, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1517), "64 GB", false, "Hafıza", 1388.0, 33 },
                    { 84, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1518), "64 GB", false, "Hafıza", 1488.0, 34 },
                    { 85, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1519), "64 GB", false, "Hafıza", 1588.0, 35 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted", "Name", "Price", "ProductId" },
                values: new object[,]
                {
                    { 86, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1519), "64 GB", false, "Hafıza", 1688.0, 36 },
                    { 87, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1520), "64 GB", false, "Hafıza", 1788.0, 37 },
                    { 88, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1521), "64 GB", false, "Hafıza", 1888.0, 38 },
                    { 89, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1522), "64 GB", false, "Hafıza", 1988.0, 39 },
                    { 90, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1523), "64 GB", false, "Hafıza", 1009.0, 30 },
                    { 91, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1523), "64 GB", false, "Hafıza", 1009.0, 1 },
                    { 92, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1524), "64 GB", false, "Hafıza", 1009.0, 2 },
                    { 93, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1525), "64 GB", false, "Hafıza", 1009.0, 3 },
                    { 94, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1526), "64 GB", false, "Hafıza", 1009.0, 4 },
                    { 95, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1526), "64 GB", false, "Hafıza", 1009.0, 5 },
                    { 96, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1527), "64 GB", false, "Hafıza", 1009.0, 6 },
                    { 97, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1528), "64 GB", false, "Hafıza", 1009.0, 7 },
                    { 98, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1529), "64 GB", false, "Hafıza", 1009.0, 8 },
                    { 99, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1529), "64 GB", false, "Hafıza", 1009.0, 9 },
                    { 100, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1530), "64 GB", false, "Hafıza", 10010.0, 10 },
                    { 111, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1531), "64 GB", false, "Hafıza", 10011.0, 11 },
                    { 122, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1531), "64 GB", false, "Hafıza", 10012.0, 12 },
                    { 133, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1532), "64 GB", false, "Hafıza", 10013.0, 13 },
                    { 144, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1533), "64 GB", false, "Hafıza", 10014.0, 14 },
                    { 155, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1534), "64 GB", false, "Hafıza", 10015.0, 15 },
                    { 166, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1534), "64 GB", false, "Hafıza", 10016.0, 16 },
                    { 177, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1535), "64 GB", false, "Hafıza", 10017.0, 17 },
                    { 188, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1536), "64 GB", false, "Hafıza", 10018.0, 18 },
                    { 199, new DateTime(2022, 7, 3, 23, 9, 17, 552, DateTimeKind.Local).AddTicks(1537), "64 GB", false, "Hafıza", 10019.0, 19 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BFUserRole_BFUserId",
                table: "BFUserRole",
                column: "BFUserId");

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
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariants",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BFUserRole");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "BFRoles");

            migrationBuilder.DropTable(
                name: "BFUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
