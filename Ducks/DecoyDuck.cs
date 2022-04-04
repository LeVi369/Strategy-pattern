using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class DecoyDuck : Duck
    {
        public override string display()
        {
            return "Деревянная бошка " + " " + flyBehavior.fly() + quackBehavior.quack() + GetType(); ;
        }
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
    }
}