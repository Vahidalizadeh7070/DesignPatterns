using FactoryDesignPattern_Example.Factories.AbstractFactory.Interfaces;
using FactoryDesignPattern_Example.Factories.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_Example.Factories.AbstractFactory.ConcreteProduct
{
    // These concrete classes inherit from IProcessor interface
    
    // It returns I7 processor as an enumeration
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.Core_i7.ToString();
        }
    }

    // It returns I5 processor as an enumeration
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.Core_i5.ToString();
        }
    }

    // It returns I3 processor as an enumeration
    public class I3 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.Core_i3.ToString();
        }
    }
}
