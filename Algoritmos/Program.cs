using System;
using Algoritmos.Problema_1;
using Algoritmos.Problema_2;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("      SISTEMA DE ALGORITMOS");
                Console.WriteLine("================================");
                Console.WriteLine("1. Calcular salario");
                Console.WriteLine("2. Suma de Dos numeros igual al tercero");
                Console.WriteLine("0. Salir");
                Console.WriteLine("================================");

                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("\nDebe ingresar un número válido.");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:

                        ISalarioMensual salario = new SalarioMensual();

                        salario.CalcularSalarioMensual();

                        Console.WriteLine("\nPresione una tecla...");
                        Console.ReadKey();

                        break;

                    case 2:

                        ISumaDosNumeros suma = new SumaDosNumeros();

                        suma.CalcularSuma();

                        Console.WriteLine("\nPresione una tecla...");
                        Console.ReadKey();

                        break;

                    case 0:

                        Console.WriteLine("Saliendo...");

                        break;

                    default:

                        Console.WriteLine("Opción inválida");

                        Console.ReadKey();

                        break;
                }
            
            } while (opcion != 0);







        }
    }

}