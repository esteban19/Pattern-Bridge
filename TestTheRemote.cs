using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class TestTheRemote
    {
        public static void Main(string[] args)
        {
            RemoteButton theTV = new TVRemoteMute(new TVDevice(1,200));
            RemoteButton theTV2 = new TVRemotePause(new TVDevice(1,200));
            RemoteButton theDVD = new DVDRemotePause(new DVDDevice(1));

            //RemoteButton theDVD = new DVDRemote(new DVDDevice(1,14);

            Console.WriteLine("Test TV with Mute");
            theTV.buttonFivePressed();
            theTV.buttonSixPressed();
            theTV.buttonNinePressed();

            Console.WriteLine("Test TV2 with Pause");
            theTV2.buttonFivePressed();
            theTV2.buttonSixPressed();
            theTV2.buttonSixPressed();
            theTV2.buttonSixPressed();
            theTV2.buttonSixPressed();
            theTV2.buttonNinePressed();
            theTV2.deviceFeedback();

            Console.WriteLine("Test DVD with Pause");
            theDVD.buttonFivePressed();
            theDVD.buttonSixPressed();
            theDVD.buttonSixPressed();
            theDVD.buttonSixPressed();
            theDVD.buttonSixPressed();
            theDVD.buttonNinePressed();
            theDVD.deviceFeedback();

        }
    }
}
