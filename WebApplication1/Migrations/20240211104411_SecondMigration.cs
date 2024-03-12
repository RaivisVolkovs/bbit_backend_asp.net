using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("5fbd5544-1649-4a30-a8ed-e62ae2c7cca7"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("8475859a-4fe8-4378-bed7-7f46139afd01"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("855084e8-b5dd-4e25-be94-0be746943a4d"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("ab42599d-4941-4b3f-bbb6-fb428651147f"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("e9c55d2c-ba1f-4e62-b88d-c3f1fb0f44b6"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("3786154f-16b5-4eaa-8adf-c6e20040e5f2"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("676d8996-0905-4720-a595-3e683e0103d2"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("d1491dce-e6ef-43bc-8bde-82cdb829bfc9"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("fb035136-cc9b-4a10-b80d-409c7eca70db"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("45cf0829-dd58-4330-88fe-0efae1ea46fa"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("bfe6e213-a7cc-459c-9479-2fac7c0612eb"));

            migrationBuilder.DropColumn(
                name: "IsOwner",
                table: "Iedzivotajs");

            migrationBuilder.InsertData(
                table: "Iedzivotajs",
                columns: new[] { "Id", "DzimšanasDatums", "DzīvoklisId", "Email", "PersonasKods", "Telefons", "Uzvārds", "Vārds" },
                values: new object[,]
                {
                    { new Guid("29c2999c-0311-4f18-8f8b-fcd72cae016e"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("012bb24f-b21a-4b26-9d25-d403ed389418"), "janis@gmail.com", "123456-78910", "+371 12345678", "Bērziņš", "Jānis" },
                    { new Guid("42af43fa-5798-46b7-8edf-23ff44a273a0"), new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a43e231-c6f1-4420-af9e-248b0bce22df"), "liga@inbox.lv", "423456-78910", "+371 34567890", "Liepiņa", "Līga" },
                    { new Guid("44709782-b08c-48d4-82d7-7213b4bd8958"), new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0c474931-16db-476a-8645-6b1f57384eb4"), "peteris@gmail.com", "323456-78910", "+371 23456789", "Kalniņš", "Pēteris" },
                    { new Guid("47c72ced-3b1e-4958-a367-77ba3caaeac7"), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("012bb24f-b21a-4b26-9d25-d403ed389418"), "anna@inbox.lv", "223456-78910", "+371 87654321", "Zvaigzne", "Anna" }
                });

            migrationBuilder.InsertData(
                table: "Majas",
                columns: new[] { "Id", "Iela", "Numurs", "PastaIndekss", "Pilsēta", "Valsts" },
                values: new object[,]
                {
                    { new Guid("b0fcd38b-95a3-4d7a-bdc2-b9178f31ccbd"), "Lāčplēša iela", 2, "LV-1011", "Rīga", "Latvija" },
                    { new Guid("e0d14e6e-aa81-4e4d-aa1e-82208e105408"), "Brīvības iela", 1, "LV-1010", "Rīga", "Latvija" }
                });

            migrationBuilder.InsertData(
                table: "Dzivoklis",
                columns: new[] { "Id", "DzīvojamāPlatība", "IedzīvotājuSkaits", "IstabuSkaits", "MājaId", "Numurs", "PilnaPlatība", "Stāvs" },
                values: new object[,]
                {
                    { new Guid("012bb24f-b21a-4b26-9d25-d403ed389418"), 60.5, 2, 3, new Guid("e0d14e6e-aa81-4e4d-aa1e-82208e105408"), "1", 80.5, 1 },
                    { new Guid("039589bb-829b-4b4c-99ce-0fce21fbadff"), 75.0, 3, 4, new Guid("b0fcd38b-95a3-4d7a-bdc2-b9178f31ccbd"), "2", 100.0, 2 },
                    { new Guid("0c474931-16db-476a-8645-6b1f57384eb4"), 45.0, 1, 2, new Guid("e0d14e6e-aa81-4e4d-aa1e-82208e105408"), "3", 50.0, 3 },
                    { new Guid("2a43e231-c6f1-4420-af9e-248b0bce22df"), 100.0, 4, 5, new Guid("e0d14e6e-aa81-4e4d-aa1e-82208e105408"), "4", 120.0, 4 },
                    { new Guid("2c421cc5-0b42-4063-b80a-88c71c913415"), 65.0, 2, 3, new Guid("b0fcd38b-95a3-4d7a-bdc2-b9178f31ccbd"), "5", 85.0, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("012bb24f-b21a-4b26-9d25-d403ed389418"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("039589bb-829b-4b4c-99ce-0fce21fbadff"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("0c474931-16db-476a-8645-6b1f57384eb4"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("2a43e231-c6f1-4420-af9e-248b0bce22df"));

            migrationBuilder.DeleteData(
                table: "Dzivoklis",
                keyColumn: "Id",
                keyValue: new Guid("2c421cc5-0b42-4063-b80a-88c71c913415"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("29c2999c-0311-4f18-8f8b-fcd72cae016e"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("42af43fa-5798-46b7-8edf-23ff44a273a0"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("44709782-b08c-48d4-82d7-7213b4bd8958"));

            migrationBuilder.DeleteData(
                table: "Iedzivotajs",
                keyColumn: "Id",
                keyValue: new Guid("47c72ced-3b1e-4958-a367-77ba3caaeac7"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("b0fcd38b-95a3-4d7a-bdc2-b9178f31ccbd"));

            migrationBuilder.DeleteData(
                table: "Majas",
                keyColumn: "Id",
                keyValue: new Guid("e0d14e6e-aa81-4e4d-aa1e-82208e105408"));

            migrationBuilder.AddColumn<bool>(
                name: "IsOwner",
                table: "Iedzivotajs",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }
    }
}
