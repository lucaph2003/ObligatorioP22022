using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Seleccion
    {
        #region Atributos Seleccion
        public Pais pais { get; set; }
        public List<Jugador> jugadores { get; set; }
        #endregion

        #region Metodos Seleccion
        public Seleccion()
        {
            jugadores = new List<Jugador>();
        }

        public void ValidarPais()
        {

        }

        public void ValidarJugadores()
        {

        }
        #endregion
    }
}
