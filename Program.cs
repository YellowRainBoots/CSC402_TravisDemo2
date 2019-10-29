using System;

namespace TravisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            Console.WriteLine("Hello World! " + myClass.ReturnMessage());
        }
    }
}
