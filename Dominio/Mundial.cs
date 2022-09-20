using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Mundial
    {
        private static Mundial _instancia;

        public List<Jugador> jugadores { get; } = new List<Jugador>();
        public List<Seleccion> selecciones { get; } = new List<Seleccion>();

        public static Mundial ObtenerInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Mundial();
                }
                return _instancia;
            }
        }

        private Mundial()
        {

        }


    }
}
