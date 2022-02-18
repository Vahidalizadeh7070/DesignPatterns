using FactoryDesignPattern_Example.Factories.AbstractFactory.Interfaces;
using FactoryDesignPattern_Example.Factories.AbstractFactory.Interfaces.AbstractInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_Example.Factories.AbstractFactory.Client
{
    // This class will be used in EmployeeController and Create action
    // This class includes a constructor which get a IComputerFactory as a parameter and inject it
    // Also it has a method which return a string type
    // This string made by IComputerFactory which return Brand,Processor,SystemType based on employee TypeId and JobDescription
    // Then we use this string in our EmployeeController and Create action
    public class EmployeeSystemManager
    {
        public IComputerFactory ComputerFactory { get; }
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            ComputerFactory = computerFactory;
        }
        public string GetSystemDetails()
        {
            IBrand brand = ComputerFactory.Brand();
            IProcessor processor = ComputerFactory.Processor();
            ISystemType systemType = ComputerFactory.SystemType();

            string returnValue = string.Format("{0}_{1}_{2}",brand.GetBrand(),processor.GetProcessor(),systemType.GetSystemType());
            return returnValue;
        }

        
    }
}
