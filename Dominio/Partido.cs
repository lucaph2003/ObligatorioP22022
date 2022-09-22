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

        public static int contador = 0;
        #endregion
        #region Metodos Partido
        public Partido(Seleccion pSeleccion1,Seleccion pSeleccion2,DateTime pFechaHora)
        {
            this.seleccion1 = pSeleccion1;
            this.seleccion2 = pSeleccion2;
            this.fechaHora = pFechaHora;
            this.esFinalizada = false;
            this.id = contador++;
        }

        public void ValidarSelecciones()
        {
            if(seleccion1 == null || seleccion2 == null || seleccion1.Equals(seleccion2))
            {
                throw new Exception("Debe cargar correctamente las dos selecciones! ! !");
            }
        }

        public void ValidarFecha()
        {
            DateTime fechaInicio = new DateTime(2022, 11, 20);
            DateTime fechaFinal = new DateTime(2022, 12, 18);
            if(this.fechaHora <fechaInicio || this.fechaHora > fechaFinal)
            {
                throw new Exception("Debe ingresar fecha entre el 20/11/2022 hasta 18/12/2022");
            }
        }
        #endregion
    }
}
