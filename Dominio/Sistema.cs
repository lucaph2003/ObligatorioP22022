using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Sistema
    {
        private static Sistema _instancia;

        public List<Jugador> Jugadores { get; } = new List<Jugador>();
        public List<Periodista> Periodistas { get; } = new List<Periodista>();
        public List<Seleccion> Selecciones { get; } = new List<Seleccion>();

        public static Sistema ObtenerInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sistema();
                }
                return _instancia;
            }
        }

        private Sistema()
        {

        }


        public void AgregarJugador(string nombre, string apellido, int dorsal, DateTime fechaNacimiento, decimal altura, int pieHabil, int ValorMercado, Pais pais, int puesto)
        {
            try
            {
                Jugador jugador = new Jugador(nombre, apellido, dorsal, fechaNacimiento, altura, pieHabil, ValorMercado, pais, puesto);

                jugador.Validar();
                Jugadores.Add(jugador);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AgregarPeriodista(string nombre,string apellido,string email,string password)
        {
            try
            {
                Periodista periodista = new Periodista(nombre, apellido, email, password);
                periodista.Validar();
                Periodistas.Add(periodista);
            }catch(Exception e)
            {
                throw e;
            }
        }

        public void AgregarPais(string nombre,string codigo)
        {
            try
            {
                Pais pais = new Pais(nombre, codigo);
                pais.Validar();
            }catch (Exception e)
            {
                throw e;
            }
        }


            
    }
}
