using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TP1
{
    abstract class Ejercicio7
    {
        public static void Cadenas()
        {
            Console.WriteLine("\n\nEl método Length sirve para saber la cantidad de caracteres de la cadena");
            Console.WriteLine("Por ejemplo la cadena 'cinco' tiene " + "cinco".Length + " caracteres");

            Console.WriteLine("\n\nEl método Contains sirve para saber si una cadena contiene otra " +
                              "cadena o char");
            Console.WriteLine("Por ejemplo la respuesta de si la cadena 'cinco' contiene " +
                              "los caracteres 'cin' es " + "cinco".Contains("cin"));

            Console.WriteLine("\n\nEl método IndexOf sirve para saber el índice de la posición de" +
                              "un caracter dentro de una cadena");
            Console.WriteLine("Por ejemplo el caracter 'n' se encuentra en la posición " +
                             ("cinco".IndexOf("n")+1) + " de la cadena 'cinco'");

            Console.WriteLine("\n\nEl método Remove sirve para eliminar porción del contenido" +
                              " de una cadena pasando como parámetro el indice de inicio de eliminación" +
                              " y la cantidad de charse a ser eliminados");
            Console.WriteLine("Por ejemplo la cadena 'cinco' sin 'cin' es " +
                             "cinco".Remove(0, 3));

            Console.WriteLine("\n\nEl método Replace sirve para reemplazar un char o secuencia de chars" +
                              " contenidos en una cadena por un nuevo valor");
            Console.WriteLine("Por ejemplo podemos corregir la cadena 'sinco' de esta manera: " +
                             "cinco".Replace("s", "c"));

            Console.WriteLine("\n\nEl método Substring nos permite extraer porción del contenido" +
                              " de una cadena pasando como parámetro el indice de inicio" +
                              " y la cantidad de chars a ser extraídos para la nueva cadena resultante");
            Console.WriteLine("Por ejemplo podemos extraer los chars 2,3 y 4 de la cadena 'cinco' " +
                              "y de esta manera obtener: " + "cinco".Substring(1, 3));

            Console.WriteLine("\n\nEl método Append nos permite añadir nuevo contenido" +
                              " a una cadena de la clase StringBuilder");
            StringBuilder cadena = new StringBuilder("cin");
            Console.WriteLine("Por ejemplo podemos completa la palabra 'cinco' de la siguiente manera: " + 
                              cadena.Append("co"));

            Console.WriteLine("\n\nEl método ToUpper sirve para pasar toda la cadena a mayúsculas");
            Console.WriteLine("Por ejemplo la cadena 'cinco' pasa a ser " + "cinco".ToUpper());

            Console.WriteLine("\n\nEl método ToLower sirve para pasar toda la cadena a minúsculas");
            Console.WriteLine("Por ejemplo la cadena 'CINCO' pasa a ser " + "CINCO".ToLower());
        }
    }
}
