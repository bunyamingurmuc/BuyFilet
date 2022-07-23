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
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 22, 17, 50, 57, 414, DateTimeKind.Local).AddTicks(4240));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 41, 41, 970, DateTimeKind.Local).AddTicks(6227));
        }
    }
}
