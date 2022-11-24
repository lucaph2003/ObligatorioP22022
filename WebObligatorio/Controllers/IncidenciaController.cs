using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace WebObligatorio.Controllers
{
    public class IncidenciaController : Controller
    {
        Sistema sistema = Sistema.ObtenerInstancia;
        public IActionResult Incidencias(int idPartido)
        {
            List<Incidencia> incidencias = sistema.ObtenerListaInciaPorIdPartido(idPartido);
            return View(incidencias);
        }
    }
}
