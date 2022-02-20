using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BuilderDesignPattern.Factories.Enumeration.Enumerations;

namespace BuilderDesignPattern.Factories.AbstractFactory.Interfaces.ConcreteProduct
{
    // These concrete classes inherit from ISystemType interface
    
    // It returns Laptop as enumeration
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }
    // It returns Desktop as enumeration
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}
