using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_Example.Factories.AbstractFactory.Interfaces
{
    // This interface is going to use in ComputerSystemType.cs In ConcreteProduct
    public interface ISystemType
    {
        string GetSystemType();
    }
}
