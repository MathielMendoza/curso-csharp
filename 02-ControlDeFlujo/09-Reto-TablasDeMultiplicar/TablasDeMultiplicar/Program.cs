using System;

namespace TablasDeMultiplicar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número");
            string numero = Console.ReadLine();
            int num = int.Parse(numero);

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("La tabla de multiplicar de {0} es: ", num);

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = num * i;
                    Console.WriteLine("{0} x {1} = {2}", num, i, resultado);
                }
            }
            else
            {
                Console.WriteLine("El número ingresado debe estar entre 1 y 10");
            }
        }
    }
}