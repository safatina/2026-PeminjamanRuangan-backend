using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeminjamanRuanganBackend.Models
{
    public class Peminjaman
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public required string NamaPeminjam { get; set; }

        [Required]
        public required string Ruangan { get; set; }

        public DateTime TanggalPinjam { get; set; }
        public DateTime TanggalKembali { get; set; }

        public string Status { get; set; } = "Menunggu persetujuan";
    }
}
