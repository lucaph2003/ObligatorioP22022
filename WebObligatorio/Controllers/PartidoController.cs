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
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListadoPartido()
        {
            List<Partido> partidos = sistema.ObtenerListaPartido();
            return View(partidos);
        }
        public IActionResult Incidencia(int idPartido)
        {
            List<Jugador> jugadores = sistema.ObtenerJugadoresPorIdPartido(idPartido);
            ViewBag.idPartido = idPartido;
            return View(jugadores);
        }

        [HttpPost]
        public IActionResult Incidencia(int idPartido,Incidencia incidencia)
        {
            try
            {
               // sistema.AltaIncidencia(sistema.GetPartido(idPartido), incidencia));
            }catch
            {

            }

            return RedirectToAction("ListadoPartido", "Partido");
        }

        public IActionResult Finalizar(int idPartido)
        {
            try
            {
                sistema.FinalizarPartido(idPartido);
            }
            catch(Exception e)
            {
                ViewBag.ErrorNombre = e.Message ;
            }
            return RedirectToAction("ListadoPartido", "Partido");
        }
    }
}
