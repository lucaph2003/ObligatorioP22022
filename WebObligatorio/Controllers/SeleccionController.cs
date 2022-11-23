using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class SeleccionController : Controller
    {
        public Sistema sistema = Sistema.ObtenerInstancia;
        public IActionResult Index()
        {
            List<Seleccion> selecciones = sistema.ObtenerListaSeleccion();
            return View(selecciones);
        }

        public IActionResult Jugadores(int idPais)
        {
            ViewBag.Pais = sistema.GetPaisId(idPais);
            List<Jugador> jugadores = sistema.ObtenerJugadoresPais(idPais);
            return View(jugadores);
        }

        public IActionResult Goleadores()
        {
            ViewBag.Goles = sistema.CantidadGoles();
            List<Seleccion> selecciones = sistema.ObtenerSeleccionGoleadora();
            return View(selecciones);
        }
    }
}
