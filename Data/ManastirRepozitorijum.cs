using System.Collections.Generic;
using System.Linq;
using NemanjiciWebApp.Models;

namespace NemanjiciWebApp.Data
{
    public static class ManastirRepozitorijum
    {
        public static List<Manastir> VratiSve()
        {
            return new List<Manastir>
            {
                new Manastir
                {
                    Id = 1,
                    Naziv = "Студеница",
                    Ktitor = "Стефан Немања",
                    Period = "крај 12. века",
                    Lokacija = "kod Kraljeva",
                    KratakOpis = "Jedan od najznačajnijih manastira Nemanjića, poznat po belom mermeru i freskama.",
                    PutanjaSlike = "/slike/manastiri/studenica.jpg"
                },
                new Manastir
                {
                    Id = 2,
                    Naziv = "Сопоћани",
                    Ktitor = "Стефан Урош I",
                    Period = "13. век",
                    Lokacija = "kod Novog Pazara",
                    KratakOpis = "Poznat po freskama koje se ubrajaju među vrhunce srednjovekovnog slikarstva.",
                    PutanjaSlike = "/slike/manastiri/sopocani.jpg"
                },
                new Manastir
                {
                    Id = 3,
                    Naziv = "Раваница",
                    Ktitor = "кнез Лазар",
                    Period = "крај 14. века",
                    Lokacija = "kod Ćuprije",
                    KratakOpis = "Zadužbina kneza Lazara i važno mesto sećanja na Kosovsku bitku.",
                    PutanjaSlike = "/slike/manastiri/ravanica.jpg"
                },
                new Manastir
                {
                    Id = 4,
                    Naziv = "Хиландар",
                    Ktitor = "Св. Симеон и Св. Сава",
                    Period = "крај 12. века",
                    Lokacija = "Sveta Gora",
                    KratakOpis = "Jedan od glavnih duhovnih centara srpskog naroda na Svetoj Gori.",
                    PutanjaSlike = "/slike/manastiri/hilandar.jpg"
                },
                new Manastir
                {
                    Id = 5,
                    Naziv = "Грачаница",
                    Ktitor = "краљ Милутин",
                    Period = "почетак 14. века",
                    Lokacija = "kod Prištine",
                    KratakOpis = "Manastir kralja Milutina, primer razvijenog vizantijskog stila.",
                    PutanjaSlike = "/slike/manastiri/gracanica.jpg"
                },
                new Manastir
                {
                    Id = 6,
                    Naziv = "Манасија",
                    Ktitor = "деспот Стефан Лазаревић",
                    Period = "почетак 15. века",
                    Lokacija = "kod Despotovca",
                    KratakOpis = "Zadužbina despota Stefana, poznata po Resavskoj školi.",
                    PutanjaSlike = "/slike/manastiri/manasija.jpg"
                },
                new Manastir
                {
                    Id = 7,
                    Naziv = "Милешева",
                    Ktitor = "краљ Владислав",
                    Period = "13. век",
                    Lokacija = "kod Prijepolja",
                    KratakOpis = "Poznata po fresci „Beli anđeo“ i grobu Svetog Save.",
                    PutanjaSlike = "/slike/manastiri/mileseva.jpg"
                },
                new Manastir
                {
                    Id = 8,
                    Naziv = "Љубостиња",
                    Ktitor = "кнегиња Милица",
                    Period = "крај 14. века",
                    Lokacija = "kod Trstenika",
                    KratakOpis = "Ženski manastir povezan sa događajima posle Kosovske bitke.",
                    PutanjaSlike = "/slike/manastiri/ljubostinja.jpg"
                },
                new Manastir
                {
                    Id = 9,
                    Naziv = "Жича",
                    Ktitor = "Стефан Првовенчани и Св. Сава",
                    Period = "почетак 13. века",
                    Lokacija = "kod Kraljeva",
                    KratakOpis = "Kraljevski manastir i sedište prvih srpskih arhiepiskopa.",
                    PutanjaSlike = "/slike/manastiri/zica.jpg"
                },
                new Manastir
                {
                    Id = 10,
                    Naziv = "Градац",
                    Ktitor = "краљица Јелена Анжујска",
                    Period = "крај 13. века",
                    Lokacija = "kod Raške",
                    KratakOpis = "Primer spoja zapadnih i vizantijskih uticaja u arhitekturi.",
                    PutanjaSlike = "/slike/manastiri/gradac.jpg"
                },
                new Manastir
                {
                    Id = 11,
                    Naziv = "Лазарица",
                    Ktitor = "кнез Лазар",
                    Period = "крај 14. века",
                    Lokacija = "Kruševac",
                    KratakOpis = "Crkva Svetog Stefana u okviru Lazarevog dvora u Kruševcu.",
                    PutanjaSlike = "/slike/manastiri/lazarica.jpg"
                },
                new Manastir
                {
                    Id = 12,
                    Naziv = "Светог Ахилија",
                    Ktitor = "краљ Драгутин",
                    Period = "крај 13. века",
                    Lokacija = "Arilje",
                    KratakOpis = "Crkva u Arilju sa značajnim freskama vladara i svetitelja.",
                    PutanjaSlike = "/slike/manastiri/sveti-ahilije.jpg"
                },
                new Manastir
                {
                    Id = 13,
                    Naziv = "Рача",
                    Ktitor = "nepoznato (obnova u više navrata)",
                    Period = "srednji vek",
                    Lokacija = "kod Bajine Bašte",
                    KratakOpis = "Poznata po racanskim prepisivačima i očuvanju književnosti.",
                    PutanjaSlike = "/slike/manastiri/raca.jpg"
                },
                new Manastir
                {
                    Id = 14,
                    Naziv = "Високи Дечани",
                    Ktitor = "краљ Стефан Урош III Дечански",
                    Period = "14. век",
                    Lokacija = "kod Dečana",
                    KratakOpis = "UNESCO manastir sa velikim brojem očuvanih fresaka.",
                    PutanjaSlike = "/slike/manastiri/decani.jpg"
                },
                new Manastir
                {
                    Id = 15,
                    Naziv = "Бањска",
                    Ktitor = "краљ Милутин",
                    Period = "почетак 14. века",
                    Lokacija = "kod Kosovske Mitrovice",
                    KratakOpis = "Nekada reprezentativan kompleks, danas delimično očuvan.",
                    PutanjaSlike = "/slike/manastiri/banjska.jpg"
                },
                new Manastir
                {
                    Id = 16,
                    Naziv = "Бешеново",
                    Ktitor = "tradicionalno pripisano srpskim vladarima",
                    Period = "srednji vek",
                    Lokacija = "Fruška gora",
                    KratakOpis = "Jedan od fruškogorskih manastira sa burnom istorijom.",
                    PutanjaSlike = "/slike/manastiri/besenovo.jpg"
                },
                new Manastir
                {
                    Id = 17,
                    Naziv = "Богородица Љевишка",
                    Ktitor = "kraљ Милутин (obnova)",
                    Period = "14. век",
                    Lokacija = "Prizren",
                    KratakOpis = "Crkva u Prizrenu sa izuzetnim freskama, pod zaštitom UNESCO-a.",
                    PutanjaSlike = "/slike/manastiri/bogorodica-ljeviska.jpg"
                },
                new Manastir
                {
                    Id = 18,
                    Naziv = "Ђурђеви Ступови",
                    Ktitor = "Стефан Немања",
                    Period = "крај 12. века",
                    Lokacija = "kod Novog Pazara",
                    KratakOpis = "Jedna od najstarijih zadužbina Nemanje iznad Novog Pazara.",
                    PutanjaSlike = "/slike/manastiri/djurdjevi-stupovi.jpg"
                },
                new Manastir
                {
                    Id = 19,
                    Naziv = "Гориоч",
                    Ktitor = "tradicionalno kraljica Jelena",
                    Period = "srednji vek",
                    Lokacija = "Metohija",
                    KratakOpis = "Manastir na Kosovu, važan lokalni centar pravoslavlja.",
                    PutanjaSlike = "/slike/manastiri/gorioc.jpg"
                },
                new Manastir
                {
                    Id = 20,
                    Naziv = "Пећка патријаршија",
                    Ktitor = "više arhiepiskopa i patrijarha",
                    Period = "13–14. век",
                    Lokacija = "Peć",
                    KratakOpis = "Sedište srpskih arhiepiskopa i patrijarha, kompleks više crkava.",
                    PutanjaSlike = "/slike/manastiri/pecka-patrijarsija.jpg"
                },
                new Manastir
                {
                    Id = 21,
                    Naziv = "Светих Архангела",
                    Ktitor = "цар Душан",
                    Period = "14. век",
                    Lokacija = "kod Prizrena",
                    KratakOpis = "Zadužbina cara Dušana, danas očuvana u vidu ostataka.",
                    PutanjaSlike = "/slike/manastiri/svetih-arhangela.jpg"
                },
                new Manastir
                {
                    Id = 22,
                    Naziv = "Троноша",
                    Ktitor = "nepoznato (obnova u 16. veku)",
                    Period = "srednji vek / obnova u 16. veku",
                    Lokacija = "kod Loznice",
                    KratakOpis = "Poznata po školi koju je pohađao Vuk Karadžić.",
                    PutanjaSlike = "/slike/manastiri/tronosa.jpg"
                }
            };
        }

        public static Manastir? VratiPoId(int id) =>
            VratiSve().FirstOrDefault(m => m.Id == id);

        public static IEnumerable<Manastir> PretragaISortiranje(
            string? pretraga, string? sort)
        {
            var query = VratiSve().AsQueryable();

            if (!string.IsNullOrWhiteSpace(pretraga))
            {
                pretraga = pretraga.ToLower();
                query = query.Where(m =>
                    m.Naziv.ToLower().Contains(pretraga) ||
                    m.Ktitor.ToLower().Contains(pretraga) ||
                    m.Lokacija.ToLower().Contains(pretraga));
            }

            // sort: naziv_asc, naziv_desc, period_asc, period_desc
            switch (sort)
            {
                case "naziv_desc":
                    query = query.OrderByDescending(m => m.Naziv);
                    break;
                case "period_asc":
                    query = query.OrderBy(m => m.Period);
                    break;
                case "period_desc":
                    query = query.OrderByDescending(m => m.Period);
                    break;
                default:
                    query = query.OrderBy(m => m.Naziv);
                    break;
            }

            return query.ToList();
        }
    }
}
