using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bestoTech.Server.Data.Migrations
{
    public partial class SeedConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AffiliateLinks_AStores_AStoreId",
                table: "AffiliateLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_AffiliateLinks_Products_ProductId",
                table: "AffiliateLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Categorys_CategoryId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categorys_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_User1_UserId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User1",
                table: "User1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AStores");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "AStores");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "AStores");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "AStores");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AffiliateLinks");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "AffiliateLinks");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "AffiliateLinks");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "AffiliateLinks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "User1");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "User1");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "User1");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "User1");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Categorys");

            migrationBuilder.RenameTable(
                name: "User1",
                newName: "Users1");

            migrationBuilder.RenameTable(
                name: "Categorys",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "ReviewTitle",
                table: "Reviews",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ReviewStatus",
                table: "Reviews",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ReviewRating",
                table: "Reviews",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "ReviewDescription",
                table: "Reviews",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Brands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "AffiliateLinks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AStoreId",
                table: "AffiliateLinks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users1",
                table: "Users1",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AffiliateLinks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AStoreId", "ProductId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AffiliateLinks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AStoreId", "ProductId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AffiliateLinks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AStoreId", "ProductId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "affbd1c6-6eeb-4c79-875c-7a1e868d4e07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "12e833bb-f14e-4a5d-8954-7971f58393c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07aa27a7-d5d2-4f08-a0b0-de36d3f807d2", "AQAAAAEAACcQAAAAENXRgwHWL73msz1OIgxUFHfWH5cn6pgpFsFAhXdIvB/TzP4kg5H0JPYEwBVqnKvd2Q==", "b26b65af-d57e-4b93-ba79-848338762d91" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "CategoryId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "CategoryId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "CategoryId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "DateCreated", "DateUpdated", "ProductId", "UserId" },
                values: new object[] { null, new DateTime(2021, 12, 19, 1, 47, 2, 213, DateTimeKind.Local).AddTicks(677), new DateTime(2021, 12, 19, 1, 47, 2, 213, DateTimeKind.Local).AddTicks(8635), null, null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "DateCreated", "DateUpdated", "ProductId", "UserId" },
                values: new object[] { null, new DateTime(2021, 12, 19, 1, 47, 2, 213, DateTimeKind.Local).AddTicks(9536), new DateTime(2021, 12, 19, 1, 47, 2, 213, DateTimeKind.Local).AddTicks(9541), null, null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "DateCreated", "DateUpdated", "ProductId", "UserId" },
                values: new object[] { null, new DateTime(2021, 12, 19, 1, 47, 2, 213, DateTimeKind.Local).AddTicks(9543), new DateTime(2021, 12, 19, 1, 47, 2, 213, DateTimeKind.Local).AddTicks(9544), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BrandId",
                table: "Reviews",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "ProductCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_ProductId",
                table: "ProductCategory",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AffiliateLinks_AStores_AStoreId",
                table: "AffiliateLinks",
                column: "AStoreId",
                principalTable: "AStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AffiliateLinks_Products_ProductId",
                table: "AffiliateLinks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Categories_CategoryId",
                table: "Brands",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Brands_BrandId",
                table: "Reviews",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users1_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AffiliateLinks_AStores_AStoreId",
                table: "AffiliateLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_AffiliateLinks_Products_ProductId",
                table: "AffiliateLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Categories_CategoryId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Brands_BrandId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users1_UserId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_BrandId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users1",
                table: "Users1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Users1",
                newName: "User1");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categorys");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Reviews",
                newName: "ReviewTitle");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Reviews",
                newName: "ReviewStatus");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Reviews",
                newName: "ReviewRating");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Reviews",
                newName: "ReviewDescription");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AStores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "AStores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "AStores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "AStores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "AffiliateLinks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AStoreId",
                table: "AffiliateLinks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AffiliateLinks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "AffiliateLinks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "AffiliateLinks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "AffiliateLinks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "User1",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "User1",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "User1",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "User1",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Categorys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Categorys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User1",
                table: "User1",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AStores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(469), new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(475), "System" });

            migrationBuilder.UpdateData(
                table: "AStores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(478), new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(479), "System" });

            migrationBuilder.UpdateData(
                table: "AStores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(481), new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(482), "System" });

            migrationBuilder.UpdateData(
                table: "AffiliateLinks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AStoreId", "CreatedBy", "DateCreated", "DateUpdated", "ProductId", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2021, 12, 19, 0, 53, 29, 872, DateTimeKind.Local).AddTicks(8887), new DateTime(2021, 12, 19, 0, 53, 29, 873, DateTimeKind.Local).AddTicks(8094), 1, "System" });

            migrationBuilder.UpdateData(
                table: "AffiliateLinks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AStoreId", "CreatedBy", "DateCreated", "DateUpdated", "ProductId", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2021, 12, 19, 0, 53, 29, 873, DateTimeKind.Local).AddTicks(8959), new DateTime(2021, 12, 19, 0, 53, 29, 873, DateTimeKind.Local).AddTicks(8963), 2, "System" });

            migrationBuilder.UpdateData(
                table: "AffiliateLinks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AStoreId", "CreatedBy", "DateCreated", "DateUpdated", "ProductId", "UpdatedBy" },
                values: new object[] { 3, "System", new DateTime(2021, 12, 19, 0, 53, 29, 873, DateTimeKind.Local).AddTicks(8966), new DateTime(2021, 12, 19, 0, 53, 29, 873, DateTimeKind.Local).AddTicks(8967), 3, "System" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "1f7961e6-0b6d-4094-8918-8a72de235668");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "2c67c85d-7c2d-466b-9b84-89b269e8425e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a1aed59-e68a-4dfd-a13a-2d6c9550f97d", "AQAAAAEAACcQAAAAEH3pe5BYxYzwRwuQrMPRTGut7CYD+K+zEoL4zf8J6pB4cwco8sozYWLZyHyrwfCpqQ==", "86219817-0edf-4745-b746-c62fb6c45b55" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(4502), new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(4508), "System" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(4512), new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(4513), "System" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { 3, "System", new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(4514), new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(4515), "System" });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(7322), new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(7327), "System" });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(7330), new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(7331), "System" });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(7332), new DateTime(2021, 12, 19, 0, 53, 29, 875, DateTimeKind.Local).AddTicks(7333), "System" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { 1, 1, "System", new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(2022), new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(2027), "System" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { 1, 1, "System", new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(2031), new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(2032), "System" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { 1, 1, "System", new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(2034), new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(2035), "System" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "DateCreated", "DateUpdated", "ProductId", "UserId" },
                values: new object[] { 0, new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(6533), new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(6539), 1, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "DateCreated", "DateUpdated", "ProductId", "UserId" },
                values: new object[] { 0, new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(6543), new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(6544), 2, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "DateCreated", "DateUpdated", "ProductId", "UserId" },
                values: new object[] { 0, new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(6546), new DateTime(2021, 12, 19, 0, 53, 29, 876, DateTimeKind.Local).AddTicks(6546), 3, 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_AffiliateLinks_AStores_AStoreId",
                table: "AffiliateLinks",
                column: "AStoreId",
                principalTable: "AStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AffiliateLinks_Products_ProductId",
                table: "AffiliateLinks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Categorys_CategoryId",
                table: "Brands",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categorys_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_User1_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "User1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
