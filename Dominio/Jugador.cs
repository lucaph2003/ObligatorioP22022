using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Jugador : Persona 
    {
        #region Atributos Jugador
        public int dorsal { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public decimal altura { get; set; }
        public int pieHabil { get; set; }
        public int valorMercado { get; set; }
        public Pais pais { get; set; }
        public int puesto { get; set; }
        public string categoria { get; set; }
        public static int montoCategoria { get; set; }
        #endregion
        #region Metodos Jugador

        public Jugador(string pNombre,string pApellido,int pDorsal,DateTime pFechaNacimiento,decimal pAltura,int pPieHabil,int pValorMercado,Pais pPais,int pPuesto):base(pNombre,pApellido)
        {
            this.dorsal = pDorsal;
            this.fechaNacimiento = pFechaNacimiento;
            this.altura = pAltura;
            this.pieHabil = pPieHabil;
            this.valorMercado = pValorMercado;
            this.pais = pPais;
            this.puesto = pPuesto;
            CalcularCategoria();
        }
        public override void Validar()
        {
            if(this.nombre != null &&this.apellido != null&&this.dorsal >= 0 && this.fechaNacimiento != null && this.altura > 0 && this.pieHabil > 0 && this.valorMercado >= 0 && this.pais != null && this.puesto != 0)
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
