using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_Example.Factories.Employees
{
    public interface IEmployeeManager
    {
        double GetBonus();
        double GetHourlyPayment();
    }
}
