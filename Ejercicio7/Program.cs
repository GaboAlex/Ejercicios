using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una Letra");
            String s1 = null;
            s1 = Console.ReadLine();

            switch (s1)
            {
                case "a":
                    Console.WriteLine("La letra ingresada es una vocal");
                    break;
                case "e":
                    Console.WriteLine("La letra ingresada es una vocal");
                    break;
                case "i":
                    Console.WriteLine("La letra ingresada es una vocal");
                    break;
                case "o":
                    Console.WriteLine("La letra ingresada es una vocal");
                    break;
                case "u":
                    Console.WriteLine("La letra ingresada es una vocal");
                    break;
                default:
                    Console.WriteLine("La letra ingresada no es una vocal");
                    break;
            }
        }
    }
}
