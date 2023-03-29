using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ac = new Cat();
            Console.WriteLine(ac.a);
            ac.Sleep();
            Cat c = new Cat();
            c.Sleep();
            Console.ReadKey();
        }
    }
}
