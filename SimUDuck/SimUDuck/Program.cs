using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck1 = new MallardDuck();
            Duck duck2 = new RedHeadDuck();
            Duck duck3 = new RubberDuck();
            Duck duck4 = new DecoyDuck();
            Duck[] masDuck = new Duck[] { duck1, duck2, duck3, duck4 };
           foreach (Duck ma in masDuck)
            {
                Console.WriteLine(ma.swim()+ma.display() + ma.performFly() + ma.performQuack());
            }
            FlyBehavior flyBehavior = new FlyNoWay();
            QuackBehavior quackBehavior = new Squack();
            duck2.setquackBehavior(quackBehavior);
            duck1.setflyBehavior(flyBehavior);

            Console.WriteLine(duck2.display());
            Console.WriteLine(duck2.performQuack());
            Console.WriteLine(duck1.display());
            Console.WriteLine(duck1.performFly());
 
            Console.ReadLine();

        }
    }
}