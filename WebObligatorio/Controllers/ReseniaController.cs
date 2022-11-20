using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebObligatorio.Controllers
{
    public class ReseniaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
