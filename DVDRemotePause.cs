using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class DVDRemotePause : RemoteButton
    {
        public DVDRemotePause(DVDDevice newDevice) 
            : base(newDevice) { }

        public override void buttonNinePressed()
        {
            Console.WriteLine("DVD was paused.");
        }
    }
}
