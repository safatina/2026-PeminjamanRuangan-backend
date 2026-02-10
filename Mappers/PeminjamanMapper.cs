using PeminjamanRuanganBackend.Models;
using PeminjamanRuanganBackend.DTOs;

namespace PeminjamanRuanganBackend.Mappers
{
    public static class PeminjamanMapper
    {
        public static Peminjaman ToEntity(PeminjamanRequestDto dto)
        {
            return new Peminjaman
            {
                NamaPeminjam = dto.NamaPeminjam,
                Ruangan = dto.Ruangan,
                TanggalPinjam = dto.TanggalPinjam,
                TanggalKembali = dto.TanggalKembali,
                Status = dto.Status
            };
        }

        public static PeminjamanResponseDto ToDto(Peminjaman entity)
        {
            return new PeminjamanResponseDto
            {
                Id = entity.Id,
                NamaPeminjam = entity.NamaPeminjam,
                Ruangan = entity.Ruangan,
                TanggalPinjam = entity.TanggalPinjam,
                TanggalKembali = entity.TanggalKembali,
                Status = entity.Status
            };
        }
    }
}
