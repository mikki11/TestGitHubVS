using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.LearnRepos;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //UnitOfWork unit = new UnitOfWork();
            //var xx = unit.UserRepository.Insert()
            MyControler mc1 = new MyControler();
            var xx = mc1.GetTest();
            foreach (var item in xx)
            {
                Console.WriteLine(item.Bonus);
            }
            Console.WriteLine("end\n");
            var yy = mc1.GetTen();
            foreach (var item in yy)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
