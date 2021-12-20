using Microsoft.EntityFrameworkCore;
using Playlist.Data;
using Playlist.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.Services.Implementation
{
    public class KategorijaService : IKategorijaService
    {
        private readonly PlaylistContext _context;
        public KategorijaService(PlaylistContext context)
        {
            _context = context;
        }

        public async Task<Kategorija> AddKategorijaAsync(Kategorija k)
        {
            try
            {
                var track = await _context.Kategorija.AddAsync(k);
                var entity = track.Entity;
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {

                return null;
            }
        }



        public async Task<Kategorija> GetKategorijaByIdAsync(int id)
        {
            var kategorija = await _context.Kategorija.SingleOrDefaultAsync(p => p.Id == id);
            return kategorija;
        }

        public async Task<IEnumerable<Kategorija>> GetKategorijeAsync()
        {
            var kategorije = await _context.Kategorija.ToListAsync();
            return kategorije;
        }

    }
}
