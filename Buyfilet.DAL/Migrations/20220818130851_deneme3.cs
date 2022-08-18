using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class deneme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CargoDay",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 6 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 7 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 8 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 10 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 12 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 13 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 14 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 15 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 16 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 17 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 18 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 19 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 20 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CargoDay", "CreatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(8521));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CargoDay",
                table: "Products");

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

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 14, 50, 8, 696, DateTimeKind.Local).AddTicks(1356));

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
    }
}
