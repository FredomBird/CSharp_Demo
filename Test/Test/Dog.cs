using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Dog:Animal
    {
        public override void EatFood()
        {
            Console.WriteLine("Dog EatFood");
            //base.EatFood();
        }
    }
}
