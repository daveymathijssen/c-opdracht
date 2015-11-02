using NetworkLibrary;
using NetworkLibrary.Packets;
using System;
using System.Threading;

namespace ClientApplication
{
    public class Network : ClientInterface
    {
        private NetworkConnect network;
        private String ipAdress;
        private int port;
        private bool loginOk;
        private User.AccessRights accessRights;
        public String status { get; set; }
        

        public Network(string ipAdress, int port)
        {
            this.ipAdress = ipAdress;
            this.port = port;
            this.status = "Trying to establish server connection";
            network = new NetworkConnect(this);
            Thread connectionThread = new Thread(new ThreadStart(TryConnecting));
            connectionThread.IsBackground = true;
            connectionThread.Start();
        }

        public void TryConnecting()
        {
            while (!network.ConnectToServer(ipAdress,port))
            {
                status = "Can't connect to: " + ipAdress + ":" + port;
                Thread.Sleep(5000);
            }
            status = "Connected";
        }

        public Tuple<bool, User.AccessRights> login(string username, string password)
        {
            network.sendPacket(new PacketLogin(username, password));
            Thread.Sleep(1000);
            return new Tuple<bool, User.AccessRights>(loginOk, accessRights); ;
        }

        public void LoginResponse(bool loginOk, User.AccessRights accessRights)
        {
            this.loginOk = loginOk;
            this.accessRights = accessRights;
        }
    }
}
