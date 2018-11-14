using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp1
{
    [Obsolete("This class is obsolete; use class 1 instead")]
    [MyAttribute]
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("My Class");
        }
    }
}
