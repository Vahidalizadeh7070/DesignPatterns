using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_Example.Factories.Enumeration
{
    public class Enumerations
    {
        public enum Brand
        {
            Apple,
            Dell
        }
        public enum ComputerTypes
        {
            Laptop,
            Desktop
        }
        public enum Processors
        {
            Core_i3,
            Core_i5,
            Core_i7
        }
    }
}
