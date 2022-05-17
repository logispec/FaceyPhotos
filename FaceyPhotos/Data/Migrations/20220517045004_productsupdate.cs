using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class productsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "details",
                table: "Products",
                newName: "Details");

            migrationBuilder.AlterColumn<float>(
                name: "price",
                table: "Sales",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Cost",
                table: "Products",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "297c4ccd-7f45-4328-9f30-42241130b41d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "8d805ca6-6844-449f-8a41-88a6f04b3880");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1f96bfb-1bc9-4881-adff-2aca8f181648", "AQAAAAEAACcQAAAAEGpaMqbdLGJhkOWkWP3Gw2duOtnJhb4zj4FCd7EPbZSGnqF9jJ2SR+6II+Q/RfXPJg==", "ce408545-acd2-4963-b382-0c8fdaf919c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f4bba4b-4dd9-4d14-b796-74bf3fec8138", "AQAAAAEAACcQAAAAEPP60eE2lhy35so3r3gctJSLx5WWxJzyFYpcqAjOqpkb7ayOZ9qAN95ZhGjB4EHoJw==", "42969a2e-143a-4e28-8d41-0bccdff2b720" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Details",
                table: "Products",
                newName: "details");

            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "Sales",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Cost",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "9da63f6c-19bb-4e00-bf09-163aba28a744");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "14b6be2f-d47e-4fcb-b02c-af5ed986a252");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6b96eeb-0cda-4e01-9b43-86e8e06592a5", "AQAAAAEAACcQAAAAEDcftg5PIZIfZocc2fAisyXILJH3oMmWDA1TEq2qfubn6vhRnuhg1tcYwBDhNlR7cw==", "4eaeab12-0b25-4ae5-9b93-6e7e221d07e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "182ec953-14af-41b9-87c4-1955219cceb8", "AQAAAAEAACcQAAAAEGoakDFVvNibBAjHOk6IAPCs8CP7gwcLioilHX5AxwN3VwpdCaYK8QzmwCM/XIUD5Q==", "5de86618-4d9e-4fb8-a818-d02e713f676b" });
        }
    }
}
