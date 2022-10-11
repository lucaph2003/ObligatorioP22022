using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    /// <summary>
    /// hola
    /// </summary>
    public class Periodista : Persona
    {
        #region Atributos Periodista
        public string email { get; set; }
        public string password { get; set; }

        public static int contador = 1;

        public int id { get; set; }
        #endregion

        #region Metodos Periodista

        #region Constructores
        public Periodista(string pNombreCompleto,string pEmail,string pPassword) :base(pNombreCompleto)
        {
            this.email =pEmail;
            this.password = pPassword;
            this.id = contador++;
        }

        #endregion

        #region Validaciones
        public override void Validar()
        {
            if (this.nombreCompleto.Length > 1  && this.email.Length > 1 && this.password.Length > 1)
            {
                ValidarEmail();
                ValidarPassword();
            }
            else
            {
                throw new Exception("Todos los campos deben estar llenos");
            }
            
        }
        public void ExisteEmail(List<Periodista> periodistas)
        {
            foreach(Periodista p in periodistas)
            {
                if (p.email.Equals(this.email))
                {
                    throw new Exception("El mail ya existe");
                }
            }
    
        }
        public void ExisteId(List<Periodista> periodistas)
        {
            foreach (Periodista p in periodistas)
            {
                if (p.id.Equals(this.id))
                {
                    throw new Exception("El Id ya existe");
                }
            }

        }

        public void ValidarEmail()
        {
            if (!this.email.Contains("@") || this.email.StartsWith("@") || this.email.EndsWith("@"))
            {
                throw new Exception("El email debe contener @ y no puede estar en el principio ni final");
            }
        }

        public void ValidarPassword()
        {
            if (this.password.Length < 7)
            {
                throw new Exception("La contrasenia debe ser mayor a 8 caracteres");
            }
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
