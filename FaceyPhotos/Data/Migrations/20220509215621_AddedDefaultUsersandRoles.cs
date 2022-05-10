using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaceyPhotos.Data.Migrations
{
    public partial class AddedDefaultUsersandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cc125dac-6afd-48b4-252f-887900e46b53", "345d85ff-21ad-4d92-afd0-94571aea528a", "User", "USER" },
                    { "cc388dac-6edd-64c4-263f-4845196e45c21", "5bf4b717-f4db-4525-8bf3-cb6d17f7eff6", "Webmaster", "WEBMASTER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedOn", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "Parish", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cc371dac-6edd-48c4-862f-466300e46c21", 0, null, "f68b0986-1585-4d93-b95a-18de6a2a2ebb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "webmaster@localhost.com", true, "Web", null, "Master", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WEBMASTER@LOCALHOST.COM", "WEBMASTER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEOLxLuMfpi2a04jj5fEhgdsaRNzGe6ephVjxWEGDYK+sYeClYQirkVwR3jdOP3swnA==", null, false, "45d8cea5-c843-4b4c-bc59-5aba913f2d47", false, "webmaster@localhost.com" },
                    { "d0d2aa73-1312-4ed7-b309-75b8563e8092", 0, null, "e5861d69-201e-4ecb-89ef-3341d28d4a99", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "client@localhost.com.com", true, "local", null, "client", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLIENT@LOCALHOST.COM", "CLIENT@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEL3UwVL3nNSl+TTu0r1rGm1atth4m6+XoMEvZmlcKKvbaXXOgzp3QoJKL4nGx2mFSg==", null, false, "c1144b02-699b-4689-a37e-c3e567157289", false, "client@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc388dac-6edd-64c4-263f-4845196e45c21", "cc371dac-6edd-48c4-862f-466300e46c21" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc125dac-6afd-48b4-252f-887900e46b53", "d0d2aa73-1312-4ed7-b309-75b8563e8092" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc388dac-6edd-64c4-263f-4845196e45c21", "cc371dac-6edd-48c4-862f-466300e46c21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc125dac-6afd-48b4-252f-887900e46b53", "d0d2aa73-1312-4ed7-b309-75b8563e8092" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc125dac-6afd-48b4-252f-887900e46b53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc388dac-6edd-64c4-263f-4845196e45c21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc371dac-6edd-48c4-862f-466300e46c21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0d2aa73-1312-4ed7-b309-75b8563e8092");
        }
    }
}
