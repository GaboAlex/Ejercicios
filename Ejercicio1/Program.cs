using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 5");
            int n1 = Int32.Parse(Console.ReadLine());
            int res = n1 % 2;
            if (res != 0)
            {
                Console.WriteLine("El numero ingresado es primo");
            }
            else if (n1 == 2)

            {
                Console.WriteLine("El numero ingresado es primo");
            }
            else {
                Console.WriteLine("El numero ingresado NO es primo");
            }
        }
    }
}
