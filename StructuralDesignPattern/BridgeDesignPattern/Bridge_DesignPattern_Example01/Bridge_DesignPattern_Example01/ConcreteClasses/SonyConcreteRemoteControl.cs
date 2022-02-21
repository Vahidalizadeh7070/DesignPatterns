using Bridge_DesignPattern_Example01.Abstract;
using Bridge_DesignPattern_Example01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignPattern_Example01.ConcreteClasses
{
    // This is a new concrete class which inherits from AbstractRemoteControl
    // This class have a constructor and 3 override methods which are related with abstract methods in AbstractRemoteControl
    // We override those method until the main interface (ILED) does not
    // change at all and use these abstract class (AbstractRemoteControl) for all new concrete class
    public class SonyConcreteRemoteControl : AbstractRemoteControl
    {
        public SonyConcreteRemoteControl(ILED iled) : base(iled)
        {
        }

        public override void SwitchOn()
        {
            _iLed.SwitchOn();
        }

        public override void SwitchOff()
        {
            _iLed.SwitchOff();
        }

        public override void SetChannel(int channelNumber)
        {
            _iLed.SetChannel(channelNumber);
        }
    }
}
