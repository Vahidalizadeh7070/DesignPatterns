using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPattern_Example01
{
    public class Pizza : IPizza
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
