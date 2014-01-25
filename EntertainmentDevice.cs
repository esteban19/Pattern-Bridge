using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class EntertainmentDevice
    {
        public int deviceState;
        public int maxSetting;
        public int volumeLevel = 0;
        public abstract void buttonFivePressed();
        public abstract void buttonSixPressed();

        public virtual void deviceFeedback()//common to all
        {
            if (deviceState > maxSetting || deviceState < 0)
            {
                deviceState = 0;
            }
            Console.WriteLine("Device State. On: " + deviceState);
        }

        public void buttonSevenPressed()//common to all devices
        {
            volumeLevel++;
            Console.WriteLine("Volume at: " + volumeLevel);
        }

        public void buttonEightLevel()//common to all devices
        {
            volumeLevel--;
            Console.WriteLine("Volume at: " + volumeLevel);
        }



    }
}
