using BuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Factories.Employees.BaseFactory
{
    // In this class we have an abstract creator 
    // Also we have an ApplySalary method  to calculate Bonus and HourlyPay

    public abstract class BaseEmployeeFactory
    {
        protected Employee _employee;
        public BaseEmployeeFactory(Employee employee)
        {
            _employee = employee;
        }
        // This mehtod calculate GetHourlyPayment and Bonus and set it to employee object
        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _employee.HourlyPay = manager.GetHourlyPayment();
            _employee.Bonus = manager.GetBonus();
            return _employee;
        }
        public abstract IEmployeeManager Create();
    }
}
