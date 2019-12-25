using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountOwnerServer.Migrations
{
    public partial class Migration_V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[] { new Guid("6abd6601-b231-47d7-84c3-b638ae0db041"), "AP", new DateTime(1988, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Som" });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[] { new Guid("4b750306-d53d-4f08-b842-c44c10d5cc84"), "TS", new DateTime(1986, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naidu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4b750306-d53d-4f08-b842-c44c10d5cc84"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6abd6601-b231-47d7-84c3-b638ae0db041"));
        }
    }
}
