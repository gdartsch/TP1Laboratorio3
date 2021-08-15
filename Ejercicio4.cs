using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TP1
{
    abstract class Ejercicio4
    {
        public static void SolicitarOperacion()
        {
            bool valorValido = false;
            float resultado = 0;

            while (!valorValido)
            {
                Console.WriteLine("Ingrese el primer número para realizar la operación");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número para realizar la operación");
                float num2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la operación a realizar (+, - , * , / o %)");
                string operacion = Console.ReadLine();

                switch (operacion)
                {
                    case "+":
                        valorValido = true;
                        resultado = Suma(num1, num2);
                        break;
                    case "-":
                        valorValido = true;
                        resultado = Resta(num1, num2);
                        break;
                    case "*":
                        valorValido = true;
                        resultado = Multiplicacion(num1, num2);
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            valorValido = true;
                            resultado = Division(num1, num2);
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero");
                            valorValido = false;
                        }
                        break;
                    case "%":
                        valorValido = true;
                        resultado = Modulo(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Operación inválida");
                        valorValido = false;
                        break;
                }
            }

            Console.WriteLine("El resultado de la operación es: " + resultado);
        }

        private static float Suma(float num1, float num2)
        {
            return num1 + num2;
        }

        private static float Resta(float num1, float num2)
        {
            return num1 - num2;
        }

        private static float Multiplicacion(float num1, float num2)
        {
            return num1 * num2;
        }

        private static float Division(float num1, float num2)
        {
            return num1 / num2;
        }

        private static float Modulo(float num1, float num2)
        {
            return num1 % num2;
        }
    }
}
