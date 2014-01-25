using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class TVRemoteMute : RemoteButton
    {
        public TVRemoteMute(TVDevice newDevice)
            : base(newDevice) { }

        public override void buttonNinePressed()
        {
            Console.WriteLine("TV was Muted");
        }
    }
}
