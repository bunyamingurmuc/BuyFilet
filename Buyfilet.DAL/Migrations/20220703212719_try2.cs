using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class try2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 51, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4136), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 1 },
                    { 52, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4137), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 2 },
                    { 53, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4137), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 3 },
                    { 54, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4138), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 4 },
                    { 55, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4139), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 5 },
                    { 56, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4139), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 57, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4141), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 7 },
                    { 58, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4142), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 8 },
                    { 59, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4143), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 9 },
                    { 60, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4143), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 10 },
                    { 61, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4144), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 1 },
                    { 62, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4181), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 2 },
                    { 63, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4183), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 3 },
                    { 64, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4184), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 4 },
                    { 65, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4184), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 5 },
                    { 66, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4185), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 6 },
                    { 67, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4186), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 7 },
                    { 68, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4186), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 8 },
                    { 69, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4187), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 9 },
                    { 70, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4187), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 10 },
                    { 71, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4189), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 11 },
                    { 72, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4189), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 12 },
                    { 73, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4190), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 13 },
                    { 74, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4191), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 14 },
                    { 75, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4191), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 15 },
                    { 76, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4192), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 16 },
                    { 77, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4192), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 17 },
                    { 78, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4193), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 18 },
                    { 79, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4194), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 19 },
                    { 80, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4194), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 20 },
                    { 81, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4196), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 21 },
                    { 82, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4197), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 22 },
                    { 83, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4198), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 23 },
                    { 84, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4198), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 24 },
                    { 85, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4199), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 25 },
                    { 86, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4200), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 26 },
                    { 87, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4201), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 27 },
                    { 88, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4202), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 28 },
                    { 89, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4203), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 29 },
                    { 90, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4203), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 30 },
                    { 91, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4204), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 31 },
                    { 92, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4205), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 32 },
                    { 93, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4205), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 33 },
                    { 94, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4206), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 34 },
                    { 95, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4206), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 35 },
                    { 96, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4207), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 36 },
                    { 97, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4208), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 37 },
                    { 98, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4208), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 38 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "IsDeleted", "ProductId" },
                values: new object[,]
                {
                    { 99, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4209), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 39 },
                    { 100, new DateTime(2022, 7, 4, 0, 27, 19, 152, DateTimeKind.Local).AddTicks(4210), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp", false, 40 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 3, 23, 56, 39, 852, DateTimeKind.Local).AddTicks(8234));
        }
    }
}
