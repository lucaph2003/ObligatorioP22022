using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebObligatorio.Controllers
{
    public class ReseniaController : Controller
    {
        Sistema sistema = Sistema.ObtenerInstancia;
        
        public IActionResult ListarResenias()
        {
            string email = HttpContext.Session.GetString("UsuarioLogueadoEmail");
            List<Resenia> resenias = sistema.ObtenerReseniasPorPeriodista(email);
            return View(resenias);
        }
        public IActionResult AltaResenia()
        {
            string email = HttpContext.Session.GetString("UsuarioLogueadoEmail");
            ViewBag.Periodista = sistema.GetPeriodista(email);
            List<Partido> partidos = sistema.ObtenerListaPartidosFinalizados();
            return View(partidos);
        }

        [HttpPost]
        public IActionResult AltaResenia(Resenia resenia)
        {
            
            sistema.AltaResenia(resenia);
            return RedirectToAction("ListarResenias", "Resenia");
        }
    }
}
