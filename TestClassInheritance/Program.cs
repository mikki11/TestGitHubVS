using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            Console.WriteLine("Base:");
            bc.Method1();
            bc.Method2();
            Console.WriteLine();
            Console.WriteLine("Derived:");
            dc.Method1();
            dc.Method2();
            Console.WriteLine();
            Console.WriteLine("BaseInstantinateAsDerived:");
            bcdc.Method1();
            bcdc.Method2();







            Console.ReadLine();
        }
    }
}
