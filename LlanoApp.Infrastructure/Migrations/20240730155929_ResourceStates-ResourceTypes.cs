using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LlanoApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ResourceStatesResourceTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ResourceStates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "State", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 59, 28, 840, DateTimeKind.Local).AddTicks(129), "requested", new DateTime(2024, 7, 30, 10, 59, 28, 840, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "ResourceStates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "State", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 59, 28, 840, DateTimeKind.Local).AddTicks(131), "rejected", new DateTime(2024, 7, 30, 10, 59, 28, 840, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "ResourceStates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "State", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 59, 28, 840, DateTimeKind.Local).AddTicks(134), "approved", new DateTime(2024, 7, 30, 10, 59, 28, 840, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "TypeName", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 59, 28, 839, DateTimeKind.Local).AddTicks(9831), "Legend", new DateTime(2024, 7, 30, 10, 59, 28, 839, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "TypeName", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 59, 28, 839, DateTimeKind.Local).AddTicks(9835), "word", new DateTime(2024, 7, 30, 10, 59, 28, 839, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "TypeName", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 59, 28, 839, DateTimeKind.Local).AddTicks(9838), "couplet", new DateTime(2024, 7, 30, 10, 59, 28, 839, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "TypeName", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 59, 28, 839, DateTimeKind.Local).AddTicks(9840), "proverb", new DateTime(2024, 7, 30, 10, 59, 28, 839, DateTimeKind.Local).AddTicks(9840) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ResourceStates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "State", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5261), "Solicitado", new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "ResourceStates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "State", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5264), "Descartado", new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "ResourceStates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "State", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5267), "Aprobado", new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "TypeName", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5038), "Leyenda", new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "TypeName", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5043), "Palabras", new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "TypeName", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5046), "Coplas", new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "ResourceTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "TypeName", "UpdateDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5048), "Refranes", new DateTime(2024, 7, 30, 10, 46, 54, 31, DateTimeKind.Local).AddTicks(5047) });
        }
    }
}
