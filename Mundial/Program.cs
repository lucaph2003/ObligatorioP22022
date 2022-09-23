﻿using System;
using System.Collections.Generic;
using Dominio;

namespace Mundial
{
    class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = Sistema.ObtenerInstancia;
            int op;
            do
            {
                Console.WriteLine("Bienvenidos al Mundial Qatar2022! ! !");
                Console.WriteLine("");
                Console.WriteLine("Porfavor ingrese una opcion para continuar...");
                Console.WriteLine("1-Dar de alta a periodista");
                Console.WriteLine("2-Listar Periodista");
                Console.WriteLine("3-Ingresar Monto Referencia para categorias de jugadores");
                Console.WriteLine("0-Salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CrearPeriodista(sistema);
                        break;
                    case 2:
                        MostrarPeriodistas(sistema);
                        break;
                    case 3:
                        CambiarMontoCategoria(sistema);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ingresa una de las opciones validas! ! !");
                        Console.WriteLine("-----------------------------------------");
                        break;
                }
            } while (op != 0);
            
        }

        public static void CrearPeriodista(Sistema sistema)
        {
            try
            {
                Console.WriteLine("Registro de periodista");
                Console.WriteLine("Ingrese nombre completo: ");
                string nombreCompleto = Console.ReadLine();
                Console.WriteLine("Ingrese email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Ingrese contrasenia: ");
                string password = Console.ReadLine();
                Console.WriteLine("Repita la contrasenia: ");
                string rePassword = Console.ReadLine();
                if (password == rePassword)
                {
                    Periodista periodista = new Periodista(nombreCompleto, email, password);
                    sistema.AltaPeriodista(periodista);
                    Console.WriteLine("Registro exitoso! ! !");
                }else
                {
                    Console.WriteLine("Contrasenias diferentes");
                }

                Console.WriteLine("Presiona enter para continuar...");
                Console.ReadLine();
                Console.WriteLine("---------------------------------");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Presiona enter para continuar...");
                Console.ReadLine();
                Console.WriteLine("---------------------------------");
            }
            
        }

        public static void MostrarPeriodistas(Sistema sistema)
        {
            List<Periodista> periodistas = sistema.ObtenerPeriodistas();
            foreach(Periodista p in periodistas)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine("Presiona enter para continuar...");
            Console.ReadLine();
            Console.WriteLine("---------------------------------");
        }

        public static void CambiarMontoCategoria(Sistema sistema)
        {
            try
            {
                Console.WriteLine("Ingresa el nuevo monto: ");
                int monto = int.Parse(Console.ReadLine());
                sistema.CambiarMontoJugador(monto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
}
