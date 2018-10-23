using System;

namespace Ejercicio5
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
            int mayor;
            int medio;
            int menor;

            //Definir numero Mayor
            if (n1 > n2 && n1 > n3){
                mayor = n1;
            }else if (n2 > n1 && n2 > n3){
                mayor = n2;
            }else{
                mayor = n3;
            }
            //Definir numero Menor
            if (n1 < n2 && n1 < n3){
                menor = n1;
            }else if (n2 < n1 && n2 < n3){
                menor = n2;
            }else{
                menor = n3;
            }
            //Denifir numero del Medio
            if (n1 > menor && n1 < mayor){
                medio = n1;
            }else if (n2 > menor && n2 < mayor){
                medio = n2;
            }else{
                medio = n3;
            }
            Console.WriteLine("{0} {1} {2}", menor, medio, mayor);
        }
    }
}
