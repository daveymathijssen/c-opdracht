using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Threading;
using NetworkLibrary;
using NetworkLibrary.Packets;
using System.Collections.Generic;

namespace ServerApplication
{
    class ServerClient : ServerInterface
    {
        private ServerApplication server;
        private SslStream stream;
        public User user { get; set; }

        public ServerClient(TcpClient client, ServerApplication server, SslStream stream)
        {
            this.server = server;
            this.stream = stream;
            if (client != null)
            {
                new Thread(() =>
                {
                    while (client.Connected)
                    {
                        Packet packet = NetworkCommunication.ReadPacket(stream);
                        if (packet != null)
                        {
                            Console.WriteLine("recieved packet");
                            packet.handleServerSide(this);
                        }
                    }
                    //When disconnected:
                    server.ConnectedClients.Remove(this);
                    Console.WriteLine("Client disconnected");
                }).Start();
            }
        }

        /// <summary>
        /// Check if username and password are correct and send a response.</summary>
        /// <param name="username">The username of the user</param>
        /// <param name="password">The password of the user</param>
        public void Login(string username, string password)
        {
            Console.WriteLine("Iemand probeert in te loggen als " + username + ", wachtwoord: " + password);
            //Actual login checking:
            foreach (User user in server.users)
            {
                if (user.username.ToLower().Equals(username.ToLower()))
                {
                    if (PasswordHash.ValidatePassword(password, user.password))
                    {
                        NetworkCommunication.SendPacket(new PacketLoginResponse(true, user.accessRights), stream);
                        Console.WriteLine("{0} succesfully logged in.", username);
                        this.user = user;
                        break;
                    }
                    else //wrong password
                    {
                        Console.WriteLine("wrong password");
                        NetworkCommunication.SendPacket(new PacketLoginResponse(false, user.accessRights), stream);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Check if the user exist, if not add the user to the users file.</summary>
        /// <param name="newUser">The new user to be added</param>
        public void AddUser(User newUser)
        {
            Boolean addUser = true;

            //Last check to prevent creating an user that already excists
            foreach (User user in server.users)
            {
                if (user.username.ToLower().Equals(newUser.username.ToLower()))
                {
                    addUser = false;
                    break;
                }
            }

            //if no duplicate has been found, newUser can be added to the userlist
            if (addUser)
                server.AddNewUser(newUser);
            Console.WriteLine("Succesfully created new user {0} with password {1}.", newUser.username, newUser.password);
        }

        /// <summary>
        /// Check if the werkbon exist, if not add the werkbon to the werkbon file, otherwise update werkbon.</summary>
        /// <param name="werkbon">The werkbon to be added/updated</param>
        public void SaveWerkbon(Werkbon werkbon)
        {
            int werkbonID = -1;
            bool newWerkbon = true;

            //Check if werkbon already exists, if so, update werkbon with existing ID
            foreach (Werkbon oldWerkbon in server.werkbonnen)
            {
                werkbonID++;
                if (werkbon.werkbon == oldWerkbon.werkbon)
                {
                    newWerkbon = false;
                    break;
                }
            }
            if (newWerkbon)
            {
                server.AddNewWerkbon(werkbon);
                //NetworkCommunication.SendPacket(new PacketSaveWerkbonResponse(true, user.accessRights), stream);
            }
            else
            {
                server.UpdateWerkbon(werkbon, werkbonID);
                //NetworkCommunication.SendPacket(new PacketSaveWerkbonResponse(true, user.accessRights), stream);
            }
        }

        public void GetUsers()
        {
            Console.WriteLine("Someone is requesting all users");
            NetworkCommunication.SendPacket(new PacketGetUsersResponse(server.users), stream);
        }

        public void GetWerkbonnen()
        {
            Console.WriteLine("Someone is requesting all werkbonnen " + server.werkbonnen.Count);
            NetworkCommunication.SendPacket(new PacketGetWerkbonnenResponse(server.werkbonnen), stream);
        }


    }
}
