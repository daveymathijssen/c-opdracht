using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary
{
    [Serializable]
    public class PacketLoginResponse : Packet
    {
        public bool loginOk { get; }
        public User.AccessRights accessRights { get; }

        public PacketLoginResponse(bool loginOk, User.AccessRights accessRights)
        {
            this.loginOk = loginOk;
            this.accessRights = accessRights; 
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.LoginResponse(loginOk, accessRights);
        }
    }
}
