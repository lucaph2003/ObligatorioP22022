using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Usuario : IValidable 
    {
        #region Atributos Usuario

        public string nombreCompleto { get; set; }

        public string contrasena { get; set; }

        public string email { get; set; }

        #endregion

        #region Metodos Usuario
        #region Constructores
        public Usuario(string pNombreCompleto, string pContrasena,string pEmail)
        {
            this.nombreCompleto = pNombreCompleto;
            this.contrasena = pContrasena;
            this.email = pEmail;
        }
        public Usuario()
        {
            this.nombreCompleto = "Sin Definir";
            this.contrasena = "No Existe";
            this.email = "000@000";
        }
        #endregion

        #region Validaciones
        public abstract void Validar();
        #endregion

        #endregion
    }
}
