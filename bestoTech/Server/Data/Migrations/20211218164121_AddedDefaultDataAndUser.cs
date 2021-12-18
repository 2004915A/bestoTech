using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bestoTech.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvgRating = table.Column<int>(type: "int", nullable: false),
                    NumOfProduct = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvgRating = table.Column<float>(type: "real", nullable: false),
                    TotalReviews = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AffiliateLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AStoreId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffiliateLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AffiliateLinks_AStores_AStoreId",
                        column: x => x.AStoreId,
                        principalTable: "AStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffiliateLinks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    ReviewTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewRating = table.Column<int>(type: "int", nullable: false),
                    ReviewStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecieptId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_User1_UserId",
                        column: x => x.UserId,
                        principalTable: "User1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AStores",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(3571), new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(3578), "Amazon", "System" },
                    { 2, "System", new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(3581), new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(3582), "Shopee", "System" },
                    { 3, "System", new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(3584), new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(3585), "Lazada", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "fc507363-991b-4138-ab79-e55c20565c69", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "e1b29be3-4558-4f20-b6fb-e407d17ee596", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3a01fb8e-285f-4f3f-b8bc-ae3f86db9c47", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEAwRZLGJ4iJbCcaMApnxG6lUzzRb1HFIECh1QmHyp2gWPhakLR59Lk+BJ7c6fDN1pw==", null, false, "fb46ed86-2054-4b9c-bc91-5338d045f220", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(545), new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(551), "Phones", "System" },
                    { 2, "System", new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(554), new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(555), "Audio and Visual", "System" },
                    { 3, "System", new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(556), new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(557), "Cameras", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "AvgRating", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "Name", "NumOfProduct", "ProductId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0, 1, "System", new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(7435), new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(7441), "Apple", 3, 0, "System" },
                    { 2, 0, 2, "System", new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(7445), new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(7446), "Samsung", 2, 0, "System" },
                    { 3, 0, 3, "System", new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(7448), new DateTime(2021, 12, 19, 0, 41, 21, 386, DateTimeKind.Local).AddTicks(7449), "Sony", 1, 0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvgRating", "BrandId", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "ProductId", "TotalReviews", "UpdatedBy" },
                values: new object[] { 1, 0f, 1, 1, "System", new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(5184), new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(5191), "Apple iPhone 13", "iPhone 13", 0, 0, "System" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvgRating", "BrandId", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "ProductId", "TotalReviews", "UpdatedBy" },
                values: new object[] { 2, 0f, 1, 1, "System", new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(5195), new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(5196), "Apple iPhone 12", "iPhone 12", 0, 0, "System" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvgRating", "BrandId", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "ProductId", "TotalReviews", "UpdatedBy" },
                values: new object[] { 3, 0f, 1, 1, "System", new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(5197), new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(5198), "Apple iPhone 11", "iPhone 11", 0, 0, "System" });

            migrationBuilder.InsertData(
                table: "AffiliateLinks",
                columns: new[] { "Id", "AStoreId", "CreatedBy", "DateCreated", "DateUpdated", "Link", "Price", "ProductId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2021, 12, 19, 0, 41, 21, 384, DateTimeKind.Local).AddTicks(1570), new DateTime(2021, 12, 19, 0, 41, 21, 384, DateTimeKind.Local).AddTicks(9619), "https://www.amazon.sg/", 0, 1, "System" },
                    { 2, 2, "System", new DateTime(2021, 12, 19, 0, 41, 21, 385, DateTimeKind.Local).AddTicks(489), new DateTime(2021, 12, 19, 0, 41, 21, 385, DateTimeKind.Local).AddTicks(494), "https://shopee.sg/", 0, 2, "System" },
                    { 3, 3, "System", new DateTime(2021, 12, 19, 0, 41, 21, 385, DateTimeKind.Local).AddTicks(497), new DateTime(2021, 12, 19, 0, 41, 21, 385, DateTimeKind.Local).AddTicks(498), "https://www.lazada.sg/", 0, 3, "System" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BrandId", "CreatedBy", "DateCreated", "DateUpdated", "ProductId", "RecieptId", "ReviewDescription", "ReviewId", "ReviewRating", "ReviewStatus", "ReviewTitle", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 0, "System", new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(9782), new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(9788), 1, 1, " ", 0, 1, "Yes", "Title1", "System", 0 },
                    { 2, 0, "System", new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(9793), new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(9794), 2, 2, " ", 0, 2, "Yes", "Title2", "System", 0 },
                    { 3, 0, "System", new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(9796), new DateTime(2021, 12, 19, 0, 41, 21, 387, DateTimeKind.Local).AddTicks(9797), 3, 3, " ", 0, 3, "Yes", "Title3", "System", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AffiliateLinks_AStoreId",
                table: "AffiliateLinks",
                column: "AStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_AffiliateLinks_ProductId",
                table: "AffiliateLinks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_CategoryId",
                table: "Brands",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AffiliateLinks");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AStores");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "User1");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
