using System;

namespace DotNetCource.OOPBasics2
{
    /*
     - SimpleExceptionExample
     - InterfaceExample
     - ShapeExample
     - Arrays
     - ImplicitExplicit
     - InterfaceHierarchy
     - Enumerable
     - CloneablesComparables
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var str = "dsfdfsds";
            var str1 = str.ToLower();
            var res = object.ReferenceEquals(str, str1);
            Console.ReadLine();
        }
    }
}