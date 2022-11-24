using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class PartidoFaseEliminatoria : Partido
    {
        #region Atributos PartidoFaseEliminatoria
        public string etapa { get; set; }
        public bool alargue { get; set; }
        public bool penales { get; set; }
        public const string tipo = "FaseEliminatoria";
        #endregion
        #region Metodos PartidoFaseEliminatoria
        public PartidoFaseEliminatoria(Seleccion pSeleccion1, Seleccion pSeleccion2,DateTime pFechaHora, string pEtapa):base(pSeleccion1,pSeleccion2,pFechaHora)
        {
            this.etapa = pEtapa;
            this.alargue = false;
            this.penales = false;
            
        }

        public void HuboAlargue()
        {
            this.alargue = true;
        }

        public void HuboPenales()
        {
            this.penales = true;
        }

        public override void ValidarResultado()
        {
            if (this.penales)
            {
                this.resultadoFinal = "Empate en tiempo de juego. ";
                if (this.resultado1 > this.resultado2)
                {
                    this.resultadoFinal+= "Ganador: " + this.seleccion1.pais.nombre + " En tanda de penales";
                }
                else if (this.resultado1 < this.resultado2)
                {
                    this.resultadoFinal += "Ganador: " + this.seleccion1.pais.nombre + " En tanda de penales";
                }
            }
            else
            {
                if (this.resultado1 > this.resultado2)
                {
                    this.resultadoFinal = "Ganador: " + this.seleccion1.pais.nombre ;
                }
                else if (this.resultado1 < this.resultado2)
                {
                    this.resultadoFinal = "Ganador: " + this.seleccion1.pais.nombre ;
                }

                if (alargue)
                {
                    this.resultadoFinal += " En alargue";
                }
            }


        }

        public override void finalizarPartido()
        {
            if (!esFinalizada)
            {
                this.resultado1 = obtenerGolesSeleccion(this.seleccion1);
                this.resultado2 = obtenerGolesSeleccion(this.seleccion2);
                ValidarResultado();
                esFinalizada = true;
            }
            else
            {
                throw new Exception("El partido ya esta finalizado");
            }
        }

        public override string ObtenerTipo()
        {
            return tipo;
        }

        public override string ObtenerEtapa()
        {
            return this.etapa;
        }
        #endregion

    }
}
