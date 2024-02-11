using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sofra.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TableId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CustomerCount = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationTable",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    TablesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationTable", x => new { x.ReservationId, x.TablesId });
                    table.ForeignKey(
                        name: "FK_ReservationTable_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationTable_Tables_TablesId",
                        column: x => x.TablesId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Email", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "Phone", "TableId" },
                values: new object[] { 1, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6208), "johnDoe@mail.com", true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6218), "John Doe", null, "1234567890", null });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Capacity", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note" },
                values: new object[,]
                {
                    { 1, 4, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6546), true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6547), null },
                    { 2, 6, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6551), true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6551), null },
                    { 3, 4, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6552), true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6552), null },
                    { 4, 6, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6553), true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6554), null },
                    { 5, 5, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6555), true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6555), null },
                    { 6, 4, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6556), true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6556), null },
                    { 7, 4, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6557), true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6557), null },
                    { 8, 3, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6558), true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6558), null },
                    { 9, 2, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6559), true, false, "Admin", new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6560), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TableId",
                table: "Customers",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationTable_TablesId",
                table: "ReservationTable",
                column: "TablesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationTable");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Tables");
        }
    }
}
