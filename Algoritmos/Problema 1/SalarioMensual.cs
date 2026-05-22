using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Problema_1
{
    public class SalarioMensual : ISalarioMensual
    {
        public void CalcularSalarioMensual()
        {

            //Pedir datos al usuario
            Console.Write("Digite las horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());


            Console.Write("Digite la tarifa por hora: ");
            decimal tarifaHoraria = decimal.Parse(Console.ReadLine());


            if (horasTrabajadas <= 0 || tarifaHoraria <= 0)
            {
                Console.WriteLine("Las horas trabajadas y la tarifa horaria deben ser valores positivos.");
                return;
            }

            if(horasTrabajadas <= 40)
            {
                decimal salario = horasTrabajadas * tarifaHoraria;
                Console.WriteLine($"El salario mensual es: {salario}");
            }
            else
            {
                int horasExtra = horasTrabajadas - 40;
                decimal salario = (40 * tarifaHoraria) + (horasExtra * tarifaHoraria * 1.5m);
                Console.WriteLine($"El salario mensual es: {salario}");
            }
        }
    }
}
