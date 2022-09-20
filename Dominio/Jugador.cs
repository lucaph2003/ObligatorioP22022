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
        public int puesto { get; set; }
        public string categoria { get; set; }
        public static int montoCategoria { get; set; }
        #endregion
        #region Metodos Jugador

        public Jugador(string pNombre,string pApellido,int pDorsal,DateTime pFechaNacimiento,decimal pAltura,int pPieHabil,int pValorMercado,Seleccion pSeleccion,int pPuesto)
        {
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.dorsal = pDorsal;
            this.fechaNacimiento = pFechaNacimiento;
            this.altura = pAltura;
            this.pieHabil = pPieHabil;
            this.valorMercado = pValorMercado;
            this.seleccion = pSeleccion;
            this.puesto = pPuesto;
            CalcularCategoria();
        }
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
