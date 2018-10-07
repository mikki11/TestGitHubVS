using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassInheritance
{
    public class BaseClass
    {
        public virtual void Method1()
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
        public override void Method1()
        {
            //base.Method1();
            Console.WriteLine("Derived Method1");

        }
        public new void Method2()
        {
            Console.WriteLine("Derived Method2");
        }

    }
}
