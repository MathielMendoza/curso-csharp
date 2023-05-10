using System;

namespace TiposPredefinidos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Tipos enteros
            //System.Int32
            int entero = 100; // 32 bits;
            //System.Int16
            short s = 140; // 16 bits
            //System.Byte
            byte b = 10; // 8 bits
            //System.Int64
            long largo = 123412412312; // 64 bits

            Console.WriteLine("int: {0}, short:{1}", entero, s);

            //Tipos flotantes
            //System.Single
            float f = 123.5f;
            //System.Double
            double d = 3.14159;
            //System.Decimal -> utilizado para operaciones financieras
            decimal dec = 129.99m;

            Console.WriteLine("float: {0}, dec:{1}", f, dec);

            //Otros
            //System.Char
            char c = 'E';
            //System.Boolean -> Representa un valor verdadero o falso
            bool booleano = true;

            Console.WriteLine("char: {0}", c);
            Console.WriteLine("bool: {0}", booleano);
        }
    }
}