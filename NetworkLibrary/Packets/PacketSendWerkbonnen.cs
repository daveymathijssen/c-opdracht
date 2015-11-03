using System;
using System.Collections.Generic;

namespace NetworkLibrary.Packets
{
    [Serializable]
    public class PacketSendWerkbonnen : Packet
    {
        public List<Werkbon> werkbonnen;

        public PacketSendWerkbonnen(List<Werkbon> werkbonnen)
        {
            this.werkbonnen = werkbonnen;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.NewWerkbonnen(werkbonnen);
        }
    }
}
