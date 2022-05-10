using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class productIdFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "99afcb5c-789f-4878-9964-98561462be89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "2812b4c3-b61b-40b5-a53f-73b162c7ffae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90d22257-035a-45e1-a8cb-cbb15124617e", "AQAAAAEAACcQAAAAEEKVb78nHDUYnJ8n28KQHYSce6o4C/k3widlBPckK0LR7GV8TwpQVbFg2z14n7i53Q==", "057e4763-6d6d-41f7-ad39-3e02418fe32d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b044270-9e27-4d4d-ad68-33c875517b87", "AQAAAAEAACcQAAAAEBk85fCfzNnMbsK2vKnLH02PWR9HdvV+spRkjjc/F5KAyWfY/Rr1YpYCsXkP3h1ipA==", "28f8b53d-0144-4c60-a10a-44c977f07588" });
        }
    }
}
