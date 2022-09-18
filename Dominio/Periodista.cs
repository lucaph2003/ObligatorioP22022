﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Periodista : Persona
    {
        public string email { get; set; }
        public string password { get; set; }

        public override void ValidarDatos()
        {
            if (this.nombre != null && this.apellido != null && this.email != null)
            {
                ValidarEmail();
                ValidarPassword();
            }
            else
            {
                throw new Exception("Todos los campos deben estar llenos");
            }
            
        }

        public void ValidarEmail()
        {
            if (!this.email.Contains("@") && this.email.StartsWith("@") && this.email.EndsWith("@"))
            {
                throw new Exception("El Mail esta mal escrito");
            }
        }

        public void ValidarPassword()
        {
            if (this.password.Length < 7)
            {
                throw new Exception("La contrasenia debe ser mayor a 8 caracteres");
            }
        }
    }
}