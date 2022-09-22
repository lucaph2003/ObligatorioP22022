using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Seleccion
    {
        #region Atributos Seleccion
        public Pais pais { get; set; }
        public List<Jugador> Jugadores { get; set; }
        #endregion

        #region Metodos Seleccion
        public Seleccion(Pais pPais)
        {
            this.pais = pPais;
            Jugadores = new List<Jugador>();
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
            int cantidadJugadores = Jugadores.Count;
            if(cantidadJugadores < 11 )
            {
                throw new Exception("Debe ingresar al menos 11 jugadores");
            }
        }

        public void AgregarJugador(Jugador pJugador)
        {
            Jugadores.Add(pJugador);
        }
        #endregion
    }
}
