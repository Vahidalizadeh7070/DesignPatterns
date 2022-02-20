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
        void AddMemory(string memory);

        // Add a drive
        void AddDrive(string size);

        // Add a keyboard
        void AddKeyBoard(string type);

        // Add a mouse
        void AddMouse(string type);

        // add a touch sreen 
        void AddTouchScreen(string enabled);
        
        // Get the system that we have created by above methods
        ComputerSystem GetSystem();
    }
}
