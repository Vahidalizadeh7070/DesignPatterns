using Bridge_DesignPattern_Example01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignPattern_Example01.ConcreteClasses
{
    // SonyLED concrete class
    // This class inherits from ILED interface 
    public class SonyLED : ILED
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Sony TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Sony TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
        }
    }
}
