using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class deneme32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BFMoney",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 6 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 7 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 8 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 10 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 12 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 13 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 14 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 15 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 16 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 17 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 18 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 19 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 20 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 60, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BFMoney", "CreatedDate" },
                values: new object[] { 15.32, new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "QuestionAndAnswers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 17, 57, 61, DateTimeKind.Local).AddTicks(1388));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BFMoney",
                table: "Products");

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
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 18, 16, 8, 51, 69, DateTimeKind.Local).AddTicks(7329));

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
    }
}
