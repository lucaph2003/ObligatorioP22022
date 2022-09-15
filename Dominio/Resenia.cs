using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Resenia
    {
        public Periodista periodista { get; set; }
        public DateTime fecha { get; set; }
        public Partido partido { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }

    }
}
