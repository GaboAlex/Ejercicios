using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un Numero para Verificar si es Positivo o Negativo");
            int n1 = Int32.Parse(Console.ReadLine());
            if (n1 == 0) {
                Console.WriteLine("Ingrese otro numero diferente de 0");
                n1 = Int32.Parse(Console.ReadLine());
            }

            if (n1 > 0)
            {
                Console.WriteLine("El numero ingresado es Positivo");
            } else {
                Console.WriteLine("El numero es Negativo");
            }
            

        }
    }
}
