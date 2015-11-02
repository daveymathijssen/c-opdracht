using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Packets
{
    [Serializable]
    public class PacketSaveWerkbon : Packet
    {
        private Werkbon werkbon;

        public PacketSaveWerkbon(Werkbon werkbon)
        {
            this.werkbon = werkbon;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.SaveWerkbonResponse();
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.SaveWerkbon(werkbon);
        }
    }
}
