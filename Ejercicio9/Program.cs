using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Ingrese tres numero***\n");
            Console.WriteLine("Ingrese Primer numero: ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo numero: ");
            int n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Tercer numero: ");
            int n3 = Int32.Parse(Console.ReadLine());
            int suma = n1 + n2;
            if (n3 == suma)
            {
                Console.WriteLine("El tercer numero es igual a la suma de los dos primeros");
            }
            else {
                Console.WriteLine("El tercer numero no es igual a la suma de los dos primeros");
            }
        }
    }
}
