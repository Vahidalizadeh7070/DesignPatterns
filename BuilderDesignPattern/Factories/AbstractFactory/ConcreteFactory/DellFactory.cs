using BuilderDesignPattern.Factories.AbstractFactory.ConcreteProduct;
using BuilderDesignPattern.Factories.AbstractFactory.Interfaces;
using BuilderDesignPattern.Factories.AbstractFactory.Interfaces.AbstractInterface;
using BuilderDesignPattern.Factories.AbstractFactory.Interfaces.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Factories.AbstractFactory.ConcreteFactory
{
    // These concrete factory classes inherit from IComputerFactory which returns all interfaces (IBrand,IProcessor,ISystemType) 
    public class DellFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Dell();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    // This class inherits from DellFactory class
    // We use virtual keyword in above class to override in DellLaptopFactor
    // because just 3rd method is difference and rest of them is the same 
    public class DellLaptopFactory : DellFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
