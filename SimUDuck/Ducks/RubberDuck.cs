using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class RubberDuck : Duck
    {
        public override string display()
        {
            return "Резиновая утка " + " " + flyBehavior.fly() + quackBehavior.quack() + GetType(); ;
        }
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squack();
        }
    }
}
