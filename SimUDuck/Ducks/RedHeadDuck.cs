using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class RedHeadDuck : Duck, Flyable,Quackable
    {
        public override string display()
        {
            return "У меня красная голова!" + " " + this.GetType();
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
