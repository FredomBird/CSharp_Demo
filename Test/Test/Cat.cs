using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Cat:Animal
    {
        public  int a = 2;
        public override void EatFood()
        {
            Console.WriteLine("Cat EatFood");
            //base.EatFood();
        }
        new public void Sleep()
        {
            Console.WriteLine("Cat Sleep");
        }
        //public new void Sleep()
        //{
        //    Console.WriteLine("Cat Sleep");
        //}
    }
}
