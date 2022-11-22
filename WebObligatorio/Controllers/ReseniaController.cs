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
        
        public IActionResult ListarResenias(string email)
        {
            //string email = HttpContext.Session.GetString("UsuarioLogueadoEmail");
            List<Resenia> resenias = sistema.ObtenerReseniasPorPeriodista(email);
            return View(resenias);
        }
        
        public IActionResult AltaResenia(int idPartido)
        {
            ViewBag.idPartido = idPartido;
            return View();
        }

        [HttpPost]
        public IActionResult AltaResenia(DateTime fecha,int idPartido, string titulo, string contenido)
        {
            Resenia resenia = sistema.RegistrarResenia(HttpContext.Session.GetString("UsuarioLogueadoEmail"), fecha, idPartido, titulo, contenido);
            sistema.AltaResenia(resenia);
            return RedirectToAction("ListarResenias", "Resenia");
        }
    }
}
