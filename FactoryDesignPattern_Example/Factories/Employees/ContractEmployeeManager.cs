using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_Example.Factories.Employees
{
    // This class inherits from IEmployeeManager because of GetBonus() and GetHourlyPayment() that implemented in IEmployeeManager interface
    // Also we added a new method that return GetHouseAllowance that return a value and use it in ContractEmployeeFactory
    public class ContractEmployeeManager : IEmployeeManager
    {
        public double GetBonus()
        {
            return 15;
        }

        public double GetHourlyPayment()
        {
            return 12;
        }

        public double GetHouseAllowance()
        {
            return 100;
        }
    }
}
