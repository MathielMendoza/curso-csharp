using System;

namespace Ciclos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Ciclo For

            Console.WriteLine("Usando ciclo For");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor del contador i: {0}", i);
            }

            //Ciclo While
            Console.WriteLine("\nUsando ciclo While");
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine("Valor del contador i: {0}", n);
                n++;
            }

            //Ciclo Do - While
            Console.WriteLine("\nUsando ciclo Do - While");
            int c = 0;
            do
            {
                Console.WriteLine("Valor del contador c: {0}", c);
                c++;
            } while (c < 5);
        }
    }
}