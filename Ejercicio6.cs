using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TP1
{
    abstract class Ejercicio6
    {
        public static void Recursion()
        {
            ulong numIngresado;
            while (true)
            {
                Console.WriteLine("Ingrese un número mayor a 1");
                numIngresado = ulong.Parse(Console.ReadLine());

                if (numIngresado > 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido");
                }  
            }

            Console.WriteLine("El numero final es: " + CalcularRecursion(numIngresado));
        }

        private static ulong CalcularRecursion(ulong numIngresado)
        {
            numIngresado *= numIngresado;

            if (numIngresado > 100000000)
            {
                return numIngresado;
            }

            return CalcularRecursion(numIngresado);
        }
    }
}
