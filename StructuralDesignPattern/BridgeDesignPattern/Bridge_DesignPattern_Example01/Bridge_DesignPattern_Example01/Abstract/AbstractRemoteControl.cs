using Bridge_DesignPattern_Example01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignPattern_Example01.Abstract
{
    // This is abstract class which inject ILED and then we can have an access to the _iLed property
    // We also have 3 abstract method to override in the another concrete classes
    public abstract class AbstractRemoteControl
    {
        protected ILED _iLed;
        protected AbstractRemoteControl(ILED iLed)
        {
            _iLed = iLed;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
