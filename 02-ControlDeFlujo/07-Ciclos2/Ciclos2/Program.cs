using System;

namespace Ciclos2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Uso de break");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; // termina con el ciclo
                }

                Console.WriteLine("Valor del contador i: {0}", i);
            }

            Console.WriteLine("\nUso de continue");
            int n = 0;
            while (n < 10)
            {
                if (n % 2 == 0)
                {
                    n++;
                    continue;
                }

                Console.WriteLine("Valor del contador n: {0}", n);
                n++;
            }
        }
    }
}