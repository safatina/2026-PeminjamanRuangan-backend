using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2026_PeminjamanRuangan_backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedPeminjaman : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Peminjamans",
                columns: new[] { "Id", "NamaPeminjam", "Ruangan", "Status", "TanggalKembali", "TanggalPinjam" },
                values: new object[,]
                {
                    { 1, "Safa", "Lab A", "Diterima", new DateTime(2026, 2, 11, 20, 46, 7, 671, DateTimeKind.Local).AddTicks(3462), new DateTime(2026, 2, 10, 20, 46, 7, 670, DateTimeKind.Local).AddTicks(1775) },
                    { 2, "Budi", "Lab B", "Ditolak", new DateTime(2026, 2, 12, 20, 46, 7, 671, DateTimeKind.Local).AddTicks(4319), new DateTime(2026, 2, 10, 20, 46, 7, 671, DateTimeKind.Local).AddTicks(4317) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Peminjamans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Peminjamans",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
