using BuilderDesignPattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builder.IBuilder
{
    // This is an interface that includes 5 methods that add each of variables  
    public interface ISystemBuilder
    {
        // Add a memory
        ISystemBuilder AddMemory(string memory);

        // Add a drive
        ISystemBuilder AddDrive(string size);

        // Add a keyboard
        ISystemBuilder AddKeyBoard(string type);

        // Add a mouse
        ISystemBuilder AddMouse(string type);

        // add a touch sreen 
        ISystemBuilder AddTouchScreen(string enabled);
        
        // Get the system that we have created by above methods
        ComputerSystem GetSystem();
    }
}
