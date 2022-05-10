using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class productId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "e50133c4-bf40-4334-9e10-90113eb615b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "4ce1299d-1ac1-487a-b9df-b4468dfb3e85");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e58533bb-78bb-4a0c-b97b-886c5322967f", "AQAAAAEAACcQAAAAEEVlTclta/HH9YRnCuMsvRQ9GViKugkrhJJZsaQsi9caBJJo4EjaNJgRq8IH+GszGg==", "fb2bb03a-4736-46d9-b2d6-1ed458cd8174" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77cc3708-0005-49d7-ae08-b4362771f245", "AQAAAAEAACcQAAAAEHmckv4cTi0OUzTUz8SD03Bg8tTNTUB+xbhdtaTGhb2Lb4Br3UBysZZ+BvNobB+cBw==", "c7025489-3464-4900-94cd-3ab3f0254265" });
        }
    }
}
