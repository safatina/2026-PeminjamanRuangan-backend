using Microsoft.AspNetCore.Mvc;
using PeminjamanRuanganBackend.Models;
using PeminjamanRuanganBackend.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeminjamanRuanganBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeminjamanController : ControllerBase
    {
        private readonly PeminjamanService _service;

        public PeminjamanController(PeminjamanService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Peminjaman>>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Peminjaman>> GetById(int id)
        {
            var p = await _service.GetByIdAsync(id);
            if (p == null) return NotFound();
            return p;
        }

        [HttpPost]
        public async Task<ActionResult<Peminjaman>> Create(Peminjaman peminjaman)
        {
            var created = await _service.AddAsync(peminjaman);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Peminjaman peminjaman)
        {
            if (id != peminjaman.Id) return BadRequest();
            await _service.UpdateAsync(peminjaman);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
