using BuilderDesignPattern.Builder.IBuilder;
using BuilderDesignPattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builder.ConcreteBuilder
{
    // This class inherits from ISystemBuilder to use those methods to create a desktop computer
    // We should create an object from ComputerSystem to have an access to those properties and use those to add a system
    public class DesktopBuilder : ISystemBuilder
    {
        ComputerSystem desktop = new ComputerSystem();
        public ISystemBuilder AddDrive(string size)
        {
            desktop.HDDSize = size;
            return this;
        }
        public ISystemBuilder AddKeyBoard(string type)
        {
            desktop.KeyBoard = type;
            return this;
        }
        public ISystemBuilder AddMemory(string memory)
        {
            desktop.RAM = memory;
            return this;
        }
        public ISystemBuilder AddMouse(string type)
        {
            desktop.Mouse = type;
            return this;
        }

        // Desktop version has not any touch screen and it will return nothing
        public ISystemBuilder AddTouchScreen(string enabled)
        {
            return this;
        }

        // It will return a desktop as a ComputerSytem type
        public ComputerSystem GetSystem()
        {
            return desktop;
        }
    }
}
