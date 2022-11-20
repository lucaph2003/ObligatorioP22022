using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class PartidoController : Controller
    {
        Sistema sistema = Sistema.ObtenerInstancia;

        public IActionResult ListadoPartido()
        {
            List<Partido> partidos = sistema.ObtenerListaPartidos();
            ViewBag.Resultado = "";
            return View(partidos);
        }
        public IActionResult Incidencia(int idPartido)
        {
            List<Jugador> jugadores = sistema.ObtenerJugadoresPorIdPartido(idPartido);
            ViewBag.idPartido = idPartido;
            return View(jugadores);
        }

        public IActionResult ListadosPartidosFinalizados()
        {
            List<Partido> partidos = sistema.ObtenerListaPartidosFinalizados();
            ViewBag.Resultado = "";
            return View(partidos);
        }

        public IActionResult FinalizarEliminatoria(int idPartido)
        {
            ViewBag.idPartido = idPartido;
            return View();
        }

        [HttpPost]
        public IActionResult Incidencia(int idPartido,string incidencia,int minuto,int idJugador)
        {
            try
            {
                sistema.RegistrarIncidencia(idPartido,incidencia,minuto,idJugador);
            }
            catch (Exception e)
            {
                ViewBag.ErrorNombre = e.Message;
                return View();
            }
            return RedirectToAction("ListadoPartido", "Partido");
        }

        [HttpPost]
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
            //ARREGLAR
            ViewBag.Resultado = sistema.VerResultadoPartido(idPartido);
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
