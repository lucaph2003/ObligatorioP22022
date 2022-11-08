using Dominio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebObligatorio.Controllers
{
    public class PeriodistaController : Controller
    {
        public Sistema sistema = Sistema.ObtenerInstancia;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegistroPeriodista()
        {
            return View();
        }
        public IActionResult LoginPeriodista()
        {
            return View();
        }
    }
}
