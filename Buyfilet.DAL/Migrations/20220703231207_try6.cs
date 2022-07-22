using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buyfilet.DAL.Migrations
{
    public partial class try6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "BFRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "BFUserRole",
                keyColumns: new[] { "BFRoleId", "BFUserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "BFUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 748, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1261), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1262), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1263), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1264), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1264), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1265), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1266), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1266), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1267), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1268), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1269), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1269), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1270), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1271), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1271), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1272), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1273), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1273), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1274), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1275), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1275), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1276), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1277), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1277), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1278), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1279), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1279), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1281), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1282), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1282), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1283), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1284), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1285), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1286), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1287), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1287), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1288), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1289), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1289), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1290), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1291), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1292), "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506ihr-hn019-amd-ryzen-5-4600h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001O8M9H?magaza=GTI%20Bili%C5%9Fim" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 2, 12, 6, 749, DateTimeKind.Local).AddTicks(244));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5084), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

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
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5085), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5085), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5086), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5087), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5087), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5088), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5089), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5090), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5090), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5091), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5092), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5093), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5094), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5095), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5096), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5096), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5097), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5097), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5098), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5099), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5099), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5100), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5101), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5101), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5102), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5103), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5104), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5105), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5106), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5106), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5107), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5107), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5108), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5109), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5109), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5110), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5110), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5111), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5112), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5113), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(5114), "https://productimages.hepsiburada.net/s/189/550/110000155170586.jpg/format:webp" });

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
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 1, 44, 58, 928, DateTimeKind.Local).AddTicks(4977));

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
    }
}
