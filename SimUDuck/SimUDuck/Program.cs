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
            Duck duck1 = new RedHeadDuck();
            Duck duck2 = new MallardDuck();

            Duck[] mas = new Duck[] { duck1, duck2 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].Swim());
                Console.WriteLine(mas[i].Display());
                Console.WriteLine(mas[i].Quack());
            }

            Console.ReadKey();
        }
    }
}