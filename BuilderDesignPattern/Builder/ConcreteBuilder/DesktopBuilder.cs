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
        public void AddDrive(string size)
        {
            desktop.HDDSize = size;
        }
        public void AddKeyBoard(string type)
        {
            desktop.KeyBoard = type;
        }
        public void AddMemory(string memory)
        {
            desktop.RAM = memory;
        }
        public void AddMouse(string type)
        {
            desktop.Mouse = type;
        }

        // Desktop version has not any touch screen and it will return nothing
        public void AddTouchScreen(string enabled)
        {
            return;
        }

        // It will return a desktop as a ComputerSytem type
        public ComputerSystem GetSystem()
        {
            return desktop;
        }
    }
}
