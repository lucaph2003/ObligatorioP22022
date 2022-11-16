using Dominio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebObligatorio.Controllers
{
    public class RegistroController : Controller
    {
        private Sistema sistema = Sistema.ObtenerInstancia;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarPeriodistas()
        {
            List<Periodista> periodistas = sistema.ObtenerPeriodistas();
            return View(periodistas);
        }
        public IActionResult AltaPeriodista()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AltaPeriodista(Periodista periodista)
        {
            sistema.AltaPeriodista(periodista);
            return RedirectToAction("ListarPeriodistas", "Registro");
        }

    }
}
