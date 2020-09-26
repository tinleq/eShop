using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b109dff-37dc-4569-b1cf-94a48cf2edc3"),
                column: "ConcurrencyStamp",
                value: "97655340-8e52-44a7-98a9-a5ec01181dba");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a621de9b-681f-4424-8d97-517a3b8869e5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2174a5d-bb54-4251-9842-9d8b29215321", "AQAAAAEAACcQAAAAEACE71tFt8Jx8WDTi3/Xn2sz3nEcvvwPGCgYX/H70CVZQAalHUFIaZFqkqdYlyBBEA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 26, 12, 41, 2, 562, DateTimeKind.Local).AddTicks(8547));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b109dff-37dc-4569-b1cf-94a48cf2edc3"),
                column: "ConcurrencyStamp",
                value: "0a348843-0e71-47a6-885b-ff52f62f2c43");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a621de9b-681f-4424-8d97-517a3b8869e5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed8ff66a-2240-40d0-b897-009192885ff3", "AQAAAAEAACcQAAAAEK03LJUS9g6rxAXLHcjTY6+HH9TUNUMrZI8HvpLhComiTD2unisEdPfphuqgJWMRjw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 26, 9, 16, 45, 640, DateTimeKind.Local).AddTicks(4290));
        }
    }
}
