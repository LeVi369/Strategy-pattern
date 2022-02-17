using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class MallardDuck : Duck, Flyable,Quackable
    {
        public override string display()
        {
            return "Я-кряква!" + " " + this.GetType();
        }
        public string fly()
        {
            return "Маах мах" + GetType();
        }
        public string quack()
        {
            return "Крряяя кря" + GetType();
        }
    }
}
