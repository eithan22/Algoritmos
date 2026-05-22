using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Problema_2
{
    public class SumaDosNumeros : ISumaDosNumeros
    {
        public void CalcularSuma()
        {
            // Pedir datos al usuario
            Console.Write("Digite el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite el tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());


            

            if(numero1 + numero2 == numero3 || numero1 + numero3 == numero2 || numero2 + numero3 == numero1)
            {
                Console.WriteLine("Iguales");
            }
            else
            {
                Console.WriteLine("Distintos");
            }
           
        }
    
    }
}
