using System;
using System.Reflection;

namespace SampleConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            MyClass myClass = new MyClass();
            TypeInfo typeInfo = typeof(MyClass).GetTypeInfo();
            var attributes = typeInfo.GetCustomAttributes();
            foreach(var attribute in attributes)
            {
                Console.WriteLine($"Attributes on MyClass: {attribute.GetType().Name}");
            }
        }
    }
}
