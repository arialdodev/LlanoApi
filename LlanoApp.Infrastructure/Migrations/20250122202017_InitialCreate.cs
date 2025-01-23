using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LlanoApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResourceStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceTypesId = table.Column<int>(type: "int", nullable: false),
                    ResourceStatesId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resource_ResourceStates_ResourceStatesId",
                        column: x => x.ResourceStatesId,
                        principalTable: "ResourceStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resource_ResourceTypes_ResourceTypesId",
                        column: x => x.ResourceTypesId,
                        principalTable: "ResourceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MessageHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourcesId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageHistories_Resource_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "Resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ResourceStates",
                columns: new[] { "Id", "CreateDate", "NameState", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6844), "Solicitado", new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6843) },
                    { 2, new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6850), "Descartado", new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6850) },
                    { 3, new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6854), "Aprobado", new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6853) }
                });

            migrationBuilder.InsertData(
                table: "ResourceTypes",
                columns: new[] { "Id", "CreateDate", "TypeName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6490), "Leyenda", new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6471) },
                    { 2, new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6494), "Palabra", new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6493) },
                    { 3, new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6497), "Copla", new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6496) },
                    { 4, new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6501), "Refran", new DateTime(2025, 1, 22, 15, 20, 15, 645, DateTimeKind.Local).AddTicks(6500) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MessageHistories_ResourcesId",
                table: "MessageHistories",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ResourceStatesId",
                table: "Resource",
                column: "ResourceStatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ResourceTypesId",
                table: "Resource",
                column: "ResourceTypesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageHistories");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "ResourceStates");

            migrationBuilder.DropTable(
                name: "ResourceTypes");
        }
    }
}
