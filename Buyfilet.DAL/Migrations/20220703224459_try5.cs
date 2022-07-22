using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class try5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "WithOutDiscount",
                table: "ProductVariants",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4842), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4846), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4847), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4848), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4849), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4851), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4853), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4854), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4855), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4856), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4857), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4858), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4859), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4860), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4861), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4862), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4863), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4865), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4866), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4866), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4867), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4868), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4870), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4871), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4872), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4873), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4873), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4874), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4875), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4876), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4876), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4877), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4878), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4878), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4879), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4881), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4881), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4882), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4883), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4884), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4884), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4885), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4886), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4887), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4887), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4888), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4889), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4890), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4890), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4891), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4892), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4893), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4893), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4894), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4896), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4896), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4897), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4898), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4898), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4899), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4900), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4901), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4901), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4902), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4903), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4904), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4904), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4905), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4906), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4907), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4910), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4911), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4911), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4948), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4949), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4950), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4951), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4952), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4953), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4954), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4955), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4957), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4957), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4958), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4960), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4960), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4961), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4963), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4964), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4966), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4967), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4968), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4969), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4971), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4971), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4972), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4973), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4975), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4976), 50000.0 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "WithOutDiscount" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4977), 50000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4199));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WithOutDiscount",
                table: "ProductVariants");

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
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 0, 41, 46, 644, DateTimeKind.Local).AddTicks(139));
        }
    }
}
