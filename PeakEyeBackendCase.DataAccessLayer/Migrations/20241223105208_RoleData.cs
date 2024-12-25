using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PeakEyeBackendCase.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class RoleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "548e38af-ec11-4466-a769-b18878ee4fcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64ebc7e2-642c-4dc5-a419-114516578d58");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b6879cd-4903-4ac3-a480-a27865d40ca4", null, "Admin Role", "Admin", "ADMIN" },
                    { "9d9f9006-0d83-4001-abc6-1e420486a21c", null, "User Role", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b6879cd-4903-4ac3-a480-a27865d40ca4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d9f9006-0d83-4001-abc6-1e420486a21c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "548e38af-ec11-4466-a769-b18878ee4fcf", null, "User Role", "User", "USER" },
                    { "64ebc7e2-642c-4dc5-a419-114516578d58", null, "Admin Role", "Admin", "ADMIN" }
                });
        }
    }
}
