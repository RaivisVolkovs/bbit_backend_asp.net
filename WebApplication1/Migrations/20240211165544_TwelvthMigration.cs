using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class TwelvthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("15d31112-bb16-48f3-9d21-d3a76086c295"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("b57b8df7-23c4-4713-b58f-30208dc079b1"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("00f55e9a-05ee-4f45-ab1f-a1815ace67a2"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("061bb77e-03bb-48ad-a01f-a3e08f2a8eb4"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("8ad8a09a-5619-4e43-9e3e-8e49c4933cb0"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("f15229e5-24c2-4adc-bdeb-8dbe1907f1a5"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("0debce1a-d2a9-4fbe-b3a2-1fd415ed58f5"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("39d5bbe5-1358-4d03-8876-e12b014cc05b"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("665e44e9-972d-40c2-b208-1da8cea759b1"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("85bdd45e-f732-4131-b637-5a2b029a8691"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("c1e688e7-c834-4e8c-952c-c3489cf897cb"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("a169dfd6-18ad-4370-a46f-fd6104add8ec"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("ad3bd71a-fe0a-41c9-8104-230718f01340"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("6afb44dc-0097-49a7-a19c-f3a1a8b0058b"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("fdd7125e-7fc1-4bd6-9a0d-6ff91417efe0"));

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimsanasDatums", "Email", "PersonasKods", "Telefons", "Uzvards", "Vards" },
                values: new object[,]
                {
                    { new Guid("0d494529-7490-4d88-a338-98e289b21800"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("242d86c8-1aa7-4574-9e81-2ac581e46a61"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" },
                    { new Guid("72fbe92f-6557-4620-84cc-cb63db66403a"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" },
                    { new Guid("f182a7d3-2aad-40de-9290-cc427b267305"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilseta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("6f9c399c-07dc-4eaa-b5f5-8b43faecd857"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" },
                    { new Guid("9602a111-ec49-473c-a3d4-4aa49fcdf072"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzivojamaPlatiba", "IedzivotajuSkaits", "IstabuSkaits", "MajaId", "Numurs", "PilnaPlatiba", "Stavs" },
                values: new object[,]
                {
                    { new Guid("1284032f-1af6-47df-a1e2-b577ac8fd70b"), 45.0, 1, 2, new Guid("9602a111-ec49-473c-a3d4-4aa49fcdf072"), "3", 50.0, 3 },
                    { new Guid("429d6417-e9f7-4935-852b-75ea57c2d8a1"), 100.0, 4, 5, new Guid("9602a111-ec49-473c-a3d4-4aa49fcdf072"), "4", 120.0, 4 },
                    { new Guid("8885a8e4-c413-4ad9-b6d5-81b92fade313"), 60.5, 2, 3, new Guid("9602a111-ec49-473c-a3d4-4aa49fcdf072"), "1", 80.5, 1 },
                    { new Guid("8e949078-e895-47a9-9937-8438c461caba"), 75.0, 3, 4, new Guid("6f9c399c-07dc-4eaa-b5f5-8b43faecd857"), "2", 100.0, 2 },
                    { new Guid("d9eb29b4-d6f0-4641-8fda-de701b8b945f"), 65.0, 2, 3, new Guid("6f9c399c-07dc-4eaa-b5f5-8b43faecd857"), "5", 85.0, 5 }
                });

            migrationBuilder.InsertData(
                table: "DzivoklisIedzivotaji",
                columns: new[] { "Id", "DzivoklisId", "IedzivotajsId", "IsOwner" },
                values: new object[,]
                {
                    { new Guid("3aa79b03-a77d-40e9-8863-816ef3d8f451"), new Guid("1284032f-1af6-47df-a1e2-b577ac8fd70b"), new Guid("0d494529-7490-4d88-a338-98e289b21800"), false },
                    { new Guid("6d9a84b2-0e21-44bb-8199-e8423dfb5873"), new Guid("8885a8e4-c413-4ad9-b6d5-81b92fade313"), new Guid("0d494529-7490-4d88-a338-98e289b21800"), true },
                    { new Guid("c88b253a-207e-4740-b592-2133f8875a0b"), new Guid("8e949078-e895-47a9-9937-8438c461caba"), new Guid("0d494529-7490-4d88-a338-98e289b21800"), true },
                    { new Guid("cbb351b5-ce64-49fa-8adc-e99d2ee03e05"), new Guid("8885a8e4-c413-4ad9-b6d5-81b92fade313"), new Guid("72fbe92f-6557-4620-84cc-cb63db66403a"), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("429d6417-e9f7-4935-852b-75ea57c2d8a1"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("d9eb29b4-d6f0-4641-8fda-de701b8b945f"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("3aa79b03-a77d-40e9-8863-816ef3d8f451"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("6d9a84b2-0e21-44bb-8199-e8423dfb5873"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("c88b253a-207e-4740-b592-2133f8875a0b"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("cbb351b5-ce64-49fa-8adc-e99d2ee03e05"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("242d86c8-1aa7-4574-9e81-2ac581e46a61"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("f182a7d3-2aad-40de-9290-cc427b267305"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("1284032f-1af6-47df-a1e2-b577ac8fd70b"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("8885a8e4-c413-4ad9-b6d5-81b92fade313"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("8e949078-e895-47a9-9937-8438c461caba"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("0d494529-7490-4d88-a338-98e289b21800"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("72fbe92f-6557-4620-84cc-cb63db66403a"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("6f9c399c-07dc-4eaa-b5f5-8b43faecd857"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("9602a111-ec49-473c-a3d4-4aa49fcdf072"));

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimsanasDatums", "Email", "PersonasKods", "Telefons", "Uzvards", "Vards" },
                values: new object[,]
                {
                    { new Guid("0debce1a-d2a9-4fbe-b3a2-1fd415ed58f5"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("39d5bbe5-1358-4d03-8876-e12b014cc05b"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" },
                    { new Guid("a169dfd6-18ad-4370-a46f-fd6104add8ec"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" },
                    { new Guid("ad3bd71a-fe0a-41c9-8104-230718f01340"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilseta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("6afb44dc-0097-49a7-a19c-f3a1a8b0058b"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" },
                    { new Guid("fdd7125e-7fc1-4bd6-9a0d-6ff91417efe0"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzivojamaPlatiba", "IedzivotajuSkaits", "IstabuSkaits", "MajaId", "Numurs", "PilnaPlatiba", "Stavs" },
                values: new object[,]
                {
                    { new Guid("15d31112-bb16-48f3-9d21-d3a76086c295"), 100.0, 4, 5, new Guid("6afb44dc-0097-49a7-a19c-f3a1a8b0058b"), "4", 120.0, 4 },
                    { new Guid("665e44e9-972d-40c2-b208-1da8cea759b1"), 75.0, 3, 4, new Guid("fdd7125e-7fc1-4bd6-9a0d-6ff91417efe0"), "2", 100.0, 2 },
                    { new Guid("85bdd45e-f732-4131-b637-5a2b029a8691"), 60.5, 2, 3, new Guid("6afb44dc-0097-49a7-a19c-f3a1a8b0058b"), "1", 80.5, 1 },
                    { new Guid("b57b8df7-23c4-4713-b58f-30208dc079b1"), 65.0, 2, 3, new Guid("fdd7125e-7fc1-4bd6-9a0d-6ff91417efe0"), "5", 85.0, 5 },
                    { new Guid("c1e688e7-c834-4e8c-952c-c3489cf897cb"), 45.0, 1, 2, new Guid("6afb44dc-0097-49a7-a19c-f3a1a8b0058b"), "3", 50.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "DzivoklisIedzivotaji",
                columns: new[] { "Id", "DzivoklisId", "IedzivotajsId", "IsOwner" },
                values: new object[,]
                {
                    { new Guid("00f55e9a-05ee-4f45-ab1f-a1815ace67a2"), new Guid("85bdd45e-f732-4131-b637-5a2b029a8691"), new Guid("ad3bd71a-fe0a-41c9-8104-230718f01340"), true },
                    { new Guid("061bb77e-03bb-48ad-a01f-a3e08f2a8eb4"), new Guid("85bdd45e-f732-4131-b637-5a2b029a8691"), new Guid("a169dfd6-18ad-4370-a46f-fd6104add8ec"), false },
                    { new Guid("8ad8a09a-5619-4e43-9e3e-8e49c4933cb0"), new Guid("665e44e9-972d-40c2-b208-1da8cea759b1"), new Guid("ad3bd71a-fe0a-41c9-8104-230718f01340"), true },
                    { new Guid("f15229e5-24c2-4adc-bdeb-8dbe1907f1a5"), new Guid("c1e688e7-c834-4e8c-952c-c3489cf897cb"), new Guid("ad3bd71a-fe0a-41c9-8104-230718f01340"), false }
                });
        }
    }
}
