using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class deneme21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSeller");

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 6 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 7 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 8 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 10 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 12 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 13 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 14 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 15 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 16 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 17 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 18 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 19 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 20 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 11, 30, 15, 997, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellerId",
                table: "Products",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sellers_SellerId",
                table: "Products",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sellers_SellerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SellerId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductSeller",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    SellersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSeller", x => new { x.ProductsId, x.SellersId });
                    table.ForeignKey(
                        name: "FK_ProductSeller_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSeller_Sellers_SellersId",
                        column: x => x.SellersId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 6 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 7 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 8 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 9 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 10 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 12 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 13 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 14 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 3, 15 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 16 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 17 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 18 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 19 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 4, 20 },
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 9, 53, 12, 757, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.CreateIndex(
                name: "IX_ProductSeller_SellersId",
                table: "ProductSeller",
                column: "SellersId");
        }
    }
}
