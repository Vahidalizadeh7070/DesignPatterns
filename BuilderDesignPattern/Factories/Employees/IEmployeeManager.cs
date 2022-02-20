using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Factories.Employees
{
    public interface IEmployeeManager
    {
        double GetBonus();
        double GetHourlyPayment();
    }
}
