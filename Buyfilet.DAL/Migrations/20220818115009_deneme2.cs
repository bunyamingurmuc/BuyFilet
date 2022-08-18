using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class deneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 6 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 7 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 8 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 10 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 12 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 13 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 14 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 15 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 16 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 17 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 18 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 19 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 20 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "CommentId", "CreatedDate", "ImagePath", "IsDeleted" },
                values: new object[,]
                {
                    { 21, null, 1, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1310), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 22, null, 2, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1310), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 23, null, 3, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1311), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 24, null, 4, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1312), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 25, null, 5, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1312), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 26, null, 6, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1313), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 27, null, 7, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1313), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 28, null, 8, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1314), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 29, null, 9, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1314), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 30, null, 10, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1315), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 31, null, 11, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1316), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 32, null, 12, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1316), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 33, null, 13, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1317), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 34, null, 14, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1318), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 35, null, 15, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1318), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 36, null, 16, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1320), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 37, null, 17, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1321), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 38, null, 18, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1321), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 39, null, 19, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1322), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 40, null, 20, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1322), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 41, null, 11, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1323), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 42, null, 12, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1324), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 43, null, 13, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1324), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 44, null, 14, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1325), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 45, null, 15, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1325), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 46, null, 16, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1326), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 47, null, 17, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1353), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 48, null, 18, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1353), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 49, null, 19, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1355), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false },
                    { 50, null, 20, new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1356), "https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", false }
                });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(4697));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 6 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 7 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 8 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 10 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 12 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 13 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 14 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 15 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 16 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 17 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 18 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 19 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 20 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 13, 50, 6, 994, DateTimeKind.Local).AddTicks(6763));
        }
    }
}
