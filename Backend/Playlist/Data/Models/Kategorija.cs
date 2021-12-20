using System.Collections.Generic;

namespace Playlist.Data.Models
{
    public class Kategorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public ICollection<Pjesma> Pjesme { get; set; }
    }
}