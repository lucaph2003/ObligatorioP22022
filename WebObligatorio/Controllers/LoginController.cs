using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class LoginController : Controller
    {
        Sistema sistema = Sistema.ObtenerInstancia;
        public IActionResult Index()
        {
            HttpContext.Session.Remove("UsuarioLogueado");
            HttpContext.Session.Remove("UsuarioRol");
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            try
            {
                sistema.Login(usuario);
            }
            catch (Exception e)
            {
                ViewBag.NombreError = e.Message;
                return View();
            }

            Usuario usuarioDeSistema = sistema.ObtenerUsuarioPorNombreUsuario(usuario.nombreCompleto);

            HttpContext.Session.SetString("UsuarioLogueado", usuarioDeSistema.nombreCompleto);
            HttpContext.Session.SetString("UsuarioRol", usuarioDeSistema.ObtenerRol());

            return RedirectToAction("Index", "Home");
        }

    }
}
