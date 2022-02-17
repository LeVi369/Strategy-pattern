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
            foreach (Duck i in masDuck)
            {
                Console.WriteLine($"{i.swim()}");
                Console.WriteLine($"{i.display()}");
                if (i is Quackable)
                {
                    Console.WriteLine((i as Quackable).quack());
                }
                if (i is Flyable)
                {
                    Console.WriteLine((i as Flyable).fly());
                }
            }
            Console.ReadLine();

        }
    }
}