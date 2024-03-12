using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class SeventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("013b4d18-4a5e-4c42-9e03-2c0f55470aac"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("62c35c4e-2a4a-428e-bd1f-4e768f7a7149"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("8679fd53-a799-4913-8f68-0444631e50ea"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("8e864134-1bb1-4d28-ad1e-f4cf1a796d5e"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("b8fcf355-00ed-44e0-bc68-47e6d9d189c2"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("acbe8f85-572a-40e4-8096-76c2e9eb54d8"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("cbb53c26-63d3-4b68-832b-b74649925fb4"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("d9950fdf-74ec-4fa2-8244-4d6ac94fd81f"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("efc12a4f-7f12-4dea-bec5-f9e0defd3854"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("41a8c5ac-e533-4c35-967f-bc5eebfe388a"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("b1375a72-98dd-4a15-8506-db7b03cd0c94"));

            migrationBuilder.DropColumn(
                name: "DzīvoklisId",
                table: "Iedzivotajs");

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
                columns: new[] { "Id", "DzimšanasDatums", "Email", "PersonasKods", "Telefons", "Uzvārds", "Vārds" },
                values: new object[,]
                {
                    { new Guid("6e116019-c4a2-45e1-9c0d-3e131ed4fd0c"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("984bf48f-c61c-4220-ab67-470540e9fd4e"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("e475dd75-f340-43e1-8f8a-eb2e98b6ee61"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" },
                    { new Guid("ec624523-20f3-428b-b34f-c57ffb719d19"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilsēta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("dcdbc434-bc28-4b8e-98b2-9b45aabe03bc"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" },
                    { new Guid("efe6ecaa-0c9d-4bc7-9b9c-70a980debeff"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("20c95e7e-18fc-4493-95cc-946c449e0cfc"), 75.0, 3, 4, new Guid("dcdbc434-bc28-4b8e-98b2-9b45aabe03bc"), "2", 100.0, 2 },
                    { new Guid("3493820b-d72c-4fb9-9aee-82999b919422"), 100.0, 4, 5, new Guid("efe6ecaa-0c9d-4bc7-9b9c-70a980debeff"), "4", 120.0, 4 },
                    { new Guid("569ca6bf-e372-4d9c-adff-ece266fc511f"), 60.5, 2, 3, new Guid("efe6ecaa-0c9d-4bc7-9b9c-70a980debeff"), "1", 80.5, 1 },
                    { new Guid("79b3023e-dad5-4f13-a8b5-7becd50ee417"), 65.0, 2, 3, new Guid("dcdbc434-bc28-4b8e-98b2-9b45aabe03bc"), "5", 85.0, 5 },
                    { new Guid("cf2ca99c-1f42-47dc-b0cb-d2ee21c27ea0"), 45.0, 1, 2, new Guid("efe6ecaa-0c9d-4bc7-9b9c-70a980debeff"), "3", 50.0, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DzivoklisIedzivotajs_IedzivotajiId",
                table: "DzivoklisIedzivotajs",
                column: "IedzivotajiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DzivoklisIedzivotajs");

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("20c95e7e-18fc-4493-95cc-946c449e0cfc"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("3493820b-d72c-4fb9-9aee-82999b919422"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("569ca6bf-e372-4d9c-adff-ece266fc511f"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("79b3023e-dad5-4f13-a8b5-7becd50ee417"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("cf2ca99c-1f42-47dc-b0cb-d2ee21c27ea0"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("6e116019-c4a2-45e1-9c0d-3e131ed4fd0c"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("984bf48f-c61c-4220-ab67-470540e9fd4e"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("e475dd75-f340-43e1-8f8a-eb2e98b6ee61"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("ec624523-20f3-428b-b34f-c57ffb719d19"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("dcdbc434-bc28-4b8e-98b2-9b45aabe03bc"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("efe6ecaa-0c9d-4bc7-9b9c-70a980debeff"));

            migrationBuilder.AddColumn<Guid>(
                name: "DzīvoklisId",
                table: "Iedzivotajs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimšanasDatums", "DzīvoklisId", "Email", "PersonasKods", "Telefons", "Uzvārds", "Vārds" },
                values: new object[,]
                {
                    { new Guid("acbe8f85-572a-40e4-8096-76c2e9eb54d8"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("62c35c4e-2a4a-428e-bd1f-4e768f7a7149"), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("cbb53c26-63d3-4b68-832b-b74649925fb4"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8679fd53-a799-4913-8f68-0444631e50ea"), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("d9950fdf-74ec-4fa2-8244-4d6ac94fd81f"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("62c35c4e-2a4a-428e-bd1f-4e768f7a7149"), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" },
                    { new Guid("efc12a4f-7f12-4dea-bec5-f9e0defd3854"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8e864134-1bb1-4d28-ad1e-f4cf1a796d5e"), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilsēta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("41a8c5ac-e533-4c35-967f-bc5eebfe388a"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" },
                    { new Guid("b1375a72-98dd-4a15-8506-db7b03cd0c94"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("013b4d18-4a5e-4c42-9e03-2c0f55470aac"), 65.0, 2, 3, new Guid("41a8c5ac-e533-4c35-967f-bc5eebfe388a"), "5", 85.0, 5 },
                    { new Guid("62c35c4e-2a4a-428e-bd1f-4e768f7a7149"), 60.5, 2, 3, new Guid("b1375a72-98dd-4a15-8506-db7b03cd0c94"), "1", 80.5, 1 },
                    { new Guid("8679fd53-a799-4913-8f68-0444631e50ea"), 45.0, 1, 2, new Guid("b1375a72-98dd-4a15-8506-db7b03cd0c94"), "3", 50.0, 3 },
                    { new Guid("8e864134-1bb1-4d28-ad1e-f4cf1a796d5e"), 100.0, 4, 5, new Guid("b1375a72-98dd-4a15-8506-db7b03cd0c94"), "4", 120.0, 4 },
                    { new Guid("b8fcf355-00ed-44e0-bc68-47e6d9d189c2"), 75.0, 3, 4, new Guid("41a8c5ac-e533-4c35-967f-bc5eebfe388a"), "2", 100.0, 2 }
                });
        }
    }
}
