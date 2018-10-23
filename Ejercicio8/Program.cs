using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0;
            int menor = 10;
            Console.WriteLine("Ingrese Primer numero: ");
            int n1 = Int32.Parse(Console.ReadLine());
            if (n1 > mayor)
            {
                mayor = n1;
            }
            else if (n1 < menor)
            {
                menor = n1;
            }
            Console.WriteLine("Ingrese Segundo numero: ");
            int n2 = Int32.Parse(Console.ReadLine());
            if (n2 > mayor)
            {
                mayor = n2;
            }
            else if (n2 < menor)
            {
                menor = n2;
            }
            Console.WriteLine("Ingrese Tercer numero: ");
            int n3 = Int32.Parse(Console.ReadLine());
            if (n3 > mayor)
            {
                mayor = n3;
            }
            else if (n3 < menor)
            {
                menor = n3;
            }
            Console.WriteLine("Ingrese Cuarto numero: ");
            int n4 = Int32.Parse(Console.ReadLine());
            if (n4 > mayor)
            {
                mayor = n4;
            }
            else if (n4 < menor)
            {
                menor = n4;
            }
            Console.WriteLine("Ingrese Quinto numero: ");
            int n5 = Int32.Parse(Console.ReadLine());
            if (n5 > mayor)
            {
                mayor = n5;
            }
            else if (n5 < menor)
            {
                menor = n5;
            }
            Console.WriteLine("Ingrese Sexto numero: ");
            int n6 = Int32.Parse(Console.ReadLine());
            if (n6 > mayor)
            {
                mayor = n6;
            }
            else if (n6 < menor)
            {
                menor = n6;
            }
            Console.WriteLine("Ingrese Septimo numero: ");
            int n7 = Int32.Parse(Console.ReadLine());
            if (n7 > mayor)
            {
                mayor = n7;
            }
            else if (n7 < menor)
            {
                menor = n7;
            }
            Console.WriteLine("Ingrese Octavo numero: ");
            int n8 = Int32.Parse(Console.ReadLine());
            if (n8 > mayor)
            {
                mayor = n8;
            }
            else if (n8 < menor)
            {
                menor = n8;
            }
            Console.WriteLine("Ingrese Noveno numero: ");
            int n9 = Int32.Parse(Console.ReadLine());
            if (n9 > mayor)
            {
                mayor = n9;
            }
            else if (n9 < menor)
            {
                menor = n9;
            }
            Console.WriteLine("Ingrese Decimo numero: ");
            int n10 = Int32.Parse(Console.ReadLine());
            if (n10 > mayor)
            {
                mayor = n10;
            }
            else if (n10 < menor)
            {
                menor = n10;
            }
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);
        }
    }
}
