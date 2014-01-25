using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class RemoteButton
    {
        private EntertainmentDevice theDevice;//need instance of the object Remote will interact with

        public RemoteButton(EntertainmentDevice newDevice)
        { 
            this.theDevice = newDevice;
        }

        public void buttonFivePressed()
        {  //calling the method of the Device itself, implemented in concrete implementor(TVDevice/DVDDevice)
            theDevice.buttonFivePressed();
        }

        public void buttonSixPressed()
        {
            theDevice.buttonSixPressed();
        }

        //Device feedback outputs channel or chapter #(common to all devices)
        public void deviceFeedback()
        {
            theDevice.deviceFeedback();
        }

        public abstract void buttonNinePressed();
    }
}
