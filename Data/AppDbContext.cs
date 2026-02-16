using Microsoft.EntityFrameworkCore;
using PeminjamanRuanganBackend.Models;

namespace PeminjamanRuanganBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Peminjaman> Peminjamans { get; set; }
    }

    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.Migrate();

            if (!context.Peminjamans.Any())
            {
                context.Peminjamans.Add(new Peminjaman
                {
                    NamaPeminjam = "Safa",
                    Ruangan = "Lab A",
                    TanggalPinjam = DateTime.Now,
                    TanggalKembali = DateTime.Now.AddDays(1),
                    Status = "Disetujui"
                });

                context.Peminjamans.Add(new Peminjaman
                {
                    NamaPeminjam = "Budi",
                    Ruangan = "Lab B",
                    TanggalPinjam = DateTime.Now,
                    TanggalKembali = DateTime.Now.AddDays(2),
                    Status = "Ditolak"
                });

                context.SaveChanges();
            }
        }
    }
}
