using System;

namespace RetoClasePersona
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Persona p1 = new Persona("John","Due",30);
            Persona p2 = new Persona("Jane","Due",40);
            
            p1.Saludar();
            p2.Saludar();

            p1.Edad = -10;
            Console.WriteLine(p1);
        }
    }
}