using Microsoft.EntityFrameworkCore;
using PeminjamanRuanganBackend.Data;
using PeminjamanRuanganBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeminjamanRuanganBackend.Services
{
    public class PeminjamanService
    {
        private readonly AppDbContext _context;

        public PeminjamanService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Peminjaman>> GetAllAsync()
        {
            return await _context.Peminjamans.ToListAsync();
        }

        public async Task<Peminjaman?> GetByIdAsync(int id)
        {
            return await _context.Peminjamans.FindAsync(id);
        }

        public async Task<Peminjaman> AddAsync(Peminjaman peminjaman)
        {
            _context.Peminjamans.Add(peminjaman);
            await _context.SaveChangesAsync();
            return peminjaman;
        }

        public async Task<Peminjaman> UpdateAsync(Peminjaman peminjaman)
        {
            _context.Peminjamans.Update(peminjaman);
            await _context.SaveChangesAsync();
            return peminjaman;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var peminjaman = await _context.Peminjamans.FindAsync(id);
            if (peminjaman == null) return false;

            _context.Peminjamans.Remove(peminjaman);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
