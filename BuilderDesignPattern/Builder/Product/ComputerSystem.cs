using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builder.Product
{
    // This class includes 5 properties
    // These properties will be used in produce a string as a SystemConfigurationDetails
    public class ComputerSystem
    {
        public string RAM { get; set; }
        public string HDDSize { get; set; }
        public string KeyBoard { get; set; }
        public string Mouse { get; set; }
        public string TouchScreen { get; set; }
        
        // Constructor
        public ComputerSystem()
        {
        }
    }
}
