using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class EleventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dzivoklis_Majas_MājaId",
                table: "Dzivoklis");

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("d6ff55ce-5bd4-4100-93e1-08dbf9a3b94e"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("e3824036-e427-41c5-9080-ed5e8832d413"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("269e8965-b32e-4f32-87d1-e8b787a3e2b1"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("4f43c72e-f040-47a1-869d-dc97a073a12e"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("6f760325-6309-44f5-b13d-55aa7167a843"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("7e381743-25e9-40f9-86ac-0b34f33650ce"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("78cdec54-9f51-4208-89b6-b7925d5afbf6"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("a4d351a9-fd2d-4f6c-8903-ef0382f5a326"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("28edc461-47d2-4a65-a851-908e45c5cb2b"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("94438f34-c1f7-4738-9828-8e6095da10d0"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("f9be9311-fb0f-4a66-ad86-5f8b561deb90"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("3996b39f-eaeb-40d0-9a49-9789303633e0"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("52d10a1f-c772-4537-858c-3a763814bcc1"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("4e702613-344b-4ca0-92bd-d36d68d8d3bb"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("83b51930-e6b7-462a-ae56-26592e479997"));

            migrationBuilder.RenameColumn(
                name: "Vārds",
                table: "Iedzivotajs",
                newName: "Vards");

            migrationBuilder.RenameColumn(
                name: "Uzvārds",
                table: "Iedzivotajs",
                newName: "Uzvards");

            migrationBuilder.RenameColumn(
                name: "DzimšanasDatums",
                table: "Iedzivotajs",
                newName: "DzimsanasDatums");

            migrationBuilder.RenameColumn(
                name: "Stāvs",
                table: "Dzivoklis",
                newName: "Stavs");

            migrationBuilder.RenameColumn(
                name: "PilnaPlatība",
                table: "Dzivoklis",
                newName: "PilnaPlatiba");

            migrationBuilder.RenameColumn(
                name: "MājaId",
                table: "Dzivoklis",
                newName: "MajaId");

            migrationBuilder.RenameColumn(
                name: "IedzīvotājuSkaits",
                table: "Dzivoklis",
                newName: "IedzivotajuSkaits");

            migrationBuilder.RenameColumn(
                name: "DzīvojamāPlatība",
                table: "Dzivoklis",
                newName: "DzivojamaPlatiba");

            migrationBuilder.RenameIndex(
                name: "IX_Dzivoklis_MājaId",
                table: "Dzivoklis",
                newName: "IX_Dzivoklis_MajaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Dzivoklis_Majas_MajaId",
                table: "Dzivoklis",
                column: "MajaId",
                principalTable: "Majas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dzivoklis_Majas_MajaId",
                table: "Dzivoklis");

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

            migrationBuilder.RenameColumn(
                name: "Vards",
                table: "Iedzivotajs",
                newName: "Vārds");

            migrationBuilder.RenameColumn(
                name: "Uzvards",
                table: "Iedzivotajs",
                newName: "Uzvārds");

            migrationBuilder.RenameColumn(
                name: "DzimsanasDatums",
                table: "Iedzivotajs",
                newName: "DzimšanasDatums");

            migrationBuilder.RenameColumn(
                name: "Stavs",
                table: "Dzivoklis",
                newName: "Stāvs");

            migrationBuilder.RenameColumn(
                name: "PilnaPlatiba",
                table: "Dzivoklis",
                newName: "PilnaPlatība");

            migrationBuilder.RenameColumn(
                name: "MajaId",
                table: "Dzivoklis",
                newName: "MājaId");

            migrationBuilder.RenameColumn(
                name: "IedzivotajuSkaits",
                table: "Dzivoklis",
                newName: "IedzīvotājuSkaits");

            migrationBuilder.RenameColumn(
                name: "DzivojamaPlatiba",
                table: "Dzivoklis",
                newName: "DzīvojamāPlatība");

            migrationBuilder.RenameIndex(
                name: "IX_Dzivoklis_MajaId",
                table: "Dzivoklis",
                newName: "IX_Dzivoklis_MājaId");

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimšanasDatums", "Email", "PersonasKods", "Telefons", "Uzvārds", "Vārds" },
                values: new object[,]
                {
                    { new Guid("3996b39f-eaeb-40d0-9a49-9789303633e0"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("52d10a1f-c772-4537-858c-3a763814bcc1"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" },
                    { new Guid("78cdec54-9f51-4208-89b6-b7925d5afbf6"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("a4d351a9-fd2d-4f6c-8903-ef0382f5a326"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilseta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("4e702613-344b-4ca0-92bd-d36d68d8d3bb"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" },
                    { new Guid("83b51930-e6b7-462a-ae56-26592e479997"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("28edc461-47d2-4a65-a851-908e45c5cb2b"), 45.0, 1, 2, new Guid("83b51930-e6b7-462a-ae56-26592e479997"), "3", 50.0, 3 },
                    { new Guid("94438f34-c1f7-4738-9828-8e6095da10d0"), 75.0, 3, 4, new Guid("4e702613-344b-4ca0-92bd-d36d68d8d3bb"), "2", 100.0, 2 },
                    { new Guid("d6ff55ce-5bd4-4100-93e1-08dbf9a3b94e"), 100.0, 4, 5, new Guid("83b51930-e6b7-462a-ae56-26592e479997"), "4", 120.0, 4 },
                    { new Guid("e3824036-e427-41c5-9080-ed5e8832d413"), 65.0, 2, 3, new Guid("4e702613-344b-4ca0-92bd-d36d68d8d3bb"), "5", 85.0, 5 },
                    { new Guid("f9be9311-fb0f-4a66-ad86-5f8b561deb90"), 60.5, 2, 3, new Guid("83b51930-e6b7-462a-ae56-26592e479997"), "1", 80.5, 1 }
                });

            migrationBuilder.InsertData(
                table: "DzivoklisIedzivotaji",
                columns: new[] { "Id", "DzivoklisId", "IedzivotajsId", "IsOwner" },
                values: new object[,]
                {
                    { new Guid("269e8965-b32e-4f32-87d1-e8b787a3e2b1"), new Guid("f9be9311-fb0f-4a66-ad86-5f8b561deb90"), new Guid("3996b39f-eaeb-40d0-9a49-9789303633e0"), true },
                    { new Guid("4f43c72e-f040-47a1-869d-dc97a073a12e"), new Guid("28edc461-47d2-4a65-a851-908e45c5cb2b"), new Guid("3996b39f-eaeb-40d0-9a49-9789303633e0"), false },
                    { new Guid("6f760325-6309-44f5-b13d-55aa7167a843"), new Guid("f9be9311-fb0f-4a66-ad86-5f8b561deb90"), new Guid("52d10a1f-c772-4537-858c-3a763814bcc1"), false },
                    { new Guid("7e381743-25e9-40f9-86ac-0b34f33650ce"), new Guid("94438f34-c1f7-4738-9828-8e6095da10d0"), new Guid("3996b39f-eaeb-40d0-9a49-9789303633e0"), true }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Dzivoklis_Majas_MājaId",
                table: "Dzivoklis",
                column: "MājaId",
                principalTable: "Majas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
