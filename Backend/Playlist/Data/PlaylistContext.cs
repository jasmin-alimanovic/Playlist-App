using Microsoft.EntityFrameworkCore;
using Playlist.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.Data
{
    public class PlaylistContext : DbContext
    {
        public DbSet<Pjesma> Pjesma { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }

        public PlaylistContext(DbContextOptions<PlaylistContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Pjesma>().HasKey(p => p.Id);
            modelBuilder.Entity<Pjesma>().HasOne(p => p.Kategorija).WithMany(k => k.Pjesme);
            modelBuilder.Entity<Pjesma>().Property(p => p.Ocjena).IsRequired(false);

            modelBuilder.Entity<Kategorija>().HasKey(k => k.Id);

            modelBuilder.Entity<Kategorija>().HasData(
                new Kategorija { Id = 2, Naziv = "Pop"},
                new Kategorija { Id = 3, Naziv = "Rock"},
                new Kategorija { Id = 4, Naziv = "Narodna"},
                new Kategorija { Id = 5, Naziv = "Jazz"},
                new Kategorija { Id = 6, Naziv = "Heavy metal"},
                new Kategorija { Id = 7, Naziv = "Klasična"},
                new Kategorija { Id = 8, Naziv = "Turbofolk"},
                new Kategorija { Id = 9, Naziv = "Rep"},
                new Kategorija { Id = 10, Naziv = "Reggae"}
                );

            modelBuilder.Entity<Pjesma>().HasData(
                new Pjesma
                {
                    Id = 1,
                    Naziv = "Mlada i luda",
                    JeLiFavorit = false,
                    DatumUnosa = DateTime.Now,
                    DatumEditovanja = DateTime.Now,
                    KategorijaId = 9,
                    NazivIzvodjaca = "Jala Brat",
                    Url = "https://www.youtube.com/embed/ReStoDAdsc8",
                    Ocjena=5
                },
                new Pjesma
                {
                    Id = 2,
                    Naziv = "99",
                    JeLiFavorit = false,
                    DatumUnosa = DateTime.Now,
                    DatumEditovanja = DateTime.Now,
                    KategorijaId = 9,
                    NazivIzvodjaca = "Jala Brat",
                    Url = "https://www.youtube.com/embed/Zx_y2R5xJCQ",
                    Ocjena = 5
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
