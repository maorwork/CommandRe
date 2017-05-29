using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnlineStore.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "commandre");

            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.EnsureSchema(
                name: "Order");

            migrationBuilder.CreateTable(
                name: "category",
                schema: "commandre",
                columns: table => new
                {
                    category_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "categoryfeaturegroup",
                schema: "commandre",
                columns: table => new
                {
                    categoryFeatureGroup_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryfeaturegroup", x => x.categoryFeatureGroup_id);
                });

            migrationBuilder.CreateTable(
                name: "feature",
                schema: "commandre",
                columns: table => new
                {
                    feature_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feature", x => x.feature_id);
                });

            migrationBuilder.CreateTable(
                name: "featuregroup",
                schema: "commandre",
                columns: table => new
                {
                    featureGroup_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_featuregroup", x => x.featureGroup_id);
                });

            migrationBuilder.CreateTable(
                name: "name",
                schema: "commandre",
                columns: table => new
                {
                    name_id = table.Column<long>(nullable: false),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_name", x => x.name_id);
                });

            migrationBuilder.CreateTable(
                name: "productdescription",
                schema: "commandre",
                columns: table => new
                {
                    description_id = table.Column<long>(nullable: false),
                    longDescription = table.Column<string>(nullable: true),
                    pdfUrl = table.Column<string>(maxLength: 255, nullable: true),
                    shortDescription = table.Column<string>(nullable: true),
                    url = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productdescription_description_id", x => x.description_id);
                });

            migrationBuilder.CreateTable(
                name: "productfeature",
                schema: "commandre",
                columns: table => new
                {
                    productFeature_id = table.Column<long>(nullable: false),
                    presentationValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productfeature", x => x.productFeature_id);
                });

            migrationBuilder.CreateTable(
                name: "productrelated",
                schema: "commandre",
                columns: table => new
                {
                    productRelated_id = table.Column<long>(nullable: false),
                    productAffiliatedId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productrelated", x => x.productRelated_id);
                });

            migrationBuilder.CreateTable(
                name: "supplier",
                schema: "commandre",
                columns: table => new
                {
                    supplier_id = table.Column<long>(nullable: false),
                    name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier", x => x.supplier_id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                schema: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                schema: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 255, nullable: true),
                    Gender = table.Column<string>(maxLength: 1, nullable: true),
                    IsActive = table.Column<string>(maxLength: 1, nullable: true),
                    LastName = table.Column<string>(maxLength: 255, nullable: true),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordOld = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserAddressId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categoryfeaturegroup_featuregroup",
                schema: "commandre",
                columns: table => new
                {
                    categoryFeatureGroup_id = table.Column<long>(nullable: false),
                    featureGroup_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryfeaturegroup_featuregroup_categoryFeatureGroup_id", x => new { x.categoryFeatureGroup_id, x.featureGroup_id });
                    table.ForeignKey(
                        name: "FK_categoryfeaturegroup_featuregroup_categoryfeaturegroup_categoryFeatureGroup_id",
                        column: x => x.categoryFeatureGroup_id,
                        principalSchema: "commandre",
                        principalTable: "categoryfeaturegroup",
                        principalColumn: "categoryFeatureGroup_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_categoryfeaturegroup_featuregroup_featuregroup_featureGroup_id",
                        column: x => x.featureGroup_id,
                        principalSchema: "commandre",
                        principalTable: "featuregroup",
                        principalColumn: "featureGroup_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "category_name",
                schema: "commandre",
                columns: table => new
                {
                    category_id = table.Column<long>(nullable: false),
                    name_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_name_category_id", x => new { x.category_id, x.name_id });
                    table.ForeignKey(
                        name: "FK_category_name_category_category_id",
                        column: x => x.category_id,
                        principalSchema: "commandre",
                        principalTable: "category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_category_name_name_name_id",
                        column: x => x.name_id,
                        principalSchema: "commandre",
                        principalTable: "name",
                        principalColumn: "name_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "featuregroup_name",
                schema: "commandre",
                columns: table => new
                {
                    featureGroup_id = table.Column<long>(nullable: false),
                    name_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_featuregroup_name_featureGroup_id", x => new { x.featureGroup_id, x.name_id });
                    table.ForeignKey(
                        name: "FK_featuregroup_name_featuregroup_featureGroup_id",
                        column: x => x.featureGroup_id,
                        principalSchema: "commandre",
                        principalTable: "featuregroup",
                        principalColumn: "featureGroup_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_featuregroup_name_name_name_id",
                        column: x => x.name_id,
                        principalSchema: "commandre",
                        principalTable: "name",
                        principalColumn: "name_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "feature_name",
                schema: "commandre",
                columns: table => new
                {
                    feature_id = table.Column<long>(nullable: false),
                    name_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feature_name_feature_id", x => new { x.feature_id, x.name_id });
                    table.ForeignKey(
                        name: "FK_feature_name_feature_feature_id",
                        column: x => x.feature_id,
                        principalSchema: "commandre",
                        principalTable: "feature",
                        principalColumn: "feature_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_feature_name_name_name_id",
                        column: x => x.name_id,
                        principalSchema: "commandre",
                        principalTable: "name",
                        principalColumn: "name_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productfeature_feature",
                schema: "commandre",
                columns: table => new
                {
                    productFeature_id = table.Column<long>(nullable: false),
                    feature_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productfeature_feature_productFeature_id", x => new { x.productFeature_id, x.feature_id });
                    table.ForeignKey(
                        name: "FK_productfeature_feature_feature_feature_id",
                        column: x => x.feature_id,
                        principalSchema: "commandre",
                        principalTable: "feature",
                        principalColumn: "feature_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productfeature_feature_productfeature_productFeature_id",
                        column: x => x.productFeature_id,
                        principalSchema: "commandre",
                        principalTable: "productfeature",
                        principalColumn: "productFeature_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "product",
                schema: "commandre",
                columns: table => new
                {
                    product_id = table.Column<long>(nullable: false),
                    highPic = table.Column<string>(maxLength: 255, nullable: true),
                    name = table.Column<string>(maxLength: 255, nullable: true),
                    quality = table.Column<string>(maxLength: 255, nullable: true),
                    releaseDate = table.Column<DateTime>(type: "date", nullable: true),
                    supplier_id = table.Column<long>(nullable: true),
                    title = table.Column<string>(maxLength: 255, nullable: true),
                    updateDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_product_supplier_supplier_id",
                        column: x => x.supplier_id,
                        principalSchema: "commandre",
                        principalTable: "supplier",
                        principalColumn: "supplier_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Accounts_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "User",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Accounts_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserAccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Accounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "User",
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApartmentNumber = table.Column<string>(nullable: true),
                    BuildingNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    UserAccountId = table.Column<int>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Accounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "User",
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "User",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "User",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Accounts_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_category",
                schema: "commandre",
                columns: table => new
                {
                    product_id = table.Column<long>(nullable: false),
                    category_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_category_product_id", x => new { x.product_id, x.category_id });
                    table.ForeignKey(
                        name: "FK_product_category_category_category_id",
                        column: x => x.category_id,
                        principalSchema: "commandre",
                        principalTable: "category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_category_product_product_id",
                        column: x => x.product_id,
                        principalSchema: "commandre",
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "product_categoryfeaturegroup",
                schema: "commandre",
                columns: table => new
                {
                    product_id = table.Column<long>(nullable: false),
                    categoryFeatureGroup_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_categoryfeaturegroup_product_id", x => new { x.product_id, x.categoryFeatureGroup_id });
                    table.ForeignKey(
                        name: "FK_product_categoryfeaturegroup_categoryfeaturegroup_categoryFeatureGroup_id",
                        column: x => x.categoryFeatureGroup_id,
                        principalSchema: "commandre",
                        principalTable: "categoryfeaturegroup",
                        principalColumn: "categoryFeatureGroup_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_categoryfeaturegroup_product_product_id",
                        column: x => x.product_id,
                        principalSchema: "commandre",
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "product_productdescription",
                schema: "commandre",
                columns: table => new
                {
                    product_id = table.Column<long>(nullable: false),
                    description_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_productdescription_product_id", x => new { x.product_id, x.description_id });
                    table.ForeignKey(
                        name: "FK_product_productdescription_productdescription_description_id",
                        column: x => x.description_id,
                        principalSchema: "commandre",
                        principalTable: "productdescription",
                        principalColumn: "description_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_productdescription_product_product_id",
                        column: x => x.product_id,
                        principalSchema: "commandre",
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "product_productfeature",
                schema: "commandre",
                columns: table => new
                {
                    product_id = table.Column<long>(nullable: false),
                    productFeature_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_productfeature_product_id", x => new { x.product_id, x.productFeature_id });
                    table.ForeignKey(
                        name: "FK_product_productfeature_productfeature_productFeature_id",
                        column: x => x.productFeature_id,
                        principalSchema: "commandre",
                        principalTable: "productfeature",
                        principalColumn: "productFeature_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_productfeature_product_product_id",
                        column: x => x.product_id,
                        principalSchema: "commandre",
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "product_productrelated",
                schema: "commandre",
                columns: table => new
                {
                    product_id = table.Column<long>(nullable: false),
                    productRelated_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_productrelated_product_id", x => new { x.product_id, x.productRelated_id });
                    table.ForeignKey(
                        name: "FK_product_productrelated_product_product_id",
                        column: x => x.product_id,
                        principalSchema: "commandre",
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_productrelated_productrelated_productRelated_id",
                        column: x => x.productRelated_id,
                        principalSchema: "commandre",
                        principalTable: "productrelated",
                        principalColumn: "productRelated_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                schema: "User",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => new { x.ShoppingCartId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "commandre",
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalSchema: "User",
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderedDate = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    ShippingAddressId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalSchema: "User",
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatus_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "Order",
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Accounts_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                schema: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "Order",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "commandre",
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categoryfeaturegroup_featuregroup_categoryFeatureGroup_id",
                schema: "commandre",
                table: "categoryfeaturegroup_featuregroup",
                column: "categoryFeatureGroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_categoryfeaturegroup_featuregroup_featureGroup_id",
                schema: "commandre",
                table: "categoryfeaturegroup_featuregroup",
                column: "featureGroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_category_name_category_id",
                schema: "commandre",
                table: "category_name",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_category_name_name_id",
                schema: "commandre",
                table: "category_name",
                column: "name_id");

            migrationBuilder.CreateIndex(
                name: "IX_featuregroup_name_featureGroup_id",
                schema: "commandre",
                table: "featuregroup_name",
                column: "featureGroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_featuregroup_name_name_id",
                schema: "commandre",
                table: "featuregroup_name",
                column: "name_id");

            migrationBuilder.CreateIndex(
                name: "IX_feature_name_feature_id",
                schema: "commandre",
                table: "feature_name",
                column: "feature_id");

            migrationBuilder.CreateIndex(
                name: "IX_feature_name_name_id",
                schema: "commandre",
                table: "feature_name",
                column: "name_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_supplier_id",
                schema: "commandre",
                table: "product",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_category_category_id",
                schema: "commandre",
                table: "product_category",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_category_product_id",
                schema: "commandre",
                table: "product_category",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_categoryfeaturegroup_categoryFeatureGroup_id",
                schema: "commandre",
                table: "product_categoryfeaturegroup",
                column: "categoryFeatureGroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_categoryfeaturegroup_product_id",
                schema: "commandre",
                table: "product_categoryfeaturegroup",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_productfeature_feature_feature_id",
                schema: "commandre",
                table: "productfeature_feature",
                column: "feature_id");

            migrationBuilder.CreateIndex(
                name: "IX_productfeature_feature_productFeature_id",
                schema: "commandre",
                table: "productfeature_feature",
                column: "productFeature_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_productdescription_description_id",
                schema: "commandre",
                table: "product_productdescription",
                column: "description_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_productdescription_product_id",
                schema: "commandre",
                table: "product_productdescription",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_productfeature_productFeature_id",
                schema: "commandre",
                table: "product_productfeature",
                column: "productFeature_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_productfeature_product_id",
                schema: "commandre",
                table: "product_productfeature",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_productrelated_product_id",
                schema: "commandre",
                table: "product_productrelated",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_productrelated_productRelated_id",
                schema: "commandre",
                table: "product_productrelated",
                column: "productRelated_id");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "User",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "User",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "User",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "User",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressId",
                schema: "Order",
                table: "Orders",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                schema: "Order",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                schema: "Order",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                schema: "Order",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserAccountId",
                schema: "User",
                table: "ShoppingCarts",
                column: "UserAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                schema: "User",
                table: "ShoppingCartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "User",
                table: "Accounts",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "User",
                table: "Accounts",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserAccountId",
                schema: "User",
                table: "Addresses",
                column: "UserAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "User",
                table: "Roles",
                column: "NormalizedName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categoryfeaturegroup_featuregroup",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "category_name",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "featuregroup_name",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "feature_name",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "product_category",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "product_categoryfeaturegroup",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "productfeature_feature",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "product_productdescription",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "product_productfeature",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "product_productrelated",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "User");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "User");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "User");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "User");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "User");

            migrationBuilder.DropTable(
                name: "OrderItems",
                schema: "Order");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems",
                schema: "User");

            migrationBuilder.DropTable(
                name: "featuregroup",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "name",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "category",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "categoryfeaturegroup",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "feature",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "productdescription",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "productfeature",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "productrelated",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "User");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "Order");

            migrationBuilder.DropTable(
                name: "product",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "ShoppingCarts",
                schema: "User");

            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "User");

            migrationBuilder.DropTable(
                name: "OrderStatus",
                schema: "Order");

            migrationBuilder.DropTable(
                name: "supplier",
                schema: "commandre");

            migrationBuilder.DropTable(
                name: "Accounts",
                schema: "User");
        }
    }
}
