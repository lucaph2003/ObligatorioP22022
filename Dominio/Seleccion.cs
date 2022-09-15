using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Seleccion
    {
        public Pais pais { get; set; }
        public List<Jugador> jugadores { get; set; }

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
    }
}
