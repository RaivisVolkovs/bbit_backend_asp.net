using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("3ab1e8a7-5b4f-44b3-bf3d-96ef7c1df486"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("573bfecf-fe2f-418a-b23a-29ed9d219678"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("73ad0164-6dc8-4b13-a037-c7ce37ec613d"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("ba0b4d1d-3bd9-4bb3-947e-a7fc74ff5912"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("f836afd7-3ec3-4105-913a-111b571f4744"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("1f7c0966-0790-42fe-89b1-7ec8f2c87977"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("30b71543-ba76-4c6a-8816-5f4b2dfe937e"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("3543191c-e03a-4b20-815d-c2060e984c59"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("8bdc02b5-f820-465a-84eb-2220a1e2af67"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("0f1847de-8026-44ef-9898-dbba2b2849ac"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("632b7117-1a7e-461e-8482-0cdea90a66a5"));

            migrationBuilder.CreateTable(
                name: "DzivoklisIedzivotaji",
                columns: table => new
                {
                    IsOwner = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DzivoklisIedzivotaji");

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
                    { new Guid("1f7c0966-0790-42fe-89b1-7ec8f2c87977"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ba0b4d1d-3bd9-4bb3-947e-a7fc74ff5912"), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" },
                    { new Guid("30b71543-ba76-4c6a-8816-5f4b2dfe937e"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ba0b4d1d-3bd9-4bb3-947e-a7fc74ff5912"), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("3543191c-e03a-4b20-815d-c2060e984c59"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f836afd7-3ec3-4105-913a-111b571f4744"), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("8bdc02b5-f820-465a-84eb-2220a1e2af67"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ab1e8a7-5b4f-44b3-bf3d-96ef7c1df486"), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilsēta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("0f1847de-8026-44ef-9898-dbba2b2849ac"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" },
                    { new Guid("632b7117-1a7e-461e-8482-0cdea90a66a5"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("3ab1e8a7-5b4f-44b3-bf3d-96ef7c1df486"), 100.0, 4, 5, new Guid("632b7117-1a7e-461e-8482-0cdea90a66a5"), "4", 120.0, 4 },
                    { new Guid("573bfecf-fe2f-418a-b23a-29ed9d219678"), 75.0, 3, 4, new Guid("0f1847de-8026-44ef-9898-dbba2b2849ac"), "2", 100.0, 2 },
                    { new Guid("73ad0164-6dc8-4b13-a037-c7ce37ec613d"), 65.0, 2, 3, new Guid("0f1847de-8026-44ef-9898-dbba2b2849ac"), "5", 85.0, 5 },
                    { new Guid("ba0b4d1d-3bd9-4bb3-947e-a7fc74ff5912"), 60.5, 2, 3, new Guid("632b7117-1a7e-461e-8482-0cdea90a66a5"), "1", 80.5, 1 },
                    { new Guid("f836afd7-3ec3-4105-913a-111b571f4744"), 45.0, 1, 2, new Guid("632b7117-1a7e-461e-8482-0cdea90a66a5"), "3", 50.0, 3 }
                });
        }
    }
}
