using Playlist.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.Services
{
    public interface IPjesmaService
    {
        public Task<Pjesma >GetPjesmaByIdAsync(int id);
        public Task<IEnumerable<Pjesma>> GetPjesmeAsync();
        public Task<Pjesma> AddPjesmaAsync(Pjesma p);
        public Task<Pjesma> DeletePjesma(int id);
        public Task<bool> UpdatePjesmaAsync(int id, Pjesma pjesma);


    }
}
