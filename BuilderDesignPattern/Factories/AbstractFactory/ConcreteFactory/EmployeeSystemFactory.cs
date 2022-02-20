using BuilderDesignPattern.Factories.AbstractFactory.Interfaces.AbstractInterface;
using BuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Factories.AbstractFactory.ConcreteFactory
{
    // This is our factory.
    // This class decide to which object from DellFactory(DellFactory,DellLaptopFactory)(MacFactory,MacLaptopFactor)
    // create based on TypeId and JobDescription

    // The datatype of the method that exists in it is IComputerFactor which it returns all interfaces (IBrand,IProcessor,ISystemType) 
    // We use this Factory in our controller and Create action

    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employees)
        {
            IComputerFactory returnValue = null;
            if(employees.TypeId==1)
            {
                if(employees.JobDescription=="Manager")
                {
                    returnValue = new MacLaptopFactory();
                }
                else
                {
                    returnValue = new MacFactory();
                }
            }
            else
            {
                if(employees.JobDescription=="Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                {
                    returnValue = new DellFactory();
                }
            }
            return returnValue;
        }
    }
}
