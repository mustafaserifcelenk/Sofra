using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sofra.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TableId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationTable");

            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(5325), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6465), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6467), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6468), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6469), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6470), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6472), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6474), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6475), new DateTime(2024, 2, 12, 1, 21, 15, 1, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_TableId",
                table: "Reservations",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Tables_TableId",
                table: "Reservations",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Tables_TableId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_TableId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Reservations");

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

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6556), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6558), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationTable_TablesId",
                table: "ReservationTable",
                column: "TablesId");
        }
    }
}
