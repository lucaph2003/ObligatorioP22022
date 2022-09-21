using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class PartidoFaseDeGrupo : Partido
    {
        #region Atributos PartidoFaseDeGrupo
        //prueba
        #endregion
        #region Metodos PartidoFaseDeGrupo
        public PartidoFaseDeGrupo(Seleccion pSeleccion1,Seleccion pSeleccion2,DateTime pFechaHora)
        {
            this.seleccion1 = pSeleccion1;
            this.seleccion2 = pSeleccion2;
            this.fechaHora = pFechaHora;
            this.esFinalizada = false;
        }
        #endregion
    }
}
