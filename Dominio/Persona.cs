using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public virtual void ValidarDatos()
        {

        }
    }
}
