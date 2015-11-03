using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NetworkLibrary
{
    [Serializable]
    public class PacketAddUser : Packet
    {
        public User user { get; }

        public PacketAddUser(User user)
        {
            this.user = user;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.AddUser(user);
        }
    }
}