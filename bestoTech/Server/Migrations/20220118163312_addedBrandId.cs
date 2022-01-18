using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bestoTech.Server.Migrations
{
    public partial class addedBrandId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "062fb84d-3ecb-422a-9ac9-dee297468548");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "173d72be-55a2-4b70-98db-d5b2b9eeeaf3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a955b2f-27eb-44b9-90b9-5ab175ba08be", "AQAAAAEAACcQAAAAEEOyX56vBvwSHF28YqVNO4OsaQnJiMg/L07h20zcWrs3vP0i33LT5O0UxmnyzQlWDw==", "588edf54-f459-4f40-8066-0ad4a57739e8" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "BrandId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 0, 33, 11, 395, DateTimeKind.Local).AddTicks(9990), new DateTime(2022, 1, 19, 0, 33, 11, 396, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 0, 33, 11, 396, DateTimeKind.Local).AddTicks(7607), new DateTime(2022, 1, 19, 0, 33, 11, 396, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 0, 33, 11, 396, DateTimeKind.Local).AddTicks(7616), new DateTime(2022, 1, 19, 0, 33, 11, 396, DateTimeKind.Local).AddTicks(7617) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "9a9d210c-a7ee-4e6f-a50b-cb57532f7772");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "73e404ac-8fae-4292-ab85-15652974e0bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a920edc-d95c-4a42-a7f6-e958ad7620e7", "AQAAAAEAACcQAAAAEBxvqJgflHCD+i5L88b8fOYdIs7OQB8i9y4yhAjgSKnPmxUmkZ3tud79nJPQmtbUWA==", "27a8a15d-c1f5-4f65-a913-4e516d523809" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "BrandId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 0, 26, 25, 818, DateTimeKind.Local).AddTicks(2383), new DateTime(2022, 1, 19, 0, 26, 25, 818, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 0, 26, 25, 819, DateTimeKind.Local).AddTicks(266), new DateTime(2022, 1, 19, 0, 26, 25, 819, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 0, 26, 25, 819, DateTimeKind.Local).AddTicks(274), new DateTime(2022, 1, 19, 0, 26, 25, 819, DateTimeKind.Local).AddTicks(275) });
        }
    }
}
