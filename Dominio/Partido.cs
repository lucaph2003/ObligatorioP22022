using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Partido
    {
        public int id { get; set; }
        public Seleccion seleccion1 { get; set; }
        public Seleccion seleccion2 { get; set; }
        public DateTime fechaHora { get; set; }
        public bool esFinalizada { get; set; }

        //public List<Incidencia> incidencias;\
        public int tipoPartido { get; set; }

        public void ValidarSelecciones()
        {

        }

        public void ValidarFecha()
        {

        }
    }
}
