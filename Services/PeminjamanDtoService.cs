using Microsoft.EntityFrameworkCore;
using PeminjamanRuanganBackend.Data;
using PeminjamanRuanganBackend.DTOs;
using PeminjamanRuanganBackend.Mappers;
using PeminjamanRuanganBackend.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeminjamanRuanganBackend.Services
{
    public class PeminjamanDtoService
    {
        private readonly AppDbContext _context;

        public PeminjamanDtoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PeminjamanResponseDto> AddAsync(PeminjamanRequestDto dto)
        {
            var entity = PeminjamanMapper.ToEntity(dto);
            _context.Peminjamans.Add(entity);
            await _context.SaveChangesAsync();
            return PeminjamanMapper.ToDto(entity);
        }

        public async Task<List<PeminjamanResponseDto>> GetAllAsync()
        {
            var list = await _context.Peminjamans.ToListAsync();
            return list.Select(PeminjamanMapper.ToDto).ToList();
        }

        public async Task<PeminjamanResponseDto?> GetByIdAsync(int id)
        {
            var entity = await _context.Peminjamans.FindAsync(id);
            return entity == null ? null : PeminjamanMapper.ToDto(entity);
        }

        public async Task<bool> UpdateAsync(int id, PeminjamanRequestDto dto)
        {
            var entity = await _context.Peminjamans.FindAsync(id);
            if (entity == null) return false;

            entity.NamaPeminjam = dto.NamaPeminjam;
            entity.Ruangan = dto.Ruangan;
            entity.TanggalPinjam = dto.TanggalPinjam;
            entity.TanggalKembali = dto.TanggalKembali;
            entity.Status = dto.Status;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Peminjamans.FindAsync(id);
            if (entity == null) return false;

            _context.Peminjamans.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
