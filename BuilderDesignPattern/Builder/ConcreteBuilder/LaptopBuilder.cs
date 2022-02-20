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
        public void AddDrive(string size)
        {
            laptop.HDDSize = size;
        }

        // Laptop has not any keyboard
        public void AddKeyBoard(string type)
        {
            return;
        }

        public void AddMemory(string memory)
        {
            laptop.RAM = memory;
        }

        // Laptop has not any mouse
        public void AddMouse(string type)
        {
            return;
        }

        public void AddTouchScreen(string enabled)
        {
            laptop.TouchScreen = enabled;
        }

        // It will return a laptop as a ComputerSytem type
        public ComputerSystem GetSystem()
        {
            return laptop;
        }
    }
}
