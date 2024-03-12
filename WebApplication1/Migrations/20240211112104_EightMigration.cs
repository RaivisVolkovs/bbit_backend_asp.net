using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class EightMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimšanasDatums", "Email", "PersonasKods", "Telefons", "Uzvārds", "Vārds" },
                values: new object[,]
                {
                    { new Guid("2029e14a-6d13-4bf8-ad28-6117ffe86596"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" },
                    { new Guid("2f4709ec-2b49-4fbe-9a96-d77bb60a5635"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("509f3a63-0b78-437f-ab4c-6831bfc253f9"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" },
                    { new Guid("eff28901-5087-4ee4-959c-0548eb45c135"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilsēta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("1269f9b6-bceb-4bf2-abf9-32709d33f5bc"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" },
                    { new Guid("80bdefc2-e64a-4ba4-9e91-05dcf3f292fe"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("07b92132-342e-407e-aa79-2ec17c026f04"), 65.0, 2, 3, new Guid("1269f9b6-bceb-4bf2-abf9-32709d33f5bc"), "5", 85.0, 5 },
                    { new Guid("20375190-e860-460c-a712-b05483d9e36b"), 45.0, 1, 2, new Guid("80bdefc2-e64a-4ba4-9e91-05dcf3f292fe"), "3", 50.0, 3 },
                    { new Guid("452ed0a6-e8ed-4d22-8d1f-5853cb3e78f8"), 60.5, 2, 3, new Guid("80bdefc2-e64a-4ba4-9e91-05dcf3f292fe"), "1", 80.5, 1 },
                    { new Guid("71965c66-aee1-4c10-987b-5f66834b78cb"), 75.0, 3, 4, new Guid("1269f9b6-bceb-4bf2-abf9-32709d33f5bc"), "2", 100.0, 2 },
                    { new Guid("e393c42c-4d37-459e-8467-84a1f7c7a39d"), 100.0, 4, 5, new Guid("80bdefc2-e64a-4ba4-9e91-05dcf3f292fe"), "4", 120.0, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("07b92132-342e-407e-aa79-2ec17c026f04"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("20375190-e860-460c-a712-b05483d9e36b"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("452ed0a6-e8ed-4d22-8d1f-5853cb3e78f8"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("71965c66-aee1-4c10-987b-5f66834b78cb"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("e393c42c-4d37-459e-8467-84a1f7c7a39d"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("2029e14a-6d13-4bf8-ad28-6117ffe86596"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("2f4709ec-2b49-4fbe-9a96-d77bb60a5635"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("509f3a63-0b78-437f-ab4c-6831bfc253f9"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("eff28901-5087-4ee4-959c-0548eb45c135"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("1269f9b6-bceb-4bf2-abf9-32709d33f5bc"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("80bdefc2-e64a-4ba4-9e91-05dcf3f292fe"));

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
    }
}
