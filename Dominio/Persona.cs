using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Persona
    {
        #region Atributos Persona
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        #endregion
        #region Metodos Persona
        public virtual void ValidarDatos()
        {

        }
        #endregion
    }
}
