using System;

namespace PeminjamanRuanganBackend.Models
{
    public class Peminjaman
    {
        public int Id { get; set; }
        public required string NamaPeminjam { get; set; }
        public required string Ruangan { get; set; }
        public DateTime TanggalPinjam { get; set; }
        public DateTime TanggalKembali { get; set; }
        public required string Status { get; set; } 
    }
}
