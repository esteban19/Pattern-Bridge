using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class DVDDevice : EntertainmentDevice
    {
        
        public DVDDevice(int newDeviceState)
        {
            this.deviceState = newDeviceState;
        }

        public override void deviceFeedback()
        {
            if (deviceState > maxSetting || deviceState < 0)
            {
                deviceState = 0;
            }
            Console.WriteLine("Chapter currently at: " + deviceState);
        }

        public override void buttonFivePressed()
        {
            Console.WriteLine("Decrease Chapter");
            deviceState--;
        }

        public override void buttonSixPressed()
        {
            Console.WriteLine("Increase Chapter");
            deviceState++;
        }
    }
}
