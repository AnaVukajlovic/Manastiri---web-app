using System.Collections.Generic;
using System.Linq;
using NemanjiciWebApp.Models;

namespace NemanjiciWebApp.Data
{
    public static class ProizvodRepozitorijum
    {
        private static List<Proizvod> _proizvodi = new List<Proizvod>
        {
            new Proizvod
            {
                Id = 1,
                Naziv = "Knjiga: Dinastija Nemanjića",
                Opis = "Ilustrovana knjiga o istoriji dinastije Nemanjića, prilagođena široj publici.",
                Cena = 1999.99m,
                Kategorija = "Knjige",
                PutanjaSlike = "/slike/proizvodi/knjiga-nemanjici.jpg"
            },
            new Proizvod
            {
                Id = 2,
                Naziv = "Poster: Manastir Studenica",
                Opis = "Dekorativni poster inspirisan arhitekturom i freskama manastira Studenica.",
                Cena = 1299.50m,
                Kategorija = "Posteri",
                PutanjaSlike = "/slike/proizvodi/poster-studenica.jpg"
            },
            new Proizvod
            {
                Id = 3,
                Naziv = "Suvenir: Grb Nemanjića",
                Opis = "Dekorativni grb dinastije Nemanjića, idealan kao poklon ili ukras.",
                Cena = 2499.00m,
                Kategorija = "Suveniri",
                PutanjaSlike = "/slike/proizvodi/grb-nemanjici.jpg"
            }
        };

        public static List<Proizvod> VratiSve(string? kategorija = null, string? pretraga = null)
        {
            var query = _proizvodi.AsQueryable();

            if (!string.IsNullOrWhiteSpace(kategorija))
            {
                query = query.Where(p => p.Kategorija == kategorija);
            }

            if (!string.IsNullOrWhiteSpace(pretraga))
            {
                var lower = pretraga.ToLower();
                query = query.Where(p => p.Naziv.ToLower().Contains(lower));
            }

            return query.ToList();
        }

        public static Proizvod? VratiPoId(int id)
        {
            return _proizvodi.FirstOrDefault(p => p.Id == id);
        }

        public static List<string> VratiSveKategorije()
        {
            return _proizvodi
                .Select(p => p.Kategorija)
                .Distinct()
                .OrderBy(k => k)
                .ToList();
        }
    }
}
