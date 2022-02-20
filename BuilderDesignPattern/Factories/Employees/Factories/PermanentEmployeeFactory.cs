using BuilderDesignPattern.Factories.Employees.BaseFactory;
using BuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Factories.Employees.Factories
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
            _employee.MedicalAllowance= manager.GetMedicalAllowance();
            _employee.HouseAllowance = 0;
            return manager;
        }
    }
}
