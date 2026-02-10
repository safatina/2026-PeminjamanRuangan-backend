using Microsoft.EntityFrameworkCore;
using PeminjamanRuanganBackend.Models;

namespace PeminjamanRuanganBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Peminjaman> Peminjamans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Data seeding contoh
            modelBuilder.Entity<Peminjaman>().HasData(
                new Peminjaman
                {
                    Id = 1,
                    NamaPeminjam = "Safa",
                    Ruangan = "Lab A",
                    TanggalPinjam = DateTime.Now,
                    TanggalKembali = DateTime.Now.AddDays(1),
                    Status = "Diterima"
                },
                new Peminjaman
                {
                    Id = 2,
                    NamaPeminjam = "Budi",
                    Ruangan = "Lab B",
                    TanggalPinjam = DateTime.Now,
                    TanggalKembali = DateTime.Now.AddDays(2),
                    Status = "Ditolak"
                }
            );
        }
    }
}
