using System;

namespace MetodosDeInstancia
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria("001", "John Doe", 100);
            CuentaBancaria cuenta2 = new CuentaBancaria("002", "Jane Doe", 250);

            Console.WriteLine(cuenta1.ToString());
            /* C# sabe en automatico que quiero convertirlo a una cadena
            por que Console.WriteLine espera recibir una cadena*/
            Console.WriteLine(cuenta2);

            //Llamando a los métodos depositar y retirar
            Console.WriteLine("Depositar $70 en cuenta1");
            cuenta1.Depositar(70);

            Console.WriteLine("Retirar $20 en cuenta2");
            cuenta2.Retirar(20);

            Console.WriteLine(cuenta1.ToString());
            Console.WriteLine(cuenta2.ToString());
        }
    }
}