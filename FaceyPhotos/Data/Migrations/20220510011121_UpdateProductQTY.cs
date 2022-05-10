using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class UpdateProductQTY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "5591de42-1220-4efb-9574-8b3c5f459be4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "a45942f8-c9af-4d9c-8bb1-37f6cd5997d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb564ab0-9de6-41af-8276-c56be01a2647", "AQAAAAEAACcQAAAAEO9GQxAY9M4Ck8MZn9RPGiJPVcU0xodxHKZI/SuxDGIA2rhrdwMC3ZXX+jF/1SCoMg==", "d70ee2be-83a8-4da3-9638-1ff50b499ab5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "095c1435-eeed-4f30-b68d-5c5a7464de5c", "AQAAAAEAACcQAAAAEE5R3A+bYJ7JuHAVcEtTFFBv3wpom5tRbXT6emeeCAV9lXWLNDz5/t/tAavV44753Q==", "68e22d8d-e973-4f27-9db1-8a8e754e9174" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

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
    }
}
