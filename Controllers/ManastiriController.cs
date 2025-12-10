using Microsoft.AspNetCore.Mvc;
using NemanjiciWebApp.Data;

namespace NemanjiciWebApp.Controllers
{
    public class ManastiriController : Controller
    {
        public IActionResult Index(string? pretraga, string? sort)
        {
            ViewData["TrenutnaPretraga"] = pretraga;
            ViewData["TrenutnoSortiranje"] = sort;
            var manastiri = ManastirRepozitorijum.PretragaISortiranje(pretraga, sort);
            return View(manastiri);
        }

        public IActionResult Detalji(int id)
        {
            var manastir = ManastirRepozitorijum.VratiPoId(id);
            if (manastir == null)
            {
                return NotFound();
            }
            return View(manastir);
        }
    }
}
