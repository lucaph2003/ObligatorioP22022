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
        #region Constructores
        public Persona(string pNombreCompleto)
        {
            this.nombreCompleto = pNombreCompleto;
        }
        public Persona()
        {
            this.nombreCompleto = "Sin Definir";
        }
        #endregion

        #region Validaciones
        public abstract void Validar();
        #endregion

        #endregion
    }
}
