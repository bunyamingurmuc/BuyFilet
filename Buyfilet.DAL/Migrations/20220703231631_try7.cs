using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class try7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7351), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7352), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7352), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7353), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7353), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7354), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7355), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7355), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7356), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7357), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7357), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7358), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7358), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7359), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7360), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7360), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7361), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7363), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7364), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7364), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7365), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7365), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7366), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7367), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7367), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7368), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7368), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7369), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7370), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7370), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7371), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7371), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7372), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7373), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7373), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7374), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7374), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7375), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7376), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7376), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7377), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7377), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 16, 30, 854, DateTimeKind.Local).AddTicks(6407));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1261), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1262), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1263), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1264), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1264), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1265), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1266), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1266), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1267), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1268), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1269), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1269), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1270), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1271), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1271), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1272), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1273), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1273), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1274), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1275), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1275), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1276), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1277), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1277), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1278), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1279), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1279), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1281), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1282), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1282), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1283), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1284), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1285), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1286), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1287), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1287), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1288), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1289), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1289), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1290), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1291), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1292), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(244));
        }
    }
}
