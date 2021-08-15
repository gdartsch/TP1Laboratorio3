using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TP1
{
    abstract class Ejercicio3
    {
        public static void ParOImpar()
        {
            Console.WriteLine("Ingrese un número para saber si es par o impar");

            int numIngresado = int.Parse(Console.ReadLine());

            if (EsPar(numIngresado)) 
                { Console.WriteLine("El numero ingresado es par"); }
            else 
                { Console.WriteLine("El numero ingresado es impar"); }
        }

        private static bool EsPar(int numIngresado)
        {
            return numIngresado % 2 == 0;
        }
    }
}
