using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Incidencia
    {
        public string incidencia { get; set; }
        public int minuto { get; set; }
        public Jugador jugador { get; set; }

        public Incidencia(string pIncidencia,int pMinuto,Jugador pJugador)
        {
            this.incidencia = pIncidencia;
            this.minuto = pMinuto;
            this.jugador = pJugador;
        }


    }
}
