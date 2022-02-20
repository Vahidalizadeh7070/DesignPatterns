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
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee):base(employee)
        {
            
        }
        // We Create object of our ContractEmployeeManager and set HouseAllowance
        // The HouseAllowance is related with TypeId 1
        // We set HouseAllowance to _employee object
        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _employee.HouseAllowance = manager.GetHouseAllowance();
            _employee.MedicalAllowance = 0;
            return manager;
        }
    }
}
