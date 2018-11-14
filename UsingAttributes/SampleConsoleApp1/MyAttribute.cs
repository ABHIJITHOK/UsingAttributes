using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp1
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MyAttribute : Attribute
    {
        public MyAttribute()
        {
            Console.WriteLine("Do stuff for MyAttribute");
        }
    }
}
