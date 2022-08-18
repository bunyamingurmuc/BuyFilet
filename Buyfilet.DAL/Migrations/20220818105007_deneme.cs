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
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BFRoles",
                columns: new[] { "Id", "CreatedDate", "Definition", "IsDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5683), "admin", false },
                    { 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5685), "member", false },
                    { 3, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5686), "customer representative", false },
                    { 4, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5687), "seller", false }
                });

            migrationBuilder.InsertData(
                table: "BFUsers",
                columns: new[] { "Id", "AvatarUrl", "CreatedDate", "IsDeleted", "Name", "Password", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5796), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 2, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5798), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 3, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5799), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 4, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5800), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 5, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5801), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 6, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5801), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 7, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5802), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 8, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5803), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 9, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5803), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 10, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5804), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 11, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5805), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 12, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5805), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 13, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5806), false, "Mahmut", "1", "gürmüç", "mahmutgurmuc" },
                    { 14, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5807), false, "veysel", "1", "gürmüç", "veyselgurmuc" },
                    { 15, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5807), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 16, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5808), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 17, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5809), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 18, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5809), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 19, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5810), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" },
                    { 20, "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5811), false, "Ahmet", "1", "gürmüç", "ahmetgurmuc" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Definition", "ImportanceNumber", "IsDeleted", "NumberOfSales" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4536), "Elektronik", 0, false, 1111 },
                    { 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4539), "Giyim", 0, false, 1222 },
                    { 3, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4540), "Moda", 0, false, 1333 },
                    { 4, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4541), "Ev, Yaşam, Kırtasiye, Ofis", 0, false, 1444 },
                    { 5, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4541), "Beyaz Eşya", 0, false, 1555 },
                    { 6, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4542), "Oto, Bahçe, Yapı Market", 0, false, 1666 },
                    { 7, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4542), "Anne, Bebek, Oyuncak", 0, false, 1777 },
                    { 8, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4543), "Spor, Outdoor", 0, false, 1888 },
                    { 9, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4543), "Kozmetik, Kişisel Bakım", 0, false, 1999 },
                    { 10, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4544), "Süpermarket, Pet Shop", 0, false, 11110 }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Address", "CreatedDate", "IsApproved", "IsDeleted", "Logo", "Name", "Surname", "TcNo" },
                values: new object[,]
                {
                    { 1, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6406), false, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 2, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6408), true, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 3, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6409), false, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L },
                    { 4, "deneme deneme deneme deneme deneme deneme ", new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6410), true, false, "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", "deneme deneme ", "deneme ", 26588331534L }
                });

            migrationBuilder.InsertData(
                table: "BFUserRole",
                columns: new[] { "BFRoleId", "BFUserId", "CreatedDate", "Id", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5891), 0, false },
                    { 1, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5892), 0, false },
                    { 1, 3, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5892), 0, false },
                    { 1, 4, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5893), 0, false },
                    { 1, 5, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5893), 0, false },
                    { 2, 6, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5894), 0, false },
                    { 2, 7, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5894), 0, false },
                    { 2, 8, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5895), 0, false },
                    { 2, 9, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5895), 0, false },
                    { 2, 10, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5896), 0, false },
                    { 3, 11, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5896), 0, false },
                    { 3, 12, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5897), 0, false },
                    { 3, 13, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5897), 0, false },
                    { 3, 14, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5898), 0, false },
                    { 3, 15, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5898), 0, false },
                    { 4, 16, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5899), 0, false },
                    { 4, 17, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5899), 0, false },
                    { 4, 18, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5900), 0, false },
                    { 4, 19, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5900), 0, false },
                    { 4, 20, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5901), 0, false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "CommentId", "CreatedDate", "ImagePath", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4004), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 2, 2, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4019), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 3, 3, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4020), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 4, 4, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4021), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 5, 5, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4021), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 6, 6, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4022), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 7, 7, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4022), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 8, 8, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4023), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 9, 9, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4023), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false },
                    { 10, 10, null, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4024), "https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5439), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, true, "İphone 4s", 10, 500, 0, 1500.0, 1, 5, "A58GH256A", 5000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5449), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "İphone 4s", 14, 500, 0, 2500.0, 1, 0, "A58GH256A", 5000.0 },
                    { 3, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5452), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Gömlek", 13, 500, 0, 3500.0, 1, 8, "A58GH256A", 5000.0 },
                    { 4, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5453), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 34, 500, 0, 4500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 5, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5455), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 76, 500, 0, 5500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 6, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5456), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 89, 500, 0, 6500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 7, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5458), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 67, 500, 0, 7500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 8, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5460), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedsds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 89, 500, 0, 8500.0, 1, 4, "A58GH256A", 5000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "IsHotProduct", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[] { 9, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5462), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, true, "Pantolon", 474, 500, 0, 9500.0, 1, 4, "A58GH256A", 5000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[,]
                {
                    { 10, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5463), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 67, 500, 0, 1500.0, 1, 4, "A58GH256A", 5000.0 },
                    { 11, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5465), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 89, 500, 0, 11500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 12, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5466), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemesds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 12500.0, 2, 4, "A58GH256A", 5000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Desfinition", "Detail1", "Detail2", "Detail3", "Discount", "DiscountExpiresHour", "DiscountRate", "EvaluationPoint", "FreeCargo", "IsDeleted", "IsDiscount", "IsHome", "Name", "NumberOfClick", "NumberOfEvaluations", "NumberOfSales", "Price", "SellerId", "Stock", "StockCode", "WithOutDiscount" },
                values: new object[,]
                {
                    { 13, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5468), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 13500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 14, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5469), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 14500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 15, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5472), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 15500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 16, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5473), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 10, 500, 0, 16500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 17, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5475), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 17500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 18, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5476), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 18500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 19, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5478), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 19500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 20, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5479), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemesds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 10, 500, 0, 20500.0, 2, 4, "A58GH256A", 5000.0 },
                    { 21, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5481), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 22, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5483), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 23, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5485), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 24, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5486), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 25, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5488), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedsds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 26, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5489), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 27, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5491), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 28, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5515), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 29, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5518), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 2500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 30, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5519), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedeneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme denemedsds", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 3, 4, "A58GH256A", 5000.0 },
                    { 31, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5521), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 32, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5522), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 33, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5524), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, true, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 34, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5525), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 35, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5527), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 36, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5528), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 37, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5529), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 38, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5531), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 39, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5533), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 3500.0, 4, 4, "A58GH256A", 5000.0 },
                    { 40, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5534), "https://images.hepsiburada.net/assets/Telefon/ProductDesc/13promarketing.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", "Mauris sed sagittis sapien, at mattis purus", 1000, 28, 50, 40.0, true, false, false, true, "Pantolon", 10, 500, 0, 4500.0, 4, 4, "A58GH256A", 5000.0 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BFUserId", "CreatedDate", "Description", "EvaluationPoint", "IsDeleted", "Mail", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6585), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 2, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6587), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 3, 3, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6588), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 4, 4, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6589), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 5, 5, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6590), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 6, 6, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6590), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 7, 7, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6591), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 8, 8, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6592), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 9, 9, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6593), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 },
                    { 10, 10, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6593), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 11, 11, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6594), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 12, 12, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6595), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 13, 13, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6596), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 14, 14, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6599), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 15, 15, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6600), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 16, 16, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6601), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 17, 17, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6602), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 18, 18, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6602), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 19, 19, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6603), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 2 },
                    { 20, 20, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6604), "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", 50, false, "mahmutgurmuc@gmail.com", "Mahmut", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5967), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5969), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 3, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5970), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 4, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5970), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 5, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5971), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 6, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5971), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 7, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5972), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 8, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5973), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 9, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5973), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", false, 1 },
                    { 10, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5974), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 11, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5974), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 1 },
                    { 12, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5975), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 2 },
                    { 13, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5975), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 3 },
                    { 14, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5976), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 4 },
                    { 15, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5976), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 5 },
                    { 16, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5977), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 6 },
                    { 17, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5978), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 7 },
                    { 18, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5978), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 8 },
                    { 19, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5979), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 9 },
                    { 20, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5979), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 10 },
                    { 21, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5980), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 11 },
                    { 22, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5980), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 12 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 23, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5981), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 13 },
                    { 24, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5981), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 14 },
                    { 25, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5982), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 15 },
                    { 26, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5982), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 16 },
                    { 27, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5983), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 17 },
                    { 28, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5984), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 18 },
                    { 29, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5984), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 19 },
                    { 30, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5985), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 20 },
                    { 31, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5985), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 21 },
                    { 32, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5987), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 22 },
                    { 33, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5987), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 23 },
                    { 34, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5988), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 24 },
                    { 35, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5988), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 25 },
                    { 36, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5989), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 26 },
                    { 37, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5989), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 27 },
                    { 38, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5990), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 28 },
                    { 39, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5990), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 29 },
                    { 40, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5991), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 30 },
                    { 41, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5992), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 31 },
                    { 42, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5992), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 32 },
                    { 43, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5993), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 33 },
                    { 44, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5993), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 34 },
                    { 45, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5994), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 35 },
                    { 46, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5994), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 36 },
                    { 47, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5995), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 37 },
                    { 48, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5995), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 38 },
                    { 49, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5996), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 39 },
                    { 50, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5996), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", false, 40 },
                    { 51, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5997), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 1 },
                    { 52, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5997), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 2 },
                    { 53, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5998), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 3 },
                    { 54, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5999), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 4 },
                    { 55, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5999), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 5 },
                    { 56, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6000), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 6 },
                    { 57, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6000), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 7 },
                    { 58, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6001), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 8 },
                    { 59, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6002), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 9 },
                    { 60, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6002), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 10 },
                    { 61, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6003), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 1 },
                    { 62, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6004), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 2 },
                    { 63, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6005), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 3 },
                    { 64, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6005), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 65, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6006), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 5 },
                    { 66, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6006), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 6 },
                    { 67, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6007), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 7 },
                    { 68, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6007), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 8 },
                    { 69, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6008), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 9 },
                    { 70, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6009), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 10 },
                    { 71, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6009), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 11 },
                    { 72, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6010), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 12 },
                    { 73, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6010), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 13 },
                    { 74, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6011), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 14 },
                    { 75, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6011), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 15 },
                    { 76, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6012), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 16 },
                    { 77, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6012), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 17 },
                    { 78, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6013), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 18 },
                    { 79, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6013), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 19 },
                    { 80, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6014), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 20 },
                    { 81, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6015), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 21 },
                    { 82, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6036), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 22 },
                    { 83, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6037), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 23 },
                    { 84, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6038), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 24 },
                    { 85, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6038), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 25 },
                    { 86, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6039), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 26 },
                    { 87, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6039), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 27 },
                    { 88, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6040), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 28 },
                    { 89, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6041), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 29 },
                    { 90, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6041), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 30 },
                    { 91, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6042), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 31 },
                    { 92, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6042), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 32 },
                    { 93, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6043), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 33 },
                    { 94, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6043), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 34 },
                    { 95, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6044), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 35 },
                    { 96, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6044), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 36 },
                    { 97, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6045), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 37 },
                    { 98, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6045), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 38 },
                    { 99, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6046), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 39 },
                    { 100, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6047), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", false, 40 }
                });

            migrationBuilder.InsertData(
                table: "QuestionAndAnswers",
                columns: new[] { "Id", "Answer", "BFUserId", "CreatedDate", "IsDeleted", "ProductId", "Question", "ResponseTime", "SellerId" },
                values: new object[,]
                {
                    { 1, "deneme deneme deneme deneme ", 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6943), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 2, "deneme deneme deneme deneme ", 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6945), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 3, "deneme deneme deneme deneme ", 3, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6946), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 4, "deneme deneme deneme deneme ", 4, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6947), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 5, "deneme deneme deneme deneme ", 5, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6948), false, 1, "deneme deneme deneme ", 1, 1 },
                    { 6, "deneme deneme deneme deneme ", 6, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6949), false, 1, "deneme deneme deneme ", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6697), "64GB", false, "Hafıza", 1 },
                    { 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6699), "64GB", false, "Hafıza", 1 },
                    { 3, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6700), "64GB", false, "Hafıza", 1 },
                    { 4, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6700), "64GB", false, "Hafıza", 1 },
                    { 5, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6701), "64GB", false, "Hafıza", 1 },
                    { 6, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6701), "64GB", false, "Renk", 1 },
                    { 7, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6702), "64GB", false, "Renk", 1 },
                    { 8, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6703), "64GB", false, "Renk", 1 },
                    { 9, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6703), "64GB", false, "Renk", 1 },
                    { 10, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6704), "64GB", false, "Renk", 1 },
                    { 11, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6705), "64GB", false, "Hafıza", 2 },
                    { 12, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6705), "64GB", false, "Hafıza", 2 },
                    { 13, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6706), "64GB", false, "Hafıza", 2 },
                    { 14, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6706), "64GB", false, "Hafıza", 2 },
                    { 15, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6707), "64GB", false, "Hafıza", 2 },
                    { 16, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6708), "64GB", false, "Hafıza", 2 },
                    { 17, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6708), "64GB", false, "Hafıza", 2 },
                    { 18, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6709), "64GB", false, "Hafıza", 2 },
                    { 19, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6709), "64GB", false, "Hafıza", 2 },
                    { 20, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6710), "64GB", false, "Hafıza", 3 },
                    { 21, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6711), "64GB", false, "Hafıza", 3 },
                    { 22, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6711), "64GB", false, "Hafıza", 3 },
                    { 23, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6712), "64GB", false, "Hafıza", 3 },
                    { 24, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6712), "64GB", false, "Hafıza", 3 },
                    { 25, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6713), "64GB", false, "Hafıza", 3 },
                    { 26, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6714), "64GB", false, "Hafıza", 3 },
                    { 27, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6714), "64GB", false, "Hafıza", 3 },
                    { 28, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6715), "64GB", false, "Hafıza", 3 },
                    { 29, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6715), "64GB", false, "Hafıza", 3 },
                    { 30, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6716), "64GB", false, "Hafıza", 4 },
                    { 31, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6717), "64GB", false, "Hafıza", 4 },
                    { 32, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6717), "64GB", false, "Hafıza", 4 },
                    { 33, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6718), "64GB", false, "Hafıza", 4 },
                    { 34, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6719), "64GB", false, "Hafıza", 4 },
                    { 35, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6720), "64GB", false, "Hafıza", 4 },
                    { 36, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6720), "64GB", false, "Hafıza", 4 },
                    { 37, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6721), "64GB", false, "Hafıza", 4 },
                    { 38, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6722), "64GB", false, "Hafıza", 4 },
                    { 39, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6722), "64GB", false, "Hafıza", 4 },
                    { 40, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6723), "64GB", false, "Hafıza", 5 },
                    { 41, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6724), "64GB", false, "Hafıza", 4 },
                    { 42, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6724), "64GB", false, "Hafıza", 4 }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "ProductId" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6725), "64GB", false, "Hafıza", 4 },
                    { 44, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6725), "64GB", false, "Hafıza", 4 },
                    { 45, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6726), "64GB", false, "Hafıza", 4 },
                    { 46, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6727), "64GB", false, "Hafıza", 4 },
                    { 47, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6727), "64GB", false, "Hafıza", 4 },
                    { 48, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6728), "64GB", false, "Hafıza", 4 },
                    { 49, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6728), "64GB", false, "Hafıza", 4 },
                    { 50, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6729), "64GB", false, "Hafıza", 5 },
                    { 51, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6730), "64GB", false, "Hafıza", 6 },
                    { 52, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6730), "64GB", false, "Hafıza", 6 },
                    { 53, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6731), "64GB", false, "Hafıza", 6 },
                    { 54, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6731), "64GB", false, "Hafıza", 6 },
                    { 55, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6732), "64GB", false, "Hafıza", 6 },
                    { 56, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6733), "64GB", false, "Hafıza", 6 },
                    { 57, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6733), "64GB", false, "Hafıza", 6 },
                    { 58, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6734), "64GB", false, "Hafıza", 6 },
                    { 59, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6734), "64GB", false, "Hafıza", 6 },
                    { 60, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6736), "64GB", false, "Hafıza", 7 },
                    { 61, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6737), "64GB", false, "Hafıza", 8 },
                    { 62, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6737), "64GB", false, "Hafıza", 8 },
                    { 63, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6738), "64GB", false, "Hafıza", 8 },
                    { 64, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6738), "64GB", false, "Hafıza", 8 },
                    { 65, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6739), "64GB", false, "Hafıza", 8 },
                    { 66, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6740), "64GB", false, "Hafıza", 8 },
                    { 67, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6740), "64GB", false, "Hafıza", 8 },
                    { 68, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6741), "64GB", false, "Hafıza", 8 },
                    { 69, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6741), "64GB", false, "Hafıza", 8 },
                    { 70, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6742), "64GB", false, "Hafıza", 8 },
                    { 71, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6743), "64GB", false, "Hafıza", 8 },
                    { 72, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6743), "64GB", false, "Hafıza", 8 },
                    { 73, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6744), "64GB", false, "Hafıza", 8 },
                    { 74, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6744), "64GB", false, "Hafıza", 8 },
                    { 75, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6745), "64GB", false, "Hafıza", 8 },
                    { 76, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6746), "64GB", false, "Hafıza", 8 },
                    { 77, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6746), "64GB", false, "Hafıza", 8 },
                    { 78, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6747), "64GB", false, "Hafıza", 8 },
                    { 79, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6747), "64GB", false, "Hafıza", 8 },
                    { 80, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6748), "64GB", false, "Hafıza", 9 },
                    { 81, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6749), "64GB", false, "Hafıza", 9 },
                    { 82, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6749), "64GB", false, "Hafıza", 9 },
                    { 83, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6750), "64GB", false, "Hafıza", 9 },
                    { 84, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6750), "64GB", false, "Hafıza", 9 }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "ProductId" },
                values: new object[,]
                {
                    { 85, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6751), "64GB", false, "Hafıza", 9 },
                    { 86, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6754), "64GB", false, "Hafıza", 9 },
                    { 87, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6755), "64GB", false, "Hafıza", 9 },
                    { 88, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6755), "64GB", false, "Hafıza", 9 },
                    { 89, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6756), "64GB", false, "Hafıza", 9 },
                    { 90, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6757), "64GB", false, "Hafıza", 9 },
                    { 91, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6757), "64GB", false, "Hafıza", 10 },
                    { 92, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6758), "64GB", false, "Hafıza", 10 },
                    { 93, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6758), "64GB", false, "Hafıza", 10 },
                    { 94, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6759), "64GB", false, "Hafıza", 10 },
                    { 95, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6760), "64GB", false, "Hafıza", 10 },
                    { 96, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6760), "64GB", false, "Hafıza", 10 },
                    { 97, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6761), "64GB", false, "Hafıza", 10 },
                    { 98, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6761), "64GB", false, "Hafıza", 10 },
                    { 99, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6762), "64GB", false, "Hafıza", 10 },
                    { 100, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6763), "64GB", false, "Hafıza", 10 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "CommentId", "CreatedDate", "ImagePath", "IsDeleted" },
                values: new object[,]
                {
                    { 11, null, 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4025), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 12, null, 1, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4025), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 13, null, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4026), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 14, null, 2, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4026), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 15, null, 3, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4027), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 16, null, 3, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4027), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 17, null, 4, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4028), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 18, null, 4, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4029), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 19, null, 5, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4029), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 20, null, 5, new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4030), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false }
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
                name: "IX_Images_CommentId",
                table: "Images",
                column: "CommentId");

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
                name: "Comments");

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
