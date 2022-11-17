using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class PartidoFaseEliminatoria : Partido
    {
        #region Atributos PartidoFaseEliminatoria
        public bool alargue { get; set; }
        public bool penales { get; set; }
        public int etapa { get; set; }
        #endregion
        #region Metodos PartidoFaseEliminatoria
        public PartidoFaseEliminatoria(Seleccion pSeleccion1,Seleccion pSeleccion2,DateTime pFechaHora, int pEtapa, bool pAlargue, bool pPenales):base(pSeleccion1,pSeleccion2, pFechaHora)
        {
            this.etapa = pEtapa;
            this.alargue = pAlargue;
            this.penales = pPenales;
        }

     

        #endregion

    }
}
