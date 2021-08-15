using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio(1);
            Ejercicio1.MostrarNumeros();

            Ejercicio(2);
            Ejercicio2.EncontrarNumAleatorio();

            Ejercicio(3);
            Ejercicio3.ParOImpar();

            Ejercicio(4);
            Ejercicio4.SolicitarOperacion();

            Ejercicio(5);
            Ejercicio5.CalcularSueldo();

            Ejercicio(6);
            Ejercicio6.Recursion();

            Ejercicio(7);
            Ejercicio7.Cadenas();
            Console.WriteLine("\n\n");
        }

        private static void Ejercicio(int num)
        {
            Console.WriteLine("\n\n --------------------------------" +
                              $" \n Ejercicio {num} " +
                              "\n --------------------------------\n");
        }
    }
}
