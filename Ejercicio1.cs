using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TP1
{
    abstract class Ejercicio1
    {
        public static void MostrarNumeros()
        {
            Console.WriteLine("Con blucle for");
            for (int i = 0; i < 100; i++)
            {
                //Console.WriteLine("safsd");
                CalcularModulo(i + 1);
            }

            Console.WriteLine("Con blucle while");
            int num = 1;
            while (num < 101)
            {
                CalcularModulo(num);
                num++;
            }

            Console.WriteLine("Con blucle do-while");
            num = 1;
            do
            {
                CalcularModulo(num);
                num++;
            } while (num < 101);
        }

        private static void CalcularModulo(int n)
        {
            if (n % 2 == 0 && n % 5 == 0) { Console.WriteLine(n); }
        }
    }
}
