using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Persona : IValidable
    {
        #region Atributos Persona
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public static int contador = 0;
        #endregion
        #region Metodos Persona
        public Persona(string pNombre,string pApellido)
        {
            this.id = contador++;
            this.nombre = pNombre;
            this.apellido = pApellido;

        }
        public abstract void Validar();
        #endregion
    }
}
