using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LlanoApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddResourceState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ResourceStates",
                columns: new[] { "Id", "CreateDate", "State", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6475), "required", new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6474) },
                    { 2, new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6478), "Discarded", new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6477) },
                    { 3, new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6479), "Refused", new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6479) }
                });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6360), new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6364), new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6368), new DateTime(2024, 7, 31, 15, 47, 49, 806, DateTimeKind.Local).AddTicks(6367) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResourceStates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ResourceStates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ResourceStates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4124), new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4129), new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4133), new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4135), new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4134) });
        }
    }
}
