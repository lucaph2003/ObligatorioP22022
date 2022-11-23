using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class PeriodistaController : Controller
    {
        Sistema sistema = Sistema.ObtenerInstancia;
        public IActionResult ListarPeriodistas()
        {
            List<Periodista> periodistas = sistema.ObtenerPeriodistas();
            return View(periodistas);
        }

    }
}
