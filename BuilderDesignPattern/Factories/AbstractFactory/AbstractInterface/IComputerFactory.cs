using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Factories.AbstractFactory.Interfaces.AbstractInterface
{
    // This interface is an abstract interface that includes our 3 interfaces 
    // This interface will be used in ConcreteFactory classes
    public interface IComputerFactory
    {
        IBrand Brand();
        IProcessor Processor();
        ISystemType SystemType();
    }
}
