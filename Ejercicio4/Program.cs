using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****Ingrese un Numero del 1 al 12 ****\n");

            String s1 = null;
            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":
                    Console.WriteLine("El numero corresponde al Mes de Enero");
                    break;
                case "2":
                    Console.WriteLine("El numero corresponde al Mes de Febrero");
                    break;
                case "3":
                    Console.WriteLine("El numero corresponde al Mes de Marzo");
                    break;
                case "4":
                    Console.WriteLine("El numero corresponde al Mes de Abril");
                    break;
                case "5":
                    Console.WriteLine("El numero corresponde al Mes de Mayo");
                    break;
                case "6":
                    Console.WriteLine("El numero corresponde al Mes de Junio");
                    break;
                case "7":
                    Console.WriteLine("El numero corresponde al Mes de Julio");
                    break;
                case "8":
                    Console.WriteLine("El numero corresponde al Mes de Agosto");
                    break;
                case "9":
                    Console.WriteLine("El numero corresponde al Mes de Septiembre");
                    break;
                case "10":
                    Console.WriteLine("El numero corresponde al Mes de Octubre");
                    break;
                case "11":
                    Console.WriteLine("El numero corresponde al Mes de Noviembre");
                    break;
                case "12":
                    Console.WriteLine("El numero corresponde al Mes de Diciembre");
                    break;
                default:
                    break;
            }
        }
    }
}
