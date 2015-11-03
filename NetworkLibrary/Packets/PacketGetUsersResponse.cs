using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Packets
{
    [Serializable]
    public class PacketGetUsersResponse : Packet
    {
        private List<User> users;

        public PacketGetUsersResponse(List<User> users)
        {
            this.users = users;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.GetUsersResponse(users);
        }
    }
}
