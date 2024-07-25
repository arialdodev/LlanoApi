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
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceTypesId = table.Column<int>(type: "int", nullable: false),
                    ResourceStatesId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resources_ResourceStates_ResourceStatesId",
                        column: x => x.ResourceStatesId,
                        principalTable: "ResourceStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resources_ResourceTypes_ResourceTypesId",
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
                        name: "FK_MessageHistories_Resources_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ResourceTypes",
                columns: new[] { "Id", "CreateDate", "TypeName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4124), "Leyenda", new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4035) },
                    { 2, new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4129), "Palabras", new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4129) },
                    { 3, new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4133), "Coplas", new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4132) },
                    { 4, new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4135), "Refranes", new DateTime(2024, 7, 24, 15, 7, 45, 945, DateTimeKind.Local).AddTicks(4134) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MessageHistories_ResourcesId",
                table: "MessageHistories",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ResourceStatesId",
                table: "Resources",
                column: "ResourceStatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ResourceTypesId",
                table: "Resources",
                column: "ResourceTypesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageHistories");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "ResourceStates");

            migrationBuilder.DropTable(
                name: "ResourceTypes");
        }
    }
}
