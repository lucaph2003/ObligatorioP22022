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
        public override void Validar()
        {
            if (this.nombreCompleto.Length > 1  && this.email.Length > 1 && this.contrasena.Length > 1)
            {
                ValidarEmail();
                ValidarPassword();
            }
            else
            {
                throw new Exception("Todos los campos deben estar llenos");
            }
            
        }
        public void ExisteEmail(List<Usuario> usuarios)
        {
            foreach(Usuario u in usuarios)
            {                   
               if (u.email.Equals(this.email))
                {
                  throw new Exception("El mail ya existe");
                } 
            }
        }
        //public void ExisteId(List<Usuario> usuarios)
        //{
        //    foreach (Periodista p in usuarios)
        //    {
        //        if (p.id.Equals(this.id))
        //        {
        //            throw new Exception("El Id ya existe");
        //        }
        //    }

        //}

        public void ValidarEmail()
        {
            if (!this.email.Contains("@") || this.email.StartsWith("@") || this.email.EndsWith("@"))
            {
                throw new Exception("El email debe contener @ y no puede estar en el principio ni final");
            }
        }

        public void ValidarPassword()
        {
            if (this.contrasena.Length < 7)
            {
                throw new Exception("La contrasenia debe ser mayor a 8 caracteres");
            }
        }

        public override string ObtenerRol()
        {
            return Rol;
        }

        #endregion

        #region Override y Compare
        public override string ToString()
        {
            return $"Nombre: {this.nombreCompleto}" + "\n" + $"Correo Electronico: {this.email}";
        }
        #endregion
        #endregion
    }
}
