using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassInheritance
{
    public class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("BaseClass: Method1 ");
        }

        public void Method2()
        {
            Console.WriteLine("BaseClass: Method2 ");
        }
    }

    public class DerivedClass : BaseClass
    {

    }
}
