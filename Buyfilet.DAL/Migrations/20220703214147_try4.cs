using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class try4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountRate",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 643, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(76), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(85), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(87), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(88), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(91), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(92), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(95), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(97), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(98), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(99), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(101), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(102), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(103), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(104), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(106), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(107), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(108), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(109), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(110), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(114), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(115), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(116), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(118), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(119), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(120), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(122), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(123), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(124), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(126), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(127), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(128), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(129), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(131), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(132), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(133), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(134), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(135), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(137), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(138), 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "DiscountRate" },
                values: new object[] { new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(139), 50 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountRate",
                table: "Products");

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
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 31, 25, 76, DateTimeKind.Local).AddTicks(1536));

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
    }
}
