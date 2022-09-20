using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class PartidoFaseEliminatoria : Partido
    {
        #region Atributos PartidoFaseEliminatoria
        public bool alargue { get; set; }
        public bool penales { get; set; }
        public int etapa { get; set; }
        #endregion
        #region Metodos PartidoFaseEliminatoria
        public PartidoFaseEliminatoria(Seleccion pSeleccion1,Seleccion pSeleccion2,DateTime pFecha,int pEtapa)
        {
            this.seleccion1 = pSeleccion1;
            this.seleccion2 = pSeleccion2;
            this.fechaHora = pFecha;
            this.etapa = pEtapa;
        }

        public void ValidarResultado()
        {

        }
        #endregion

    }
}
