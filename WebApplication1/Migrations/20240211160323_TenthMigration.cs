using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class TenthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("48a657fb-c2e5-44f8-8a98-c2c9c48d1abe"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("98f8b5ca-cde2-4ad4-a252-64a3c56fd1ce"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("03b15a19-0319-4c43-9698-a527a75f9858"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("42627976-4310-49fc-9a4c-98374e563adc"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("9d952995-ca43-4710-8ac6-cbdc1b682d5d"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyValue: new Guid("f2a0c174-0858-4603-80c5-c4366debb56c"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("70900368-3e74-4ec4-869c-0f500e993909"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("8872f6be-8b41-4688-b4c9-eaaaa3ddb7cc"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("52421b0d-6d68-4b33-9dde-76d720ada3e6"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("8f2d00b6-25f5-404f-9b4c-f96f01fcdea9"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("dbe69892-341a-4450-9eeb-d85998fccdf1"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("39fa67c2-35ff-4abe-9a53-dd08d48b5566"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("ae7a5a57-87f6-4245-988b-985f772b6176"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("2d025f32-ecad-412e-9acc-620cab218976"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("938af58b-fb1a-4f52-9ef4-78cc266e455d"));

            migrationBuilder.RenameColumn(
                name: "Pilsēta",
                table: "Majas",
                newName: "Pilseta");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Pilseta",
                table: "Majas",
                newName: "Pilsēta");

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimšanasDatums", "Email", "PersonasKods", "Telefons", "Uzvārds", "Vārds" },
                values: new object[,]
                {
                    { new Guid("39fa67c2-35ff-4abe-9a53-dd08d48b5566"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("70900368-3e74-4ec4-869c-0f500e993909"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" },
                    { new Guid("8872f6be-8b41-4688-b4c9-eaaaa3ddb7cc"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("ae7a5a57-87f6-4245-988b-985f772b6176"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilsēta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("2d025f32-ecad-412e-9acc-620cab218976"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" },
                    { new Guid("938af58b-fb1a-4f52-9ef4-78cc266e455d"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("48a657fb-c2e5-44f8-8a98-c2c9c48d1abe"), 65.0, 2, 3, new Guid("938af58b-fb1a-4f52-9ef4-78cc266e455d"), "5", 85.0, 5 },
                    { new Guid("52421b0d-6d68-4b33-9dde-76d720ada3e6"), 75.0, 3, 4, new Guid("938af58b-fb1a-4f52-9ef4-78cc266e455d"), "2", 100.0, 2 },
                    { new Guid("8f2d00b6-25f5-404f-9b4c-f96f01fcdea9"), 60.5, 2, 3, new Guid("2d025f32-ecad-412e-9acc-620cab218976"), "1", 80.5, 1 },
                    { new Guid("98f8b5ca-cde2-4ad4-a252-64a3c56fd1ce"), 100.0, 4, 5, new Guid("2d025f32-ecad-412e-9acc-620cab218976"), "4", 120.0, 4 },
                    { new Guid("dbe69892-341a-4450-9eeb-d85998fccdf1"), 45.0, 1, 2, new Guid("2d025f32-ecad-412e-9acc-620cab218976"), "3", 50.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "DzivoklisIedzivotaji",
                columns: new[] { "Id", "DzivoklisId", "IedzivotajsId", "IsOwner" },
                values: new object[,]
                {
                    { new Guid("03b15a19-0319-4c43-9698-a527a75f9858"), new Guid("8f2d00b6-25f5-404f-9b4c-f96f01fcdea9"), new Guid("ae7a5a57-87f6-4245-988b-985f772b6176"), false },
                    { new Guid("42627976-4310-49fc-9a4c-98374e563adc"), new Guid("dbe69892-341a-4450-9eeb-d85998fccdf1"), new Guid("39fa67c2-35ff-4abe-9a53-dd08d48b5566"), false },
                    { new Guid("9d952995-ca43-4710-8ac6-cbdc1b682d5d"), new Guid("52421b0d-6d68-4b33-9dde-76d720ada3e6"), new Guid("39fa67c2-35ff-4abe-9a53-dd08d48b5566"), true },
                    { new Guid("f2a0c174-0858-4603-80c5-c4366debb56c"), new Guid("8f2d00b6-25f5-404f-9b4c-f96f01fcdea9"), new Guid("39fa67c2-35ff-4abe-9a53-dd08d48b5566"), true }
                });
        }
    }
}
