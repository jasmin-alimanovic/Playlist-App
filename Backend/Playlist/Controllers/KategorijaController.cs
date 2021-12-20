using Microsoft.AspNetCore.Mvc;
using Playlist.Data.Models;
using Playlist.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Playlist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorijaController : ControllerBase
    {
        private readonly IKategorijaService _kategorijaService;

        public KategorijaController(IKategorijaService kategorijaService)
        {
            _kategorijaService = kategorijaService;
        }

        // GET: api/<KategorijaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kategorija>>> GetAllKategorije()
        {
            var kategorije = await _kategorijaService.GetKategorijeAsync();
            return Ok(kategorije);
        }

        // GET api/<KategorijaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kategorija>> GetKategorijaById(int id)
        {
            var kategorije = await _kategorijaService.GetKategorijaByIdAsync(id);
            return Ok(kategorije);
        }

        // POST api/<KategorijaController>
        [HttpPost]
        public async Task<ActionResult<Kategorija>> Post([FromBody] Kategorija kategorija)
        {
            var created = await _kategorijaService.AddKategorijaAsync(kategorija);

            return CreatedAtAction(nameof(GetKategorijaById), new { id = created.Id }, created);
        }
    }
}
