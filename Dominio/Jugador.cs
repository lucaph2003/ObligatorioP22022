using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Jugador : Persona
    {
        #region Atributos Jugador
        public int dorsal { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public decimal altura { get; set; }
        public int pieHabil { get; set; }
        public int valorMercado { get; set; }
        public Seleccion seleccion { get; set; }
        public string puesto { get; set; }
        public string categoria { get; set; }
        public static int montoCategoria { get; set; }
        #endregion
        #region Metodos Jugador
        public override void ValidarDatos()
        {
            if(this.nombre != null &&this.apellido != null&&this.dorsal >= 0 && this.fechaNacimiento != null && this.altura > 0 && this.pieHabil > 0 && this.valorMercado >= 0 && this.seleccion != null && this.puesto != null)
            {

            }
            else
            {
                throw new Exception("Los datos deben estar completos");
            }
        }

        public void ValidarValorMercado()
        {
            if(valorMercado < 0)
            {
                throw new Exception("El valor de mercado debe ser mayor a 0");
            }
        }

        public void CalcularCategoria()
        {
            if(this.valorMercado < montoCategoria)
            {
                this.categoria = "Estandar";
            } else
            {
                this.categoria = "VIP";
            }
        }
        #endregion
    }
}
