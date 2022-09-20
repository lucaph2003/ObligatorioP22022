using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Partido
    {
        #region Atributos Partido
        public int id { get; set; }
        public Seleccion seleccion1 { get; set; }
        public Seleccion seleccion2 { get; set; }
        public DateTime fechaHora { get; set; }
        public bool esFinalizada { get; set; }

        //public List<Incidencia> incidencias;\
        #endregion
        #region Metodos Partido

        public void ValidarSelecciones()
        {

        }

        public void ValidarFecha()
        {

        }
        #endregion
    }
}
