using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    namespace SimUDuck
    {
        public class RubberDuck : Duck, Quackable
        {
            public override string display()
            {
                return "Я- резина! " + this.GetType();
            }
            public string quack()
            {
                return "Пиии пи " + this.GetType();
            }
        }
    }
}
