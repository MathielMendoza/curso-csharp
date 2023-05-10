using OtroNamespaces;

namespace ControlAcceso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MiClase obj1 = new MiClase();
            
            obj1.MetodoPublico();
            obj1.MetodoInternal();
            //obj1.MetodoProtected();
            //obj1.MetodoPrivate();
        }
    }
}