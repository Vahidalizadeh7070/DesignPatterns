using FactoryDesignPattern_Example.Factories.Employees.BaseFactory;
using FactoryDesignPattern_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_Example.Factories.Employees.Factories
{
    // This class inherits from our BaseEmployeeFactory because of the creator
    // We should override Create() method that we have in our BaseEmployeeFactory 
    public class PermanentEmployeeFactory:BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee employee) : base(employee)
        {

        }
        // We Create object of our PermanentEmployeeFactory and set MedicalAllowance
        // The MedicalAllowance is related with TypeId 2
        // We set MedicalAllowance to _employee object
        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _employee.HouseAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
