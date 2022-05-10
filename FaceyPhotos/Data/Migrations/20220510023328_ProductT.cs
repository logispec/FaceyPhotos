using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class ProductT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "bf22ea9d-a174-4820-9b07-68d4c3416d21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "83149db4-4cc1-4afe-a37e-d56dc8238c8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc2a2dd5-a3a0-4c1f-99fb-de3cac26a3fc", "AQAAAAEAACcQAAAAEGg/BtJ1v+IwBzFpikYuW4+eANOZCNia+h88/ZzhzGFspDpc/Wq68K/CeHqUTJVilQ==", "a49392f2-adb0-41c3-acc8-219f00d54c58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ec4437d-936f-497a-8917-23363d86a4e9", "AQAAAAEAACcQAAAAEE4tgUdpU3E3VunVC3e0JZJeE2UvXh1v26Vsf0eLrJIcRW6O2jujTSmyD8sCsCZCTQ==", "3ad5b648-748c-4ba0-af1c-949cc625fcd6" });
        }
    }
}
