using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("0bf6226d-d636-4556-b0e3-f1e78f3145cb"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("23c98a3b-9387-4c30-89b6-626fb7c6fa98"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("cdc86ba1-624a-48db-9266-878b9228c4a1"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("d9823909-ae4a-4ec8-8860-5c1087c0693c"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("da3bc2aa-f1fb-4ab0-9440-87ab737792d0"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("3af0ded1-030b-4746-a6a6-9263de746a01"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("6f275fc0-88a3-48fa-98cb-58b949ed4778"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("77b6cdc2-2866-4948-b66e-11d2bf2fff51"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("98c10f0a-d753-44a3-8155-35aec7277572"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("89ef1c6b-a6b6-4a0d-a251-02a876b9fcd6"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("ce45b8a1-b578-46c7-a64e-774e7c038ba4"));

            migrationBuilder.AddColumn<Guid>(
                name: "DzivoklisId",
                table: "DzivoklisIedzivotaji",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IedzivotajsId",
                table: "DzivoklisIedzivotaji",
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

            migrationBuilder.CreateIndex(
                name: "IX_DzivoklisIedzivotaji_DzivoklisId",
                table: "DzivoklisIedzivotaji",
                column: "DzivoklisId");

            migrationBuilder.CreateIndex(
                name: "IX_DzivoklisIedzivotaji_IedzivotajsId",
                table: "DzivoklisIedzivotaji",
                column: "IedzivotajsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DzivoklisIedzivotaji_Dzivoklis_DzivoklisId",
                table: "DzivoklisIedzivotaji",
                column: "DzivoklisId",
                principalTable: "Dzivoklis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DzivoklisIedzivotaji_Iedzivotajs_IedzivotajsId",
                table: "DzivoklisIedzivotaji",
                column: "IedzivotajsId",
                principalTable: "Iedzivotajs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DzivoklisIedzivotaji_Dzivoklis_DzivoklisId",
                table: "DzivoklisIedzivotaji");

            migrationBuilder.DropForeignKey(
                name: "FK_DzivoklisIedzivotaji_Iedzivotajs_IedzivotajsId",
                table: "DzivoklisIedzivotaji");

            migrationBuilder.DropIndex(
                name: "IX_DzivoklisIedzivotaji_DzivoklisId",
                table: "DzivoklisIedzivotaji");

            migrationBuilder.DropIndex(
                name: "IX_DzivoklisIedzivotaji_IedzivotajsId",
                table: "DzivoklisIedzivotaji");

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
                name: "DzivoklisId",
                table: "DzivoklisIedzivotaji");

            migrationBuilder.DropColumn(
                name: "IedzivotajsId",
                table: "DzivoklisIedzivotaji");

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimšanasDatums", "DzīvoklisId", "Email", "PersonasKods", "Telefons", "Uzvārds", "Vārds" },
                values: new object[,]
                {
                    { new Guid("3af0ded1-030b-4746-a6a6-9263de746a01"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c98a3b-9387-4c30-89b6-626fb7c6fa98"), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" },
                    { new Guid("6f275fc0-88a3-48fa-98cb-58b949ed4778"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9823909-ae4a-4ec8-8860-5c1087c0693c"), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("77b6cdc2-2866-4948-b66e-11d2bf2fff51"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da3bc2aa-f1fb-4ab0-9440-87ab737792d0"), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("98c10f0a-d753-44a3-8155-35aec7277572"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9823909-ae4a-4ec8-8860-5c1087c0693c"), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilsēta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("89ef1c6b-a6b6-4a0d-a251-02a876b9fcd6"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" },
                    { new Guid("ce45b8a1-b578-46c7-a64e-774e7c038ba4"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("0bf6226d-d636-4556-b0e3-f1e78f3145cb"), 75.0, 3, 4, new Guid("89ef1c6b-a6b6-4a0d-a251-02a876b9fcd6"), "2", 100.0, 2 },
                    { new Guid("23c98a3b-9387-4c30-89b6-626fb7c6fa98"), 100.0, 4, 5, new Guid("ce45b8a1-b578-46c7-a64e-774e7c038ba4"), "4", 120.0, 4 },
                    { new Guid("cdc86ba1-624a-48db-9266-878b9228c4a1"), 65.0, 2, 3, new Guid("89ef1c6b-a6b6-4a0d-a251-02a876b9fcd6"), "5", 85.0, 5 },
                    { new Guid("d9823909-ae4a-4ec8-8860-5c1087c0693c"), 60.5, 2, 3, new Guid("ce45b8a1-b578-46c7-a64e-774e7c038ba4"), "1", 80.5, 1 },
                    { new Guid("da3bc2aa-f1fb-4ab0-9440-87ab737792d0"), 45.0, 1, 2, new Guid("ce45b8a1-b578-46c7-a64e-774e7c038ba4"), "3", 50.0, 3 }
                });
        }
    }
}
