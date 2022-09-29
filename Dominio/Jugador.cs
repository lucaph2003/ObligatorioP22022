using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Jugador : Persona , IComparable
    {
        #region Atributos Jugador
        public int id { get; set; }
        public string dorsal { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public double altura { get; set; }
        public string pieHabil { get; set; }
        public int valorMercado { get; set; }
        public string moneda { get; set; }
        public Pais pais { get; set; }
        public string puesto { get; set; }
        public string categoria { get; set; }
        public static int montoCategoria { get; set; }

        #endregion
        #region Metodos Jugador

        #region Constructores
        public Jugador(int pId, string pDorsal, string pNombreCompleto,DateTime pFechaNacimiento,double pAltura,string pPieHabil,int pValorMercado,string pMoneda,Pais pPais,string pPuesto):base(pNombreCompleto)
        {
            this.id = pId;
            this.dorsal = pDorsal;
            this.fechaNacimiento = pFechaNacimiento;
            this.altura = pAltura;
            this.pieHabil = pPieHabil;
            this.valorMercado = pValorMercado;
            this.moneda = pMoneda;
            this.pais = pPais;
            this.puesto = pPuesto;
            CalcularCategoria();
        }

        #endregion

        #region Metodos
        public void CalcularCategoria()
        {
            if (this.valorMercado < montoCategoria)
            {
                this.categoria = "Estandar";
            }
            else
            {
                this.categoria = "VIP";
            }
        }

        public static void CambiarMonto(int pNuevoMonto)
        {
            montoCategoria = pNuevoMonto;
        }

        public string VerJugadorValorCategoria()
        {
            return this.nombreCompleto + "-" + this.valorMercado + "-" + this.categoria;
        }
        #endregion

        #region Validaciones
        public override void Validar()
        {
            if (this.nombreCompleto == null || this.dorsal == null || this.fechaNacimiento == null || this.altura < 0.0 && this.pieHabil == null || this.valorMercado <= 0 || this.pais == null || this.puesto == null)
            {
                throw new Exception("Los datos deben estar completos");
            }
        }

        public void ValidarValorMercado()
        {
            if (valorMercado < 0)
            {
                throw new Exception("El valor de mercado debe ser mayor a 0");
            }
        }
        #endregion

        #region Override y Compare
        public override string ToString()
        {
            return "Nombre: "+this.nombreCompleto+"\n Valor Mercado: "+this.valorMercado;
        }

        public int CompareTo(Object obj)
        {
            Jugador aComparar = (Jugador)obj;
            return aComparar.valorMercado.CompareTo(this.valorMercado);
        }
        #endregion
        #endregion
    }
}
