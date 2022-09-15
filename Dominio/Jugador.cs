using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Jugador : Persona
    {
        public int dorsal { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public decimal altura { get; set; }
        public int pieHabil { get; set; }
        public int valorMercado { get; set; }
        public Seleccion seleccion { get; set; }
        public string puesto { get; set; }
        public int categoria { get; set; }

        public override void ValidarDatos()
        {
            
        }

        public void ValidarValorMercado()
        {

        }
    }
}
