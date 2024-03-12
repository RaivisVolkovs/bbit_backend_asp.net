using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DzivoklisIedzivotajs");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_DzivoklisIedzivotajs_IedzivotajiId",
                table: "DzivoklisIedzivotajs",
                column: "IedzivotajiId");
        }
    }
}
