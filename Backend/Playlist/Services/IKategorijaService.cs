using Playlist.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.Services
{
    public interface IKategorijaService
    {
        public Task<Kategorija >GetKategorijaByIdAsync(int id);
        public Task<IEnumerable<Kategorija>> GetKategorijeAsync();
        public Task<Kategorija> AddKategorijaAsync(Kategorija p);


    }
}
