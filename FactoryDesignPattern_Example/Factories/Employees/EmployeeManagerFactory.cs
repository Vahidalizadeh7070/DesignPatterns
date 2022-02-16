using FactoryDesignPattern_Example.Factories.Employees.BaseFactory;
using FactoryDesignPattern_Example.Factories.Employees.Factories;
using FactoryDesignPattern_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_Example.Factories.Employees
{
    // We create an object from this class in our EmployeeController and set it to BaseEmployeeFactory 
    // Then we pass employee object with specifc TypeId and then it knows which object should be created 
    // Also in EmployeeController we do not specify any objcet and all
    // of the instantiation create in here based on TypeId of Employee that we have passed
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory returnValue = null;
            if(employee.TypeId==1)
            {
                returnValue = new ContractEmployeeFactory(employee);
            }
            else if(employee.TypeId == 2)
            {
                returnValue = new PermanentEmployeeFactory(employee);
            }
            return returnValue;
        }
    }
}
