using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            Console.WriteLine("Ingrese valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor 2");
            valor2 = int.Parse(Console.ReadLine());

            try
            {
                int x = (valor1/valor2);
            }
            catch (DivideByZeroException) { Console.WriteLine ("Estas dividiendo por 0"); }
            finally { Console.WriteLine("Funciona"); }

        }
    }
}
