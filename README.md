## Deskripsi
Backend aplikasi Peminjaman Ruangan menggunakan ASP.NET dan Entity Framework Core.
Menyediakan CRUD API untuk entitas Peminjaman dengan data seeding.

## Fitur CRUD
| Endpoint             | Method | Keterangan                |
| -------------------- | ------ | ------------------------- |
| /api/peminjaman      | GET    | Ambil semua data          |
| /api/peminjaman/{id} | GET    | Ambil data berdasarkan ID |
| /api/peminjaman      | POST   | Tambah data baru          |
| /api/peminjaman/{id} | PUT    | Update data               |
| /api/peminjaman/{id} | DELETE | Hapus data                |

## Struktur Folder
Controllers/      → PeminjamanController.cs
Data/             → AppDbContext.cs (DbContext + seeding)
Models/           → Peminjaman.cs (entity)
DTOs/             → PeminjamanDto.cs
Mappers/          → PeminjamanMapper.cs
Services/         → PeminjamanService.cs, PeminjamanDtoService.cs
Migrations/       → Semua migration EF Core
Program.cs        → Konfigurasi ASP.NET Core

## Setup
1. Clone repo & masuk folder project
    git clone <repo-url>
    cd 2026-PeminjamanRuangan-backend
2. Update database dengan migration
    dotnet ef database update
3. Jalankan backend
    dotnet run

Server default: http://localhost:5112

## Contoh Request JSON
POST /api/peminjaman
{
  "NamaPeminjam": "Safa",
  "Ruangan": "Lab A",
  "TanggalPinjam": "2026-02-10T09:00:00",
  "TanggalKembali": "2026-02-11T09:00:00",
  "Status": "Diterima"
}

## Catatan
- Controller PeminjamanController sudah berjalan.
- DTO + Mapper telah tersedia 
- Data seeding otomatis menambahkan contoh data (Safa, Budi) saat pertama kali update database.