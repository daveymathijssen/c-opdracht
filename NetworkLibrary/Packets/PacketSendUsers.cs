using System;
using System.Collections.Generic;

namespace NetworkLibrary.Packets
{
    [Serializable]
    public class PacketSendUsers : Packet
    {
        public List<User> users { get; }

        public PacketSendUsers(List<User> users)
        {
            this.users = users;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.NewUsers(users);
        }
    }
}
