using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TP1
{
    abstract class Ejercicio5
    {
        static int horaIngreso;
        static int minutoIngreso;
        static int horaSalida;
        static int minutoSalida;
        static int minutosTrabajados;
        static bool horarioNocturno;

        public static void CalcularSueldo()
        {
            while (true)
            {
                IngresarDatos();
                minutosTrabajados = CalcularTiempoTrabajado();

                if (minutosTrabajados <= 480)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("No puede asignar jornada laboral mayor a 8 horas");
                }
            }

            horarioNocturno = CalcularHorarioNocturno();

            Console.WriteLine("Las horas trabajadas fueron: " + CalcularHorasTrabajadas());

            Console.WriteLine("El sueldo que debe cobrar es: " + CalcularSueldoTotal());
        }

        private static float CalcularHorasTrabajadas()
        {
            return minutosTrabajados / 60;
        }

        private static float CalcularSueldoTotal()
        {
            if (horarioNocturno)
            {
                return (minutosTrabajados * (10 / 60.0f)) * 1.5f;
            }

            return minutosTrabajados * (10 / 60.0f);
        }

        private static bool CalcularHorarioNocturno()
        {
            if (horaIngreso > 8 && horaIngreso < 20)
            {
                return false;   
            }

            return true;
        }

        private static int CalcularTiempoTrabajado()
        {
             return ((horaSalida - horaIngreso) * 60) +
                     (minutoSalida - minutoIngreso);
        }

        private static void IngresarDatos()
        {
            while (true)
            {
                horaIngreso = HoraValida("ingreso");
                minutoIngreso = MinutoValido("ingreso");

                horaSalida = HoraValida("salida");
                minutoSalida = MinutoValido("salida");

                if (horaIngreso < horaSalida && minutoIngreso < minutoSalida)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(
                        "La hora/minuto de ingreso no debe ser mayor que la hora/minuto de egreso");
                }
            }
        }

        private static int HoraValida(string detalle)
        {
            int valor = 0;

            do
            {
                Console.WriteLine($"Ingrese la hora de {detalle} del trabajador");
                valor = int.Parse(Console.ReadLine());

            } while (!(0 <= valor && valor <= 23));

            return valor;
        }

        private static int MinutoValido(string detalle)
        {
            int valor = 0;

            do
            {
                Console.WriteLine($"Ingrese el minuto de {detalle} del trabajador");
                valor = int.Parse(Console.ReadLine());

            } while (!(0 <= valor && valor <= 60));

            return valor;
        }
    }
}
