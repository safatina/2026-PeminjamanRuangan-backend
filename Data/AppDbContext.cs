using Microsoft.EntityFrameworkCore;
using PeminjamanRuanganBackend.Models;

namespace PeminjamanRuanganBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Peminjaman> Peminjamans { get; set; }
    }
}
