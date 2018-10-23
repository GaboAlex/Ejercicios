using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sueldo = 50000;
            Console.WriteLine("Ingrese el numero de años Trabajados: ");
            int n1 = Int32.Parse(Console.ReadLine());
            double total = 0;
            if (n1 >= 10)
            {
                total = Sueldo + (Sueldo * 0.1);
            }
            else if (n1 < 10 && n1 >= 5)
            {
                total = Sueldo + (Sueldo * 0.07);
            }
            else if (n1 < 5 && n1 >= 3)
            {
                total = Sueldo + (Sueldo * 0.05);
            }
            else {
                total = Sueldo + (Sueldo * 0.03);
            }
            Console.WriteLine("El sueldo que recibira sera de: " + total);
        }
    }
}
