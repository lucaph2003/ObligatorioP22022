using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Periodista : Usuario
    {
        #region Atributos Periodista

        public static int contador = 1;

        public int id { get; set; }

        public const string Rol = "Periodista";
        #endregion

        #region Metodos Periodista

        #region Constructores
        public Periodista(string pNombreCompleto,string pContrasena,string pEmail) :base(pNombreCompleto,pContrasena,pEmail)
        {
            this.id = contador++;
        }
        public Periodista() { }
        #endregion

        #region Validaciones

       

        #endregion

        #region Override y Compare
        public override string ToString()
        {
            return $"Nombre: {this.nombreCompleto}" + "\n" + $"Correo Electronico: {this.email}";
        }
        public override string ObtenerRol()
        {
            return Rol;
        }

        #endregion
        #endregion
    }
}
