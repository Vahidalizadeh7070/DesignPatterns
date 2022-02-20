using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Factories.Employees
{
    // This class inherits from IEmployeeManager because of GetBonus() and GetHourlyPayment() that implemented in IEmployeeManager interface
    // Also we added a new method that return GetMedicalAllowance that return a value and use it in PermanentEmployeeFactory
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public double GetBonus()
        {
            return 18;
        }
        public double GetHourlyPayment()
        {
            return 20;
        }
        public double GetMedicalAllowance()
        {
            return 150;
        }
    }
}
