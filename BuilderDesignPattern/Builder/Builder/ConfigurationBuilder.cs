using BuilderDesignPattern.Builder.IBuilder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builder.Builder
{
    // This class is the main builder that get all values from the IFormCollection
    // The IFormCollection is comming from the view and the form that user send it to the controller
    // It includes a BuildSystem method that has 2 arguments.
    // ISystemBuilder is used in creation each part of a system
    // IFormCollection gaing all values that come from the users
    public class ConfigurationBuilder
    {
        // When this method has been executed, ISystemBuilder add all values to our ConcreteBuilder classes(LaptopBuilder and DesktopBuilder)
        // which inherits from ISystemBuilder and then we can use GetSystem() method to demonstrate the system that has been created
        public void BuildSystem(ISystemBuilder systembuilder
            , IFormCollection collection)
        {
            systembuilder.AddDrive(collection["Drive"])
                .AddMemory(collection["RAM"])
                .AddMouse(collection["Mouse"])
                .AddKeyBoard(collection["Keyboard"])
                .AddTouchScreen(collection["TouchScreen"]);
        }
    }
}
