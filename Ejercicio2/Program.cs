using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            string numero = Console.ReadLine();
            int x = 0;
            bool logrado = Int32.TryParse(numero, out x);
            if (logrado)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("Es Par");
                }
                else
                {
                    Console.WriteLine("Es ImPar");
                }
            }
            else {
                Console.WriteLine("Ingrese solo numeros");
            }
        }
    }
}
