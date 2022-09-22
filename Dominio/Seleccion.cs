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
            if(this.pais == null)
            {
                throw new Exception("Ingresa un pais que no este vacio");
            }
        }

        public void ValidarJugadores()
        {
            int cantidadJugadores = jugadores.Count;
            if(cantidadJugadores < 11 )
            {
                throw new Exception("Debe ingresar al menos 11 jugadores");
            }
        }
        #endregion
    }
}
