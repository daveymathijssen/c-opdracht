using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Packets
{
    [Serializable]
    public class PacketGetUsers : Packet
    {

        public PacketGetUsers()
        {

        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.GetUsers();
        }
    }
}
