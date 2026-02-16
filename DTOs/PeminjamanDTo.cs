using System;
namespace PeminjamanRuanganBackend.DTOs
{
    public class PeminjamanRequestDto
    {
        public string NamaPeminjam { get; set; } = string.Empty;
        public string Ruangan { get; set; } = string.Empty;
        public DateTime TanggalPinjam { get; set; }
        public DateTime TanggalKembali { get; set; }
        public string Status { get; set; } = string.Empty;
    }

    public class PeminjamanResponseDto
    {
        public int Id { get; set; }
        public string NamaPeminjam { get; set; } = string.Empty;
        public string Ruangan { get; set; } = string.Empty;
        public DateTime TanggalPinjam { get; set; }
        public DateTime TanggalKembali { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
