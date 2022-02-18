using FactoryDesignPattern_Example.Factories.AbstractFactory.Interfaces;
using FactoryDesignPattern_Example.Factories.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_Example.Factories.AbstractFactory.ConcreteProduct
{
    // This concrete class inherits from IBrand interface
    // It returns Apple brand as an enumeration
    public class Mac : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brand.Apple.ToString();
        }
    }
}
