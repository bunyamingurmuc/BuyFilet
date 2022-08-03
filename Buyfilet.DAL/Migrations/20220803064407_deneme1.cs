using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 6 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 7 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 8 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 10 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 12 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 13 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 14 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 15 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 16 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 17 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 18 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 19 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 20 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 777, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1485), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1486), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1487), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1488), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1488), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1489), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1489), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1490), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImagePath", "ProductId" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1491), "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", 1 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 44, 6, 778, DateTimeKind.Local).AddTicks(2498));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 6 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 7 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 8 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 10 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 12 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 13 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 14 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 15 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 16 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 17 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 18 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 19 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 20 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4833), "https://productimages.hepsiburada.net/s/189/550/110000155170579.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4835), "https://productimages.hepsiburada.net/s/189/550/110000155170580.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4836), "https://productimages.hepsiburada.net/s/189/550/110000155170581.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4836), "https://productimages.hepsiburada.net/s/189/550/110000155170582.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4837), "https://productimages.hepsiburada.net/s/189/550/110000155170583.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4838), "https://productimages.hepsiburada.net/s/189/550/110000155170584.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4838), "https://productimages.hepsiburada.net/s/189/550/110000155170585.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4839), "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImagePath", "ProductId" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4840), "https://productimages.hepsiburada.net/s/189/550/110000155170587.jpg/format:webp", 9 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 2, 14, 45, 18, 414, DateTimeKind.Local).AddTicks(5930));
        }
    }
}
