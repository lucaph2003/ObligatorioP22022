using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Operador :Persona
    {
        //ver si hereda de persona o no
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime FechaContratado { get; set; }

        public Operador(string pNombreCompleto, string pEmail, string pPassword, DateTime pFechaContratado):base(pNombreCompleto)
        {
            this.Email = pEmail;
            this.Password = pPassword;
            this.FechaContratado = pFechaContratado;
        }

        public override void Validar()
        {
            if (this.nombreCompleto.Length > 1 && this.Email.Length > 1 && this.Password.Length > 1)
            {
                ValidarEmail();
                ValidarPassword();
            }
            else
            {
                throw new Exception("Todos los campos deben estar llenos");
            }

        }
        public void ExisteEmail(List<Operador> operadores)
        {
            foreach (Operador o in operadores)
            {
                if (o.Email.Equals(this.Email))
                {
                    throw new Exception("El mail ya existe");
                }
            }

        }
        public void ValidarEmail()
        {
            if (!this.Email.Contains("@") || this.Email.StartsWith("@") || this.Email.EndsWith("@"))
            {
                throw new Exception("El email debe contener @ y no puede estar en el principio ni final");
            }
        }

        public void ValidarPassword()
        {
            if (this.Password.Length < 7)
            {
                throw new Exception("La contrasenia debe ser mayor a 8 caracteres");
            }
        }

    }
}
