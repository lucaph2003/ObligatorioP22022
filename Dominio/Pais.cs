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
            if(this.nombre.Length == 0)
            {
                throw new Exception("El nombre del pais no puede estar vacio");
            }
        }

        public bool ValidarCodigo()
        {
            bool esCorrecto = false;
            if(this.codigo.Length == 3)
            {
                esCorrecto = true;
            }
            return esCorrecto;
        }
    }
}
