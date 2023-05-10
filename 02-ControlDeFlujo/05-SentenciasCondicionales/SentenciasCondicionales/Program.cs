using System;

namespace SentenciasCondicionales
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // If
            int num = 10;
            if (num > 5)
            {
                Console.WriteLine("num es mayor que 5");
            }

            // If - Else
            int edad = 23;
            if (edad >= 18)
            {
                Console.WriteLine("mayor de edad");
            }
            else
            {
                Console.WriteLine("menor de edad");
            }

            //If - Else If
            int a = 8;
            int b = 8;

            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} < {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} == {1}", a, b);
            }

            // Switch

            string codigo = "A45";

            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("Producto 1");
                    break;
                case "A2":
                    Console.WriteLine("Producto 1");
                    break;
                case "A3":
                    Console.WriteLine("Producto 1");
                    break;
                default:
                    Console.WriteLine("Producto no encontrado");
                    break;
            }
        }
    }
}