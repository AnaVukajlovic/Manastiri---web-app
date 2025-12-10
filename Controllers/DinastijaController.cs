using Microsoft.AspNetCore.Mvc;
using NemanjiciWebApp.Data;

namespace NemanjiciWebApp.Controllers
{
    public class DinastijaController : Controller
    {
        // /Dinastija/Stablo
        public IActionResult Stablo()
        {
            var sviClanovi = ClanDinastijeRepozitorijum.VratiSve();
            return View(sviClanovi);
        }

        // /Dinastija/Detalji/1
        public IActionResult Detalji(int id)
        {
            var clan = ClanDinastijeRepozitorijum.VratiPoId(id);
            if (clan == null)
            {
                return NotFound();
            }

            return View(clan);
        }
    }
}
