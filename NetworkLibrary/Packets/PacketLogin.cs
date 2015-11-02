using System;

namespace NetworkLibrary.Packets
{
    [Serializable]
    public class PacketLogin : Packet
    {
        private String username;
        private String password;
        private bool loginOk;
        private User.AccessRights accessRights;

        public PacketLogin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public PacketLogin(bool loginOk, User.AccessRights accessRights)
        {
            this.loginOk = loginOk;
            this.accessRights = accessRights;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.LoginResponse(loginOk, accessRights);
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.Login(username, password);
        }
    }
}
