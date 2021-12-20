using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Playlist.Data.Models;
using Playlist.Services;
using Playlist.Services.Implementation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PjesmaController : ControllerBase
    {
        private readonly IPjesmaService _pjesmaService;

        public PjesmaController(IPjesmaService pjesmaService)
        {
            _pjesmaService = pjesmaService;
        }

        /**
         * 
         * <summary>
         * HTPP GET for retrieving songs in playlist
         * </summary>
         * <return>
         *  Ok Object with all songs in playlist
         * </return>
         */
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pjesma>>> GetAllSongs()
        {
            var pjesme = await _pjesmaService.GetPjesmeAsync();

            return Ok(pjesme);
        }

        /**
         * <summary>
         *  HTTP POST-- adds new song in playlist
         * </summary>
         * <return>
         *  if song is added return added song else return null
         * </return>
         */
        [HttpPost]
        public async Task<ActionResult<Pjesma>> CreateSong(Pjesma pjesma)
        {
            var createdSong = await _pjesmaService.AddPjesmaAsync(pjesma);
            return (createdSong != null) ? StatusCode(201) : BadRequest();
            //return CreatedAtAction(nameof(GetPjesmaByIdAsync), new { id = createdSong.Id });
        }

        /**
         * 
         * HTTP GET pjesma by id
         * 
         * <return>
         * object of type Pjesma which id equals provided id
         * </return>
         */
        [HttpGet("{id}")]
        public async Task<ActionResult<Pjesma>> GetPjesmaByIdAsync(int id)
        {
            var pjesma = await _pjesmaService.GetPjesmaByIdAsync(id);

            return Ok(pjesma);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePjesmaAsync(int id, Pjesma pjesma)
        {
            var isUpdated = await _pjesmaService.UpdatePjesmaAsync(id, pjesma);

            return isUpdated ? NoContent() : BadRequest();

        }

        // delete song
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pjesma>> DeleteSong(int id)
        {
            var createdSong = await _pjesmaService.DeletePjesma(id);
            return (createdSong != null) ? StatusCode(201) : BadRequest();
        }

    }
}
