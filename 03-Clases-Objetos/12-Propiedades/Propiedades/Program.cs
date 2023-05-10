using System;

namespace Propiedades
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();

            cuenta.Saldo = -5;
            Console.WriteLine("Saldo después de primera asignación: {0}", cuenta.Saldo);
            
            cuenta.Saldo = 10;
            Console.WriteLine("Saldo después de primera asignación: {0}", cuenta.Saldo);
        }
    }
}