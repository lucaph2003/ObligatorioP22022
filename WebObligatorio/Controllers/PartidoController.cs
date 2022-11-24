using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class PartidoController : Controller
    {
        Sistema sistema = Sistema.ObtenerInstancia;

        //Vista del listado de partidos sin finalizar
        public IActionResult ListadoPartido()
        {
            string rol = HttpContext.Session.GetString("UsuarioRol");
            if(rol != null && rol == ("Operador"))
            {
                List<Partido> partidos = sistema.ObtenerListaPartidos();
                ViewBag.Resultado = "";
                return View(partidos);
            }
            else
            {
                TempData["mensajeError"] = "No tienes permisos para acceder a esta página.";
                return RedirectToAction("MostrarError", "Error");
            }
        }

        //Vista para agregar incidencia
        public IActionResult Incidencia(int idPartido)
        {
            string rol = HttpContext.Session.GetString("UsuarioRol");
            if (rol != null && rol == ("Operador"))
            {
                List<Jugador> jugadores = sistema.ObtenerJugadoresPorIdPartido(idPartido);
                ViewBag.idPartido = idPartido;
                return View(jugadores);
            }
            else
            {
                TempData["mensajeError"] = "No tienes permisos para acceder a esta página.";
                return RedirectToAction("MostrarError", "Error");
            }
        }

        //Vista de los partidos finalizados
        public IActionResult ListadosPartidosFinalizados()
        {
            //ViewBag.pe = sistema.ObtenerPartidoFaseEliminatoria();
            string rol = HttpContext.Session.GetString("UsuarioRol");
            if (rol != null)
            {
                ViewBag.pE = sistema.ObtenerPartidosFE();
                List<Partido> partidos = sistema.ObtenerPartidosFG();
                return View(partidos);
            }
            else
            {
                TempData["mensajeError"] = "No tienes permisos para acceder a esta página.";
                return RedirectToAction("MostrarError", "Error");
            }

        }

        //Vista de Finalizar la eliminatoria
        public IActionResult FinalizarEliminatoria(int idPartido)
        {
            string rol = HttpContext.Session.GetString("UsuarioRol");
            if(rol != null && rol == ("Operador"))
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

        //Vista de Buscar partido por 2 fechas
        public IActionResult BuscarPartidosEntreDosFechas(DateTime f1, DateTime f2)
        {
            string rol = HttpContext.Session.GetString("UsuarioRol");
            if (rol != null && rol == ("Operador"))
            {
                if(f1 != null && f2 != null)
                {
                    List<Partido> partidos = sistema.ObtenerPartidosEntre2Fechas(f1, f2);
                    return View(partidos);
                }
                else
                {
                    return View();
                }
            }
            else
            {
                TempData["mensajeError"] = "No tienes permisos para acceder a esta página.";
                return RedirectToAction("MostrarError", "Error");
            }

        }

        public IActionResult BuscarPartidoEmailPeriodista(string email)
        {
            string rol = HttpContext.Session.GetString("UsuarioRol");
            if (rol != null && rol == ("Operador"))
            {
                if(email != null)
                {
                    List<Partido> partidos = sistema.ObtenerPartidoRojaReseniaEmailPeriodista(email);
                    return View(partidos);
                }
                else
                {
                    return View();
                }
            }
            else
            {
                TempData["mensajeError"] = "No tienes permisos para acceder a esta página.";
                return RedirectToAction("MostrarError", "Error");
            }
        }



        [HttpPost]
        public IActionResult Incidencia(int idPartido, string incidencia, int minuto, int idJugador)
        {
            try
            {
                sistema.RegistrarIncidencia(idPartido, incidencia, minuto, idJugador);
            }
            catch (Exception e)
            {
                ViewBag.ErrorNombre = e.Message;
                return View();
            }
            return RedirectToAction("ListadoPartido", "Partido");
        }


        public IActionResult Finalizar(int idPartido)
        {
            try
            {
                sistema.FinalizarPartido(idPartido);
            }
            catch (Exception e)
            {
                ViewBag.ErrorNombre = e.Message;
                return View();
            }
            return RedirectToAction("ListadoPartido", "Partido");
        }

        [HttpPost]
        public IActionResult FinalizarEliminatoria(int idPartido, bool alargues, bool penales)
        {
            sistema.CambiarEstadoPartido(idPartido, alargues, penales);
            sistema.FinalizarPartido(idPartido);
            return RedirectToAction("ListadoPartido", "Partido");
        }

        
        

        






    }
}
