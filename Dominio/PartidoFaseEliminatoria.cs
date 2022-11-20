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
        #endregion
        #region Metodos PartidoFaseEliminatoria
        public PartidoFaseEliminatoria(Seleccion pSeleccion1, Seleccion pSeleccion2,DateTime pFechaHora):base(pSeleccion1,pSeleccion2,pFechaHora)
        {
            this.alargue = false;
            this.penales = false;
        }

        public void HuboAlargue()
        {
            this.alargue = true;
        }

        public void HuboPenales()
        {
            this.penales = true;
        }

        #endregion

    }
}
