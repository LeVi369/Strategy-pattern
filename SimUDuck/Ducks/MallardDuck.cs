using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public override string Display()
        {
            return "Display" + " " + this.GetType();
        }
    }
}
