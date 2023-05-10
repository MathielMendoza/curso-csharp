using System;

namespace MiembrosEstaticos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Para acceder a los miembros estáticos se usa solo el nombre de la clase
            CuentaBancaria cuenta1 = new CuentaBancaria("001", "John Doe", 100);
            CuentaBancaria cuenta2 = new CuentaBancaria("002", "Jane Doe", 250);

            CuentaBancaria.Banco = "Mi Banco";

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);
        }
    }
}