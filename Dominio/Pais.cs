using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Pais
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public static int contador = 0;

        public Pais()
        {
            this.id = contador++;
        }

        public void ValidarPais()
        {

        }

        public bool ValidarCodigo()
        {
            bool esCorrecto = false;
            //Aca adentro poner codigo
            return esCorrecto;
        }
    }
}
