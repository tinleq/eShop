using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 25, 15, 45, 32, 826, DateTimeKind.Local).AddTicks(4971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 9, 25, 14, 34, 51, 760, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("3b109dff-37dc-4569-b1cf-94a48cf2edc3"), "92e512c5-2a36-4f51-afee-df4fdc9853a6", "Adminstrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a621de9b-681f-4424-8d97-517a3b8869e5"), new Guid("3b109dff-37dc-4569-b1cf-94a48cf2edc3") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a621de9b-681f-4424-8d97-517a3b8869e5"), 0, "0d99c59f-fbfe-40c8-b831-327dde56e77e", new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "tinleq95@gmail.com", true, "Tin", "Le", false, null, "tinleq95@gmail.com", "admin", "AQAAAAEAACcQAAAAEDUtZH6+Xp8Iy9qlwRcu2dEqvp2oRsHTErBOTA+iAmglyVwzNdMiMmmS4ZgLa1T0Aw==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 9, 25, 15, 45, 32, 841, DateTimeKind.Local).AddTicks(9336));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b109dff-37dc-4569-b1cf-94a48cf2edc3"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a621de9b-681f-4424-8d97-517a3b8869e5"), new Guid("3b109dff-37dc-4569-b1cf-94a48cf2edc3") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a621de9b-681f-4424-8d97-517a3b8869e5"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 25, 14, 34, 51, 760, DateTimeKind.Local).AddTicks(8494),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 9, 25, 15, 45, 32, 826, DateTimeKind.Local).AddTicks(4971));

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
                value: new DateTime(2020, 9, 25, 14, 34, 51, 834, DateTimeKind.Local).AddTicks(3403));
        }
    }
}
