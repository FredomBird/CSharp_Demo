using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Animal:Biology
    {
        public int a = 1;
        public override void Live()
        {
            Console.WriteLine("Animal重写的Live");
            //throw new NotImplementedException();
        }
        public void Sleep()
        {
            Console.WriteLine("Animal Sleep");
        }
        public int Sleep(int time)
        {
            Console.WriteLine("Animal在{0}点Sleep", time);
            return time;
        }
        public virtual void EatFood()
        {
            Console.WriteLine("Animal EatFood");
        }
    }
}
