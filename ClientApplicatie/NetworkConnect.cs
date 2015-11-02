using NetworkLibrary;
using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ClientApplication
{
    public class NetworkConnect
    {
        private X509Certificate2Collection certs = new X509Certificate2Collection();
        private SslStream ssl;
        private Network parent;

        public NetworkConnect(Network parent)
        {
            this.parent = parent;
            certs.Add(new X509Certificate2(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\NetworkLibrary\Cert\cyclemaster.pfx", "admin", X509KeyStorageFlags.MachineKeySet));
        }

        /// <summary>
        /// Try to connect to server and return true or false.</summary>
        /// <param name="ipAdress">The ip adress of the server</param>
        /// <param name="port">The serverapplication's port</param>
        public bool ConnectToServer(string ipAdress, int port)
        {
            try
            {
                TcpClient server = new TcpClient(ipAdress, port);
                ssl = new SslStream(server.GetStream(), true, new RemoteCertificateValidationCallback(ValidateCertificate));
                ssl.AuthenticateAsClient("cyclemaster", certs, SslProtocols.Tls12, true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error connecting to server: {0}", e);
                return false; //failed to connect.
            }
            Thread receiveThread = new Thread(new ThreadStart(ReceiveThread));
            receiveThread.IsBackground = true;
            receiveThread.Start();
            return true; //succesfully connected to server.
        }

        /// <summary>
        /// Send a packet to the server.</summary>
        /// <param name="packet">The packet that will be send</param>
        public void sendPacket(Packet packet)
        {
            NetworkCommunication.SendPacket(packet, ssl);
        }

        /// <summary>
        /// Receive thread.</summary>
        private void ReceiveThread()
        {
            while (true)
            {
                Packet packet = NetworkCommunication.ReadPacket(ssl);
                if (packet != null)
                    packet.handleClientSide(parent);
            }
        }

        /// <summary>
        /// Validate the SSL certificate.</summary>
        private bool ValidateCertificate(object sender, X509Certificate certificate, X509Chain certChain, SslPolicyErrors errors)
        {
            if (errors == SslPolicyErrors.None)
                return true;
            return false;
        }
    }
}
