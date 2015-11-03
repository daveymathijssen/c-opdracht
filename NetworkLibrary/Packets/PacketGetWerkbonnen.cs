using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Packets
{
    [Serializable]
    public class PacketGetWerkbonnen : Packet
    {

        public PacketGetWerkbonnen()
        {

        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.GetWerkbonnen();
        }
    }
}