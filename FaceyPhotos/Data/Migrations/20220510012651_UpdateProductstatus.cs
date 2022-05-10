using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class UpdateProductstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "details",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "39fb1a40-f418-4cf4-8db3-945984bd1372");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "e606787c-3426-4c51-b424-3d1022917cb7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70ee0a42-c184-4811-8687-9ef5688ba95c", "AQAAAAEAACcQAAAAEE6gmArnxIp8z+XOD4w5o/ki/kpdE4kqWgUuhGaFHW/wb5E8B4g78CZm80gPZqCb9Q==", "27b1ef8a-d538-4e8b-bcf6-4a417cb41520" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9a15a3b-b5ba-4af1-adf5-f77c135a15f2", "AQAAAAEAACcQAAAAENESmHlI2LM8HbZx/y1yv4TcgQQZKFoEmmeO1kwR6Q3N0Caps7JcRf7qJbdqHallEw==", "b21d9264-681e-491a-b2d6-4b92eceec559" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "details",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
