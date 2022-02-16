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
            return manager;
        }
    }
}
