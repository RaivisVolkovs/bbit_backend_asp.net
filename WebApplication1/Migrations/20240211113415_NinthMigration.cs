using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class NinthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "DzivoklisIedzivotaji",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DzivoklisIedzivotaji",
                table: "DzivoklisIedzivotaji",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DzivoklisIedzivotaji",
                table: "DzivoklisIedzivotaji");

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
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("03b15a19-0319-4c43-9698-a527a75f9858"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("42627976-4310-49fc-9a4c-98374e563adc"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("9d952995-ca43-4710-8ac6-cbdc1b682d5d"));

            migrationBuilder.DeleteData(
                table: "DzivoklisIedzivotaji",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DzivoklisIedzivotaji");

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
    }
}
