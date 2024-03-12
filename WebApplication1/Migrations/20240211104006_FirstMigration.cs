using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iedzivotajs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vārds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uzvārds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonasKods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DzimšanasDatums = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefons = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DzīvoklisId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsOwner = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iedzivotajs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Majas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numurs = table.Column<int>(type: "int", nullable: true),
                    Iela = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pilsēta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valsts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PastaIndekss = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dzivoklis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numurs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stāvs = table.Column<int>(type: "int", nullable: false),
                    IstabuSkaits = table.Column<int>(type: "int", nullable: false),
                    IedzīvotājuSkaits = table.Column<int>(type: "int", nullable: false),
                    PilnaPlatība = table.Column<double>(type: "float", nullable: false),
                    DzīvojamāPlatība = table.Column<double>(type: "float", nullable: false),
                    MājaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dzivoklis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dzivoklis_Majas_MājaId",
                        column: x => x.MājaId,
                        principalTable: "Majas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DzivoklisIedzivotajs",
                columns: table => new
                {
                    DzivokliId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IedzivotajiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DzivoklisIedzivotajs", x => new { x.DzivokliId, x.IedzivotajiId });
                    table.ForeignKey(
                        name: "FK_DzivoklisIedzivotajs_Dzivoklis_DzivokliId",
                        column: x => x.DzivokliId,
                        principalTable: "Dzivoklis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DzivoklisIedzivotajs_Iedzivotajs_IedzivotajiId",
                        column: x => x.IedzivotajiId,
                        principalTable: "Iedzivotajs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimšanasDatums", "DzīvoklisId", "Email", "IsOwner", "PersonasKods", "Telefons", "Uzvārds", "Vārds" },
                values: new object[,]
                {
                    { new Guid("3786154f-16b5-4eaa-8adf-c6e20040e5f2"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5fbd5544-1649-4a30-a8ed-e62ae2c7cca7"), "liga@inbox.lv", false, "423456-78910", "+371 34567890", "Liepiņa", "Līga" },
                    { new Guid("676d8996-0905-4720-a595-3e683e0103d2"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("855084e8-b5dd-4e25-be94-0be746943a4d"), "peteris@gmail.com", false, "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("d1491dce-e6ef-43bc-8bde-82cdb829bfc9"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8475859a-4fe8-4378-bed7-7f46139afd01"), "janis@gmail.com", false, "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("fb035136-cc9b-4a10-b80d-409c7eca70db"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8475859a-4fe8-4378-bed7-7f46139afd01"), "anna@inbox.lv", false, "223456-78910", "+371 87654321", "Zvaigzne", "Anna" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilsēta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("45cf0829-dd58-4330-88fe-0efae1ea46fa"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" },
                    { new Guid("bfe6e213-a7cc-459c-9479-2fac7c0612eb"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("5fbd5544-1649-4a30-a8ed-e62ae2c7cca7"), 100.0, 4, 5, new Guid("45cf0829-dd58-4330-88fe-0efae1ea46fa"), "4", 120.0, 4 },
                    { new Guid("8475859a-4fe8-4378-bed7-7f46139afd01"), 60.5, 2, 3, new Guid("45cf0829-dd58-4330-88fe-0efae1ea46fa"), "1", 80.5, 1 },
                    { new Guid("855084e8-b5dd-4e25-be94-0be746943a4d"), 45.0, 1, 2, new Guid("45cf0829-dd58-4330-88fe-0efae1ea46fa"), "3", 50.0, 3 },
                    { new Guid("ab42599d-4941-4b3f-bbb6-fb428651147f"), 65.0, 2, 3, new Guid("bfe6e213-a7cc-459c-9479-2fac7c0612eb"), "5", 85.0, 5 },
                    { new Guid("e9c55d2c-ba1f-4e62-b88d-c3f1fb0f44b6"), 75.0, 3, 4, new Guid("bfe6e213-a7cc-459c-9479-2fac7c0612eb"), "2", 100.0, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dzivoklis_MājaId",
                table: "Dzivoklis",
                column: "MājaId");

            migrationBuilder.CreateIndex(
                name: "IX_DzivoklisIedzivotajs_IedzivotajiId",
                table: "DzivoklisIedzivotajs",
                column: "IedzivotajiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DzivoklisIedzivotajs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Dzivoklis");

            migrationBuilder.DropTable(
                name: "Iedzivotajs");

            migrationBuilder.DropTable(
                name: "Majas");
        }
    }
}
