using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebObligatorio.Controllers
{
    public class PartidoController : Controller
    {
        public IActionResult ListadoPartidosFinalizados()
        {
            return View();
        }
    }
}
