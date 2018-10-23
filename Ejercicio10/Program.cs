using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una calculadora que pida un operación(suma, resta, multiplicación, división y potencia) 
            //y luego 2 números para resolver la operación.
            Console.WriteLine("*************CALCULADORA***************\n");
            

            Console.WriteLine("\n****Elige una opcion ****\n" +
                "\n1.- Suma" +
                "\n2.- Resta" +
                "\n3.- Multiplicar" +
                "\n4.- Division" +
                "\n5.- Potencia \n");
            String s1 = null;
            s1 = Console.ReadLine();

            Console.WriteLine("Ingrese Primer numero: ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo numero: ");
            int n2 = Int32.Parse(Console.ReadLine());

            switch (s1)
            {
                case "1":
                    int suma = n1 + n2;
                    Console.WriteLine($"El resultado es: {suma}");
                    break;
                case "2":
                    int resta = n1 - n2;
                    Console.WriteLine($"El resultado es: {resta}");
                    break;
                case "3":
                    int multiplicacion = n1 * n2;
                    Console.WriteLine($"El resultado es: {multiplicacion}");
                    break;
                case "4":
                    int division = n1 / n2;
                    Console.WriteLine($"El resultado es: {division}");
                    break;
                case "5":
                    int potencia = n1 ^ n2;
                    Console.WriteLine($"El resultado es: {potencia}");
                    break;
                default:
                    Console.WriteLine("Ingreso incorrecto");
                    break;

            }
            Console.ReadLine();
        }
    }
}
