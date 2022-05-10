using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class UpdateProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "6645af95-8f74-45d4-a64c-f6d911e3747b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "9f27f5bb-856b-4500-9cb4-2c568de3adcf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77647938-7eb9-4112-bba5-4390042fee66", "AQAAAAEAACcQAAAAEKH+65qR3DmsPn/Wm8ZEFvj6eHza140VyMTmI2QXiiSld1soyuNXILFHB6Ej8j1IJg==", "c384a657-55e5-4962-8505-1dac1a16c174" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f71b6855-036e-40fa-98ee-40ebe5e78daf", "AQAAAAEAACcQAAAAEAztmliLSKi0O1tu/4JWyI+jZaX99vVNXlbOzyCEsE+bd54ro2T58qeB4rVwZFWIiQ==", "b1993ad8-22e2-4136-80bf-fae7ab0762b5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "345d85ff-21ad-4d92-afd0-94571aea528a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "5bf4b717-f4db-4525-8bf3-cb6d17f7eff6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f68b0986-1585-4d93-b95a-18de6a2a2ebb", "AQAAAAEAACcQAAAAEOLxLuMfpi2a04jj5fEhgdsaRNzGe6ephVjxWEGDYK+sYeClYQirkVwR3jdOP3swnA==", "45d8cea5-c843-4b4c-bc59-5aba913f2d47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5861d69-201e-4ecb-89ef-3341d28d4a99", "AQAAAAEAACcQAAAAEL3UwVL3nNSl+TTu0r1rGm1atth4m6+XoMEvZmlcKKvbaXXOgzp3QoJKL4nGx2mFSg==", "c1144b02-699b-4689-a37e-c3e567157289" });
        }
    }
}
