using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class TVDevice : EntertainmentDevice
    {
        public TVDevice(int newDeviceState, int newMaxSetting)
        {
            this.deviceState = newDeviceState;
            this.maxSetting = newMaxSetting;
        }

        public override void deviceFeedback()
        {
            if (deviceState > maxSetting || deviceState < 0)
            {
                deviceState = 0;
            }
            Console.WriteLine("Channel currently at: " + deviceState);
        }

        public override void buttonFivePressed()//common to tv devices
        {
            Console.WriteLine("Channel Down");
            deviceState--;
        }

        public override void buttonSixPressed()//common to tv devices
        {
            Console.WriteLine("Channel Up");
            deviceState++;
        }
    }
}
