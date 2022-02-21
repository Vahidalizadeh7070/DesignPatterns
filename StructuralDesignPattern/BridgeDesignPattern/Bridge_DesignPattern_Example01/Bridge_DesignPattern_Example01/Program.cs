using Bridge_DesignPattern_Example01.ConcreteClasses;
using System;

namespace Bridge_DesignPattern_Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use new concrete classes and pass the Main concrete class
            // Main concrete class : SonyLED
            // New concrete class : SonyConcreteRemoteControl
            SonyConcreteRemoteControl sonyRemoteControl = new SonyConcreteRemoteControl(new SonyLED());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(101);
            sonyRemoteControl.SwitchOff();

            Console.WriteLine();

            // Main concrete class : SamsungLED
            // New concrete class : SamsungConcreteRemoteControl
            SamsungConcreteRemoteControl samsungRemoteControl = new SamsungConcreteRemoteControl(new SamsungLED());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.SwitchOff();

            Console.ReadKey();
        }
    }
}
