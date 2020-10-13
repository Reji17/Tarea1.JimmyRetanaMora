using System;

namespace Tarea1.JimmyRetanaMora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa");
            Console.WriteLine("Menú Principal");
            Console.WriteLine("Seleccione una opción escribiendo el número de la misma y luego presionando Enter");
            Console.WriteLine("1-Registrar clientes");
            Console.WriteLine("2-Registrar funcionarios");
            Console.WriteLine("3-Registrar hidrómetro");
            Console.WriteLine("4-Registrar categoría de servicios");
            Console.WriteLine("5-Mostrar todos los registros");
            Console.WriteLine("6-Salir");

            switch (Console.Read())
            {
                case '1':
                    Console.Write("Registro de clientes");
                    break;
                case '2':
                    Console.Write("Regristro de funcionarios");
                    break;
                case '3':
                    Console.Write("Registro de hidrómetros");
                    break;
                case '4':
                    Console.Write("Registro de categoría de servicios");
                    break;
                case '5':
                    Console.Write("Mostrando todos los registros");
                    break;
                case '6':
                    Console.Write("Finalizando el programa");
                    Environment.Exit(0);
                    break;
            }
            /*Crear menu*/

        }
    }
}
