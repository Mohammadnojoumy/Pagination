using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pagination.Migrations
{
    public partial class AddSeedDataToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Age", "CreateDate", "Family", "Name" },
                values: new object[,]
                {
                    { 1, 21, new DateTime(2022, 2, 5, 23, 46, 28, 167, DateTimeKind.Local).AddTicks(6918), "Nojoumy", "Mohammad" },
                    { 2, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(6799), "Saei", "Ali" },
                    { 3, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(6960), "Rezaei", "Hosein" },
                    { 4, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(6987), "Khani", "Arash" },
                    { 5, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(7009), "Sami", "Saeed" },
                    { 6, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(7026), "Ghari", "Sahar" },
                    { 7, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(7050), "Samiei", "Shima" },
                    { 8, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(7066), "Bahari", "Zahra" },
                    { 9, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(7084), "Asghari", "Fatemeh" },
                    { 10, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(7102), "Abdi", "Sofia" },
                    { 11, 21, new DateTime(2022, 2, 5, 23, 46, 28, 184, DateTimeKind.Local).AddTicks(7120), "Irani", "Hanie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
