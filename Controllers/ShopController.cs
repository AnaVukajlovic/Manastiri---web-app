using Microsoft.AspNetCore.Mvc;
using NemanjiciWebApp.Data;
using NemanjiciWebApp.Models;


namespace NemanjiciWebApp.Controllers
{
    public class ShopController : Controller
    {
        // /Shop
        public IActionResult Index(string? kategorija, string? pretraga)
        {
            var proizvodi = ProizvodRepozitorijum.VratiSve(kategorija, pretraga);
            var kategorije = ProizvodRepozitorijum.VratiSveKategorije();

            ViewBag.IzabranaKategorija = kategorija;
            ViewBag.Pretraga = pretraga;
            ViewBag.Kategorije = kategorije;

            return View(proizvodi);
        }

        // /Shop/Detalji/1
        public IActionResult Detalji(int id)
        {
            var proizvod = ProizvodRepozitorijum.VratiPoId(id);

            if (proizvod == null)
            {
                return NotFound();
            }

            return View(proizvod);
        }

        public IActionResult DodajUKorpu(int id)
        {
            var proizvod = ProizvodRepozitorijum.VratiPoId(id);
            if (proizvod == null)
                return NotFound();

            var korpa = new KorpaSesija(HttpContext.Session);
            korpa.DodajProizvod(proizvod);

            return RedirectToAction("Korpa");
        }

        public IActionResult Korpa()
        {
            var korpa = new KorpaSesija(HttpContext.Session);
            var stavke = korpa.VratiStavke();

            return View(stavke);
        }

        public IActionResult UkloniIzKorpe(int id)
        {
            var korpa = new KorpaSesija(HttpContext.Session);
            korpa.UkloniProizvod(id);
            return RedirectToAction("Korpa");
        }

        public IActionResult OcistiKorpu()
        {
            var korpa = new KorpaSesija(HttpContext.Session);
            korpa.Ocisti();
            return RedirectToAction("Korpa");
        }

    }
}
