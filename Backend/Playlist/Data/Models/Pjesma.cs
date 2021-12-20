using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.Data.Models
{
    /**
     * -	Pjesma objekat treba da ima sljedeće atribute: naziv pjesme, naziv izvođača, 
     *      url link za pjesmu, ocjena pjesme(od 1 do 5), da li je pjesma favorit, 
     *      datum unosa pjesme u aplikaciju, datum posljednjeg editovanja pjesme u aplikaciji, 
     *      kategoriju
     */
    public class Pjesma
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string NazivIzvodjaca { get; set; }
        public string Url { get; set; }
        [Range(1, 5)]
        public byte? Ocjena { get; set; }
        public bool JeLiFavorit { get; set; }
        public DateTime DatumUnosa { get; set; }
        public DateTime DatumEditovanja { get; set; }

        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }

        public Pjesma()
        {
            this.DatumUnosa = DateTime.Now;
            this.DatumEditovanja = DateTime.Now;
            this.JeLiFavorit = false;
            this.Ocjena = null;
        }
    }
}
