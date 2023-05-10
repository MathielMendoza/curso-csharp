namespace MyNamespace
{
    class MyClass
    {
        public void MyMethod()
        {
            System.Console.WriteLine("Dentro de MyNameSpace.MyClass.MyMethod()");
        }
    }
}

namespace otherNamespace
{
    class MyClass
    {
        public void MyMethod()
        {
            System.Console.WriteLine("Dentro de otherNamespace.MyClass.MyMethod()");
        }
    }
}

namespace Namespaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Creando objetos de clases contenidas en otros namespaces
            MyNamespace.MyClass myClass = new MyNamespace.MyClass();
            otherNamespace.MyClass otherClass = new otherNamespace.MyClass();
            
            // Llamando a los metodos de las clases
            myClass.MyMethod();
            otherClass.MyMethod();
        }
    }
}