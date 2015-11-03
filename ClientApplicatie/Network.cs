using NetworkLibrary;
using NetworkLibrary.Packets;
using System;
using System.Collections.Generic;
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
        private List<Werkbon> werkbonnen;
        private List<User> users;
        

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

        public bool SaveWerkbonResponse()
        {
            return true;
        }

        public bool SaveWerkbon(Werkbon werkbon)
        {
            network.sendPacket(new PacketSaveWerkbon(werkbon));
            Thread.Sleep(1000);
            return true;
        }

        public List<Werkbon> GetWerkbonnen()
        {
            network.sendPacket(new PacketGetWerkbonnen());
            Thread.Sleep(1000);
            return werkbonnen;
        }

        public void GetWerkbonnenResponse(List<Werkbon> werkbonnen)
        {
            this.werkbonnen = werkbonnen;
        }

        public List<User> GetUsers()
        {
            network.sendPacket(new PacketGetUsers());
            Thread.Sleep(1000);
            return users;
        }

        public void AddUser(User user)
        {
            network.sendPacket(new PacketAddUser(user));
        }

        public void GetUsersResponse(List<User> users)
        {
            this.users = users;
        }
    }
}
