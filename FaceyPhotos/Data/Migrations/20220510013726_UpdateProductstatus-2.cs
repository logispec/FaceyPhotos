using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class UpdateProductstatus2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53",
                column: "ConcurrencyStamp",
                value: "05db58ab-666b-414c-9816-419b2ecad285");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21",
                column: "ConcurrencyStamp",
                value: "1ed85aa8-2d01-45de-a5f1-a8f728307ebf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bad97ea-d520-4d73-9175-9d3cdcb75955", "AQAAAAEAACcQAAAAELJRK2g3eng1D6G0TN3oyHA9FYQXwOhLYyBm22IhfgP7/vy502OL6s00pdjVf5/jgg==", "2f87e222-66a9-4172-a204-75135d96a776" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63a9655f-0bbe-4250-9c8a-f01ce834891d", "AQAAAAEAACcQAAAAEAW3w04v0usgh0KCa/MJDYvy+D0sjozbOwLqrKC7f9jhyoq9gZYNKWM835HmVG9b6A==", "ea4e9b87-9943-495c-8ca9-c8d61defa904" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Services",
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
    }
}
