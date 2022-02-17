using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class ReadHeadDuck : Duck, Quackable, Flyable
    {
        public override string display()
        {
            return "Красная голова" + this.GetType();
        }

        public string fly()
        {
            return "Мах мах" + this.GetType();
        }

        public string quack()
        {
            return "Кряяя кря " + this.GetType();
        }
    }
}
