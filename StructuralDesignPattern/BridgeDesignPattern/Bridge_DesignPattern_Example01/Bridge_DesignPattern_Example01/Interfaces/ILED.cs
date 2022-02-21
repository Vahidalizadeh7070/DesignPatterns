using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignPattern_Example01.Interfaces
{
    // This is concrete interface
    // This interface is going to use in the concrete classes
    public interface ILED
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }
}
