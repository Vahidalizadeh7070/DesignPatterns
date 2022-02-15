using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public class EvenEmployeeManager : IEmployeeManager
    {
        public int GetBonus()
        {
            return 17;
        }

        public int GetHourlyPay()
        {
            return 15;
        }
    }
}
