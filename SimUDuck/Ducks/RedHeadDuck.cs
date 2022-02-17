using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class RedHeadDuck : Duck
    {
        public override string display()
        {
            return "У меня красная голова!" + " " + flyBehavior.fly() + quackBehavior.quack() + GetType(); ;
        }
        public RedHeadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
    }
}
