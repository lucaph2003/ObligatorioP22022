using System;

namespace Mundial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al Mundial Qatar2022! ! !");
            Console.WriteLine("Presiona enter para continuar...");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Porfavor ingrese una opcion para continuar...");
            Console.WriteLine("1-Dar de alta a periodista");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1 :
                    CrearPeriodista();
                    break;
                    
            }
        }

        public static void CrearPeriodista()
        {
            try
            {
                Console.WriteLine("Registro de periodista");
                Console.WriteLine("Ingrese nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido: ");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingrese email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Ingrese contrasenia: ");
                string password = Console.ReadLine();
                Console.WriteLine("Repita la contrasenia: ");
                string rePassword = Console.ReadLine();
                if (password == rePassword)
                {
                    //regfistro de periodista
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
    }
}
