using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TP1
{
    abstract class Ejercicio2
    {
        public static void EncontrarNumAleatorio()
        {
            Random random = new Random();
            int numAleatorio = random.Next(0, 100);
            int contador = 1;

            while (true)
            {
                Console.WriteLine("Ingrese un número entre 0 y 100");
                int numIngresado = int.Parse(Console.ReadLine());
                if(numAleatorio > numIngresado) 
                    { Console.WriteLine("Es muy bajo"); }
                if (numAleatorio < numIngresado)
                    { Console.WriteLine("Es muy alto"); }
                if (numAleatorio == numIngresado)
                    { break; }
                contador++;
            }

            Console.WriteLine("Correcto, el número era " + numAleatorio);
            Console.WriteLine("Cantidad de intentos: " + contador);
        }
    }
}
