using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Resenia
    {
        #region Atributos Resenia
        public Periodista periodista { get; set; }
        public DateTime fecha { get; set; }
        public Partido partido { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }

        #endregion
        #region Metodos Resenia
        public Resenia(Periodista pPeriodista,DateTime pFecha,Partido pPartido, string pTitulo, string pContenido)
        {
            this.periodista = pPeriodista;
            this.fecha = pFecha;
            this.partido = pPartido;
            this.titulo = pTitulo;
            this.contenido = pContenido;
        }
        #endregion

    }
}
