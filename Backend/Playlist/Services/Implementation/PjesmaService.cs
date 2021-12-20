using Microsoft.EntityFrameworkCore;
using Playlist.Data;
using Playlist.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.Services.Implementation
{
    public class PjesmaService : IPjesmaService
    {
        private readonly PlaylistContext _context;
        public PjesmaService(PlaylistContext context)
        {
            _context = context;
        }

        public async Task<Pjesma> AddPjesmaAsync(Pjesma p)
        {
            
            try
            {
                var track = await _context.Pjesma.AddAsync(p);
                var entity = track.Entity;
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        public async Task<Pjesma> DeletePjesma(int id)
        {
            try
            {
                var pjesma = await GetPjesmaByIdAsync(id);
                var track = _context.Pjesma.Remove(pjesma);
                var entity = track.Entity;
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Pjesma> GetPjesmaByIdAsync(int id)
        {
            var pjesma = await _context.Pjesma.Include(p => p.Kategorija).SingleOrDefaultAsync(p => p.Id == id);
            return pjesma;
        }

        public async Task<IEnumerable<Pjesma>> GetPjesmeAsync()
        {
            var pjesme = await _context.Pjesma.Include(p => p.Kategorija).OrderByDescending(p=>p.DatumUnosa).ToListAsync();
            return pjesme;
        }

        public async Task<bool> UpdatePjesmaAsync(int id, Pjesma pjesma)
        {
            var pjesmaDb = await GetPjesmaByIdAsync(id);
            if (pjesmaDb == null || pjesma?.Ocjena > 5 || pjesma?.Ocjena < 1)
                return false;

            pjesmaDb.DatumUnosa = pjesma.DatumUnosa;
            pjesmaDb.DatumEditovanja = DateTime.Now;
            pjesmaDb.JeLiFavorit = pjesma.JeLiFavorit;
            pjesmaDb.KategorijaId = pjesma.KategorijaId;
            pjesmaDb.Naziv = pjesma.Naziv;
            pjesmaDb.NazivIzvodjaca = pjesma.NazivIzvodjaca;
            pjesmaDb.Ocjena = pjesma.Ocjena;
            pjesmaDb.Url = pjesma.Url;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
