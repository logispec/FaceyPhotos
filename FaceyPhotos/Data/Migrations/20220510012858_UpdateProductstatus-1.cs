using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class UpdateProductstatus1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "5a9cfcf5-5ec3-414c-b5f7-45e520f40cb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "41a49771-efb4-4daa-a724-c018d4a19b48");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2609330-0fab-43ba-8551-08cd7d76b2e6", "AQAAAAEAACcQAAAAEB+hzHqf0UQyV+SpPZGosnUD22CuzDJ+9lKa0T+WVwFxOTa8KYdlVDqZbbfgyI5FoQ==", "b3327259-e874-4677-838d-6bce1994a559" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf3cc22d-a2f5-455a-a2ef-2a3daaa0529b", "AQAAAAEAACcQAAAAEGRuDVUAcxc4o/bMVaLMngsVC0nxK4DVSowP8b/qlJorlxOOVsfh+SkYk6wMWRIDMA==", "e59ca2b0-5d3d-42d5-84d6-2300bb6d3c7b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
