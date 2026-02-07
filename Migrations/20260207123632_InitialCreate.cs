using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2026_PeminjamanRuangan_backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peminjamans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaPeminjam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ruangan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TanggalPinjam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TanggalKembali = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peminjamans", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peminjamans");
        }
    }
}
