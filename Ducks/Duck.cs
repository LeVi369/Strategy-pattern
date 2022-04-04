using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Duck
    {
        public string swim()
        {
            return "Бульк";
        }
        public abstract string display();

        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;
        public string performQuack()
        {
            return quackBehavior.quack();
        }
        public string performFly()
        {
            return flyBehavior.fly();
        }
        public FlyBehavior setflyBehavior(FlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
            return flyBehavior;
        }
        public QuackBehavior setquackBehavior(QuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
            return quackBehavior;
        }
    }
}