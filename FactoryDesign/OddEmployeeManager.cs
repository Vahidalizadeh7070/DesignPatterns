using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public class OddEmployeeManager : IEmployeeManager
    {
        public int GetBonus()
        {
            return 12;
        }

        public int GetHourlyPay()
        {
            return 10;
        }
    }
}
