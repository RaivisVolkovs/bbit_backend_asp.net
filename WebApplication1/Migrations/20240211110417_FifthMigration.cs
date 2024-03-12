using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("03607ab9-9d77-4655-a4df-53080130e8bb"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("42a962bf-3317-46ff-b44b-4db084b3964f"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("a4156fa3-0513-4f58-80a3-a61d5ffb0b81"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("af0b1ad5-e988-4043-8107-2a58077b721d"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("e5b52590-2dec-4a29-90b3-b6629f67d6bd"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("1a7e37a2-5491-44d1-99fd-cf4be6ad58d1"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("353eb7aa-b315-4252-b16e-70917f7d2eaa"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("5a8bfe30-6750-41e4-896a-b09150656c6a"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("636817f4-68c0-4b9f-b8f9-cc499ef7813b"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("01f687ac-529b-4188-a684-e13682a17e0b"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("ad23db24-80ab-450e-a0c6-d88b92563eb8"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimšanasDatums", "DzīvoklisId", "Email", "PersonasKods", "Telefons", "Uzvārds", "Vārds" },
                values: new object[,]
                {
                    { new Guid("1a7e37a2-5491-44d1-99fd-cf4be6ad58d1"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42a962bf-3317-46ff-b44b-4db084b3964f"), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" },
                    { new Guid("353eb7aa-b315-4252-b16e-70917f7d2eaa"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03607ab9-9d77-4655-a4df-53080130e8bb"), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("5a8bfe30-6750-41e4-896a-b09150656c6a"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42a962bf-3317-46ff-b44b-4db084b3964f"), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("636817f4-68c0-4b9f-b8f9-cc499ef7813b"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5b52590-2dec-4a29-90b3-b6629f67d6bd"), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilsēta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("01f687ac-529b-4188-a684-e13682a17e0b"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" },
                    { new Guid("ad23db24-80ab-450e-a0c6-d88b92563eb8"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("03607ab9-9d77-4655-a4df-53080130e8bb"), 45.0, 1, 2, new Guid("01f687ac-529b-4188-a684-e13682a17e0b"), "3", 50.0, 3 },
                    { new Guid("42a962bf-3317-46ff-b44b-4db084b3964f"), 60.5, 2, 3, new Guid("01f687ac-529b-4188-a684-e13682a17e0b"), "1", 80.5, 1 },
                    { new Guid("a4156fa3-0513-4f58-80a3-a61d5ffb0b81"), 75.0, 3, 4, new Guid("ad23db24-80ab-450e-a0c6-d88b92563eb8"), "2", 100.0, 2 },
                    { new Guid("af0b1ad5-e988-4043-8107-2a58077b721d"), 65.0, 2, 3, new Guid("ad23db24-80ab-450e-a0c6-d88b92563eb8"), "5", 85.0, 5 },
                    { new Guid("e5b52590-2dec-4a29-90b3-b6629f67d6bd"), 100.0, 4, 5, new Guid("01f687ac-529b-4188-a684-e13682a17e0b"), "4", 120.0, 4 }
                });
        }
    }
}
