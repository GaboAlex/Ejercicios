using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("\n****Ingrese un Numero relacionado a un Dia ****\n" +
                "\n1.- Lunes" +
                "\n2.- Martes" +
                "\n3.- Miercoles" +
                "\n4.- Jueves" +
                "\n5.- Viernes" +
                "\n6.- Sabado" +
                "\n7.- Domingo \n");

            String s1 = null;
            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":   
                    Console.WriteLine("El dia es Lunes");
                    break;
                case "2":
                    Console.WriteLine("El resultado es Martes");
                    break;
                case "3":
                    Console.WriteLine($"El resultado es Miercoles");
                    break;
                case "4":
                    Console.WriteLine($"El resultado es Jueves");
                    break;
                case "5":
                    Console.WriteLine($"El resultado es Viernes");
                    break;
                case "6":
                    Console.WriteLine($"El resultado es Sabado");
                    break;
                case "7":
                    Console.WriteLine($"El resultado es Domingo");
                    break;
                default:
                    break;
            }
        }
    }
}
