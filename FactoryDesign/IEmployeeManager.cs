using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    // This interface use in a class that return our specific static values
    public interface IEmployeeManager
    {
        int GetBonus();
        int GetHourlyPay();
    }
}
