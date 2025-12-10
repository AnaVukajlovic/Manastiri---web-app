using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using NemanjiciWebApp.Models;
using System.Text.Json;

namespace NemanjiciWebApp.Data
{
    public class KorpaSesija
    {
        private const string KljucKorpe = "Korpa";
        private readonly ISession _sesija;

        public KorpaSesija(ISession sesija)
        {
            _sesija = sesija;
        }

        public List<StavkaKorpe> VratiStavke()
        {
            var json = _sesija.GetString(KljucKorpe);
            if (string.IsNullOrEmpty(json))
                return new List<StavkaKorpe>();

            return JsonSerializer.Deserialize<List<StavkaKorpe>>(json) ?? new List<StavkaKorpe>();
        }

        private void Sacuvaj(List<StavkaKorpe> stavke)
        {
            var json = JsonSerializer.Serialize(stavke);
            _sesija.SetString(KljucKorpe, json);
        }

        public void DodajProizvod(Proizvod proizvod)
        {
            var stavke = VratiStavke();
            var postojeca = stavke.FirstOrDefault(s => s.ProizvodId == proizvod.Id);

            if (postojeca == null)
            {
                stavke.Add(new StavkaKorpe
                {
                    ProizvodId = proizvod.Id,
                    Naziv = proizvod.Naziv,
                    Cena = proizvod.Cena,
                    Kolicina = 1
                });
            }
            else
            {
                postojeca.Kolicina += 1;
            }

            Sacuvaj(stavke);
        }

        public void UkloniProizvod(int proizvodId)
        {
            var stavke = VratiStavke();
            var stavka = stavke.FirstOrDefault(s => s.ProizvodId == proizvodId);
            if (stavka != null)
            {
                stavke.Remove(stavka);
                Sacuvaj(stavke);
            }
        }

        public void Ocisti()
        {
            Sacuvaj(new List<StavkaKorpe>());
        }
    }
}
