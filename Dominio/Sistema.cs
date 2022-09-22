using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema _instancia;

        public List<Jugador> Jugadores { get; } = new List<Jugador>();
        public List<Periodista> Periodistas { get; } = new List<Periodista>();
        public List<Seleccion> Selecciones { get; } = new List<Seleccion>();
        public List<Pais> Paises { get; } = new List<Pais>();

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


        public void AltaJugador(Jugador pJugador)
        {
            try
            {
                pJugador.Validar();
                Jugadores.Add(pJugador);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AltaSeleccion(Seleccion pSeleccion)
        {
            try
            {
                Selecciones.Add(pSeleccion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AgregarPeriodista(string nombre, string apellido, string email, string password)
        {
            try
            {
                Periodista periodista = new Periodista(nombre, apellido, email, password);
                periodista.Validar();
                Periodistas.Add(periodista);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AltaPais(Pais pPais)
        {
            try
            {
                pPais.Validar();
                Paises.Add(pPais);
            }
            catch (Exception e)
            {
                throw e;
           }
        }


        /// Retorna el País a partir del nombre.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Objeto país</returns>
        private Pais GetPais(string nombre)
        {

            foreach (Pais p in Paises)
            {
                if (p.nombre.Equals(nombre))
                {
                    return p;
                }
            }
            return null;
        }


        private void PrecargaSelecciones()
        {

            //Contamos con países y jugadores, la seleccion debe armar para cada pais una seleccion
            foreach (Pais p in Paises)
            {
                // 1 - Se crea una seleccion por cada país en la lista.
                Seleccion selNueva = new Seleccion(p);
                List<Jugador> misJugadores = JugadoresDe(p);
                foreach (Jugador j in misJugadores)
                {
                    selNueva.AgregarJugador(j);
                }
                AltaSeleccion(selNueva);
            }
        }


        /// Retorna todos los jugadores de una selección, a partir del país del jugador.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Lista de jugadores del país seleccionado</returns>
        private List<Jugador> JugadoresDe(Pais p)
        {
            List<Jugador> _misJugadores = new List<Jugador>();
            foreach (Jugador j in Jugadores)
            {

                if (j.pais.nombre.Equals(p.nombre))
                {
                    _misJugadores.Add(j);
                }
            }
            return _misJugadores;
        }

        ///Precarga Paises
        AltaPais(new Pais("Catar","QAT"));
        AltaPais(new Pais("Dinamarca", "DNK"));
        AltaPais(new Pais("Brasil", "BRA"));
        AltaPais(new Pais("Francia", "FRA"));
        AltaPais(new Pais("Alemania", "DEU"));
        AltaPais(new Pais("Bélgica", "BEL"));
        AltaPais(new Pais("Croacia", "HRV"));
        AltaPais(new Pais("España", "ESP"));
        AltaPais(new Pais("Serbia", "SRB"));
        AltaPais(new Pais("Inglaterra", "GBR"));
        AltaPais(new Pais("Suiza", "CHE"));
        AltaPais(new Pais("Países Bajos", "NLD"));
        AltaPais(new Pais("Argentina", "ARG"));
        AltaPais(new Pais("Irán", "IRN"));
        AltaPais(new Pais("Corea del Sur", "KOR"));
        AltaPais(new Pais("Japón", "JPN"));
        AltaPais(new Pais("Arabia Saudita", "SAU"));
        AltaPais(new Pais("Ecuador", "ECU"));
        AltaPais(new Pais("Uruguay", "URY"));
        AltaPais(new Pais("Canadá", "CAN"));
        AltaPais(new Pais("Ghana", "GHA"));
        AltaPais(new Pais("Senegal", "SEN"));
        AltaPais(new Pais("Marruecos", "MAR"));
        AltaPais(new Pais("Túnez", "TUN"));
        AltaPais(new Pais("Portugal", "PRT"));
        AltaPais(new Pais("Polonia", "POL"));
        AltaPais(new Pais("Camerún", "CMR"));
        AltaPais(new Pais("México", "MEX"));
        AltaPais(new Pais("Estados Unidos", "USA"));
        AltaPais(new Pais("Gales", "WLS"));
        AltaPais(new Pais("Australia", "AUS"));
        AltaPais(new Pais("Costa Rica", "CRI"));



    }


}
