using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Packets
{
    [Serializable]
    public class PacketGetWerkbonnenResponse : Packet
    {
        private List<Werkbon> werkbonnen;

        public PacketGetWerkbonnenResponse(List<Werkbon> werkbonnen)
        {
            this.werkbonnen = werkbonnen;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.GetWerkbonnenResponse(werkbonnen);
        }
    }
}
