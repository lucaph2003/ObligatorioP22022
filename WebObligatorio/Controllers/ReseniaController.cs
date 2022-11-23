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
            string rol = HttpContext.Session.GetString("UsuarioRol");
            string pEmail = HttpContext.Session.GetString("UsuarioLogueadoEmail");
            if(rol != null && rol == "Operador")
            {
                List<Resenia> resenias = sistema.ObtenerReseniasPorPeriodista(email);
                return View(resenias);
            }
            else if(rol != null && rol == "Periodista")
            {
                List<Resenia> resenias = sistema.ObtenerReseniasPorPeriodista(pEmail);
                return View(resenias);
            }
            TempData["mensajeError"] = "No tienes permisos para acceder a esta página.";
            return RedirectToAction("MostrarError", "Error");
        }

        

        public IActionResult AltaResenia(int idPartido)
        {
            string rol = HttpContext.Session.GetString("UsuarioRol");
            if(rol != null && rol == "Periodista")
            {
                ViewBag.idPartido = idPartido;
                return View();
            }
            else
            {
                TempData["mensajeError"] = "No tienes permisos para acceder a esta página.";
                return RedirectToAction("MostrarError", "Error");
            }
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
