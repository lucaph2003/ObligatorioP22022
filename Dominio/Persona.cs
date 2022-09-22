using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Persona : IValidable
    {
        #region Atributos Persona
        
        public string nombreCompleto { get; set; }
        
        #endregion
        #region Metodos Persona
        public Persona(string pNombreCompleto)
        {
            this.nombreCompleto = pNombreCompleto;
        }
        public abstract void Validar();

        #endregion
    }
}
