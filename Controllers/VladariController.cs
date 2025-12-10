using Microsoft.AspNetCore.Mvc;
using NemanjiciWebApp.Data;

namespace NemanjiciWebApp.Controllers
{
    public class VladariController : Controller
    {
        // /Vladari
        public IActionResult Index()
        {
            var vladari = VladarRepozitorijum.VratiSve();
            return View(vladari);
        }

        // /Vladari/Detalji/1
        public IActionResult Detalji(int id)
        {
            var vladar = VladarRepozitorijum.VratiPoId(id);

            if (vladar == null)
            {
                return NotFound();
            }

            return View(vladar);
        }
    }
}
