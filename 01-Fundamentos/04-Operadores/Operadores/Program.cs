using System;

namespace Operadores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 30;
            int b = 11;

            // Operadores aritméticos
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b); // módulo
            bool par = a % 2 == 0;
            Console.WriteLine(par);

            // Operadores unarios
            a++; // a = a + 1;
            a--; // a = a - 1 

            // Operadores de comparación
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
        }
    }
}