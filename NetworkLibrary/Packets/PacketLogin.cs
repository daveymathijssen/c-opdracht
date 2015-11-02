using System;

namespace NetworkLibrary.Packets
{
    [Serializable]
    public class PacketLogin : Packet
    {
        private String username;
        private String password;

        public PacketLogin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.Login(username, password);
        }
    }
}
