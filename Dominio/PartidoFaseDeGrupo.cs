using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class PartidoFaseDeGrupo : Partido
    {
        #region Atributos PartidoFaseDeGrupo
        public char grupo { get; set; }
        
        #endregion
        #region Metodos PartidoFaseDeGrupo
        public PartidoFaseDeGrupo(Seleccion pSeleccion1,Seleccion pSeleccion2,DateTime pFechaHora,char pGrupo) : base(pSeleccion1, pSeleccion2, pFechaHora)
        {
            this.grupo = pGrupo;
        }
        #endregion
    }
}
