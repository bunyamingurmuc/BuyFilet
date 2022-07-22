using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class try3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 75, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1471), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1471), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1472), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1473), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1473), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1474), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1475), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1476), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1476), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1477), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1477), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1478), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1479), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1479), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1480), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1480), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1481), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1482), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1482), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1483), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1484), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1484), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1485), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1485), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1486), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1487), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1487), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1488), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1488), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1489), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1490), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1490), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1491), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1491), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1526), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1527), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1527), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1528), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1529), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1530), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1530), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1532), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1532), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1533), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1533), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1534), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1535), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1535), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1536), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1536), "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(549));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4136), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4137), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4137), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4138), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4139), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4139), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4141), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4142), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4143), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4143), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4144), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4181), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4183), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4184), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4184), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4185), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4186), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4186), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4187), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4187), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4189), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4189), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4190), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4191), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4191), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4192), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4192), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4193), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4194), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4194), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4196), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4197), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4198), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4198), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4199), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4200), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4201), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4202), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4203), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4203), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4204), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4205), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4205), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4206), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4206), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4207), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4208), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4208), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4209), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4210), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(3203));
        }
    }
}
