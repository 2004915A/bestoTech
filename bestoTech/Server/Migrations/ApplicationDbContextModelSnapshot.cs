﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bestoTech.Server.Data;

namespace bestoTech.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                            ConcurrencyStamp = "d0e2f6cc-8392-4924-9e66-cab483aff6dd",
=======
                            ConcurrencyStamp = "6ab5eebe-69ef-4cea-a7fd-fa5b983410b8",
>>>>>>> 96df1d66d4f3c515b9f8f763d6bcecd346ed6637
=======
                            ConcurrencyStamp = "6371cdba-14a5-47d8-b3c8-0836b2d985f0",
>>>>>>> e1bf2aaad8b2c0d0a596e3b4f2a9f5c8a9be906a
=======
                            ConcurrencyStamp = "c4f4e5f4-3fd3-4106-8846-6a8f81954032",
>>>>>>> parent of e1bf2aa (Removal of ProductCategories and BrandCategories entities)
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                            ConcurrencyStamp = "4b2f218c-f326-4614-b55e-bd3510e20f4a",
=======
                            ConcurrencyStamp = "8203a403-3f98-48e9-8b26-d4dececf9504",
>>>>>>> 96df1d66d4f3c515b9f8f763d6bcecd346ed6637
=======
                            ConcurrencyStamp = "39ec1d62-cee7-458a-a956-28a11deab85d",
>>>>>>> e1bf2aaad8b2c0d0a596e3b4f2a9f5c8a9be906a
=======
                            ConcurrencyStamp = "8833877f-9795-4995-bea6-a4b4ea9d40bc",
>>>>>>> parent of e1bf2aa (Removal of ProductCategories and BrandCategories entities)
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("bestoTech.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            AccessFailedCount = 0,
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                            ConcurrencyStamp = "eab6ccc3-51ba-4d47-a5db-f87fcedd8101",
=======
                            ConcurrencyStamp = "f26a7786-36c1-43f6-9734-9defc0a878f7",
>>>>>>> 96df1d66d4f3c515b9f8f763d6bcecd346ed6637
=======
                            ConcurrencyStamp = "14045216-9d78-4a4b-8a82-f0c80885bdbb",
>>>>>>> e1bf2aaad8b2c0d0a596e3b4f2a9f5c8a9be906a
=======
                            ConcurrencyStamp = "ce464f50-2f17-42da-b093-2fce2ec62db4",
>>>>>>> parent of e1bf2aa (Removal of ProductCategories and BrandCategories entities)
                            Email = "admin@localhost.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN",
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                            PasswordHash = "AQAAAAEAACcQAAAAEOmEurmwK8Z0g85dfXG8k1UlKYh5qwVHzrjteTioOv6QL9YaDhHWfzVwQjx84OIeDg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5e2ffa01-ab92-4b2a-8abc-88c1b74aa154",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEG4432O/P7NhQdVJt3V17gNw09qUgvdzOZ7K426PlLjSKhpeNLwWL+15Szg1U1ZRMA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1c9f381f-64e4-432a-a0e0-9342be7bcc0b",
>>>>>>> 96df1d66d4f3c515b9f8f763d6bcecd346ed6637
=======
                            PasswordHash = "AQAAAAEAACcQAAAAENM43jGww0akBpGGsmwWPDxCm58xr+uqIRVrprLAVjERKPxkmrFDdYmydCFWHiteGw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b4c5ebf1-ff3a-465e-8958-85064344b757",
>>>>>>> e1bf2aaad8b2c0d0a596e3b4f2a9f5c8a9be906a
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEItgoLsulmAh1dZfH5D2L9C/opXfa5zQCUoTtXibLJZfa7b4Ut5zFDkRojCCSuXbzQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "52771ff4-c7f0-4599-beb2-78ceb1a0932e",
>>>>>>> parent of e1bf2aa (Removal of ProductCategories and BrandCategories entities)
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.ALink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AStoreId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AStoreId");

                    b.HasIndex("ProductId");

                    b.ToTable("ALinks");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.AStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("AStores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Amazon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shopee"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lazada"
                        });
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("AvgRating")
                        .HasColumnType("real");

                    b.Property<int?>("BrandCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("NumOfProduct")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandCategoryId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvgRating = 0f,
                            Description = "Apple Inc. is an American multinational technology company that specializes in consumer electronics, software and online services.",
                            Name = "Apple",
                            NumOfProduct = 0
                        },
                        new
                        {
                            Id = 2,
                            AvgRating = 0f,
                            Description = "Samsung Electronics Co., Ltd. is a South Korean multinational electronics corporation headquartered in the Yeongtong District of Suwon.",
                            Name = "Samsung",
                            NumOfProduct = 0
                        },
                        new
                        {
                            Id = 3,
                            AvgRating = 0f,
                            Description = "Sony Group Corporation, commonly known as Sony and stylized as SONY, is a Japanese multinational conglomerate corporation headquartered in Kōnan, Minato, Tokyo, Japan.",
                            Name = "Sony",
                            NumOfProduct = 0
                        });
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.BrandCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("BrandCategories");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("ProductCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandCategoryId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Phones"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Audio and Visual"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cameras"
                        });
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AvgRating")
                        .HasColumnType("real");

                    b.Property<int?>("BrandId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("TotalReviews")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("ProductId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("RecieptId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
<<<<<<< HEAD

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2022, 2, 5, 19, 17, 43, 15, DateTimeKind.Local).AddTicks(3212),
                            DateUpdated = new DateTime(2022, 2, 5, 19, 17, 43, 16, DateTimeKind.Local).AddTicks(2067),
                            Description = " ",
                            Rating = 1,
                            RecieptId = 1,
                            Status = "Yes",
                            Title = "Title1",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2022, 2, 5, 19, 17, 43, 16, DateTimeKind.Local).AddTicks(2998),
                            DateUpdated = new DateTime(2022, 2, 5, 19, 17, 43, 16, DateTimeKind.Local).AddTicks(3002),
                            Description = " ",
                            Rating = 2,
                            RecieptId = 2,
                            Status = "Yes",
                            Title = "Title2",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2022, 2, 5, 19, 17, 43, 16, DateTimeKind.Local).AddTicks(3005),
                            DateUpdated = new DateTime(2022, 2, 5, 19, 17, 43, 16, DateTimeKind.Local).AddTicks(3006),
                            Description = " ",
                            Rating = 3,
                            RecieptId = 3,
                            Status = "Yes",
                            Title = "Title3",
                            UpdatedBy = "System"
                        });
=======
>>>>>>> 96df1d66d4f3c515b9f8f763d6bcecd346ed6637
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User1");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("bestoTech.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("bestoTech.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bestoTech.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("bestoTech.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.ALink", b =>
                {
                    b.HasOne("bestoTech.Shared.Domain.AStore", "AStore")
                        .WithMany()
                        .HasForeignKey("AStoreId");

                    b.HasOne("bestoTech.Shared.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AStore");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Brand", b =>
                {
                    b.HasOne("bestoTech.Shared.Domain.BrandCategory", "BrandCategory")
                        .WithMany()
                        .HasForeignKey("BrandCategoryId");

                    b.Navigation("BrandCategory");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Category", b =>
                {
                    b.HasOne("bestoTech.Shared.Domain.BrandCategory", null)
                        .WithMany("Categories")
                        .HasForeignKey("BrandCategoryId");

                    b.HasOne("bestoTech.Shared.Domain.ProductCategory", null)
                        .WithMany("Categories")
                        .HasForeignKey("ProductCategoryId");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Product", b =>
                {
                    b.HasOne("bestoTech.Shared.Domain.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bestoTech.Shared.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Review", b =>
                {
                    b.HasOne("bestoTech.Shared.Domain.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bestoTech.Shared.Domain.User", null)
                        .WithMany("Reviews")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.BrandCategory", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.Product", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.ProductCategory", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("bestoTech.Shared.Domain.User", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
