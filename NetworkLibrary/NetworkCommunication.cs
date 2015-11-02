using System;
using System.Net.Security;
using System.Runtime.Serialization.Formatters.Binary;

namespace NetworkLibrary
{
    public class NetworkCommunication
    {
        /// <summary>
        /// Send a packet.</summary>
        /// <param name="packet">The packet that will be send</param>
        /// <param name="ssl">The ssl stream</param>
        public static bool SendPacket(Packet packet, SslStream ssl)
        {
            BinaryFormatter binairyFormatter = new BinaryFormatter();
            try
            {
                binairyFormatter.Serialize(ssl, packet);
                ssl.Flush();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Receive and read a packet.</summary>
        /// <param name="ssl">The ssl stream</param>
        public static Packet ReadPacket(SslStream ssl)
        {
            BinaryFormatter binairyFormatter = new BinaryFormatter();
            Packet packet;
            try
            {
                packet = (Packet)binairyFormatter.Deserialize(ssl);
                ssl.Flush();
            }
            catch (Exception)
            {
                return null;
            }
            return packet;
        }
    }
}
