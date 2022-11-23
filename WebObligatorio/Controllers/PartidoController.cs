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
            List<Partido> partidos = sistema.ObtenerListaPartidos();
            ViewBag.Resultado = "";
            return View(partidos);
        }

        //Vista para agregar incidencia
        public IActionResult Incidencia(int idPartido)
        {
            List<Jugador> jugadores = sistema.ObtenerJugadoresPorIdPartido(idPartido);
            ViewBag.idPartido = idPartido;
            return View(jugadores);
        }

        //Vista de los partidos finalizados
        public IActionResult ListadosPartidosFinalizados()
        {
            List<Partido> partidos = sistema.ObtenerListaPartidosFinalizados();
            ViewBag.rol = HttpContext.Session.GetString("UsuarioRol");
            return View(partidos);
        }

        //Vista de Finalizar la eliminatoria
        public IActionResult FinalizarEliminatoria(int idPartido)
        {
            ViewBag.idPartido = idPartido;
            return View();
        }

        //Vista de Buscar partido por 2 fechas
        public IActionResult BuscarPartidosEntreDosFechas()
        {
            return View();
        }

        //Vista de Buscar partido por 2 fechas
        public IActionResult ListadoPartidosEntreDosFechas()
        {
            return View();
        }

        public IActionResult BuscarPartidoEmailPeriodista()
        {
            return View();
        }

        public IActionResult ListadoPartidoEmailPeriodista()
        {
            return View();
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

        [HttpPost]
        public IActionResult BuscarPartidosEntreDosFechas(DateTime f1, DateTime f2)
        {
            List<Partido> partidos = sistema.ObtenerPartidosEntre2Fechas(f1, f2);
            return View(partidos);
        }

        [HttpPost]
        public IActionResult BuscarPartidoEmailPeriodista(string email)
        {
            List<Partido> partidoRojaPeridista = sistema.ObtenerPartidoRojaReseniaEmailPeriodista(email);
            return View(partidoRojaPeridista);
        }






    }
}
