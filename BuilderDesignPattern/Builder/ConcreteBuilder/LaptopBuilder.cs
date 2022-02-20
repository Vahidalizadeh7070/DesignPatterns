using BuilderDesignPattern.Builder.IBuilder;
using BuilderDesignPattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builder.ConcreteBuilder
{
    // This class inherits from ISystemBuilder to use those methods to create a Laptop computer
    // We should create an object from ComputerSystem to have an access to those properties and use those to add a system
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();
        public ISystemBuilder AddDrive(string size)
        {
            laptop.HDDSize = size;
            return this;
        }

        // Laptop has not any keyboard
        public ISystemBuilder AddKeyBoard(string type)
        {
            return this;
        }

        public ISystemBuilder AddMemory(string memory)
        {
            laptop.RAM = memory;
            return this;
        }

        // Laptop has not any mouse
        public ISystemBuilder AddMouse(string type)
        {
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enabled)
        {
            laptop.TouchScreen = enabled;
            return this;
        }

        // It will return a laptop as a ComputerSytem type
        public ComputerSystem GetSystem()
        {
            return laptop;
        }
    }
}
