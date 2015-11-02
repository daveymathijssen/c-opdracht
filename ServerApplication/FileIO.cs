using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NetworkLibrary;
using System.Collections.Generic;

namespace ServerApplication
{
    class FileIO
    {
        /// <summary>
        /// Save all users to a local file</summary>
        /// <param name="users">The userlist that will be saved in the local file</param>
        public static void SaveUsers(List<User> users)
        {
            Console.WriteLine("{0} users to be saved", users.Count);
            FileStream streamClient = new FileStream(@"C:\SealFlexBeheerSysteem\users.data", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Writing user information");
            foreach (User user in users)
            {
                bformatter.Serialize(streamClient, user);
            }
            streamClient.Close();
            Console.WriteLine("All user data saved");
        }

        /// <summary>
        /// Load all users from a local file</summary>
        public static List<User> LoadUsers()
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            List<User> users = new List<User>();
            //Open the file and read values from client.
            FileStream streamClient = new FileStream(@"C:\SealFlexBeheerSysteem\users.data", FileMode.Open);
            bformatter = new BinaryFormatter();

            Console.WriteLine("Reading user Information");

            while (streamClient.Position < streamClient.Length)
                try
                {
                    User user = (User)bformatter.Deserialize(streamClient);
                    Console.WriteLine(user.username);
                    if (user is User)
                        users.Add(user);
                    else
                        Console.WriteLine("error loading client" + user.username);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            Console.WriteLine("{0} users loaded", users.Count);
            streamClient.Close();
            return users;
        }

        /// <summary>
        /// Save all werkbonnen to a local file</summary>
        /// <param name="werkbonnen">The werkbonnenlist that will be saved in the local file</param>
        public static void SaveWerkbonnen(List<Werkbon> werkbonnen)
        {
            Console.WriteLine("{0} werkbonnen to be saved", werkbonnen.Count);
            FileStream streamClient = new FileStream(@"C:\SealFlexBeheerSysteem\werkbonnen.data", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Writing werkbon information");
            foreach (Werkbon werkbon in werkbonnen)
            {
                bformatter.Serialize(streamClient, werkbon);
            }
            streamClient.Close();
            Console.WriteLine("All werkbon data saved");
        }

        /// <summary>
        /// Load all werkbonnen from a local file</summary>
        public static List<Werkbon> LoadWerkbonnen()
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            List<Werkbon> werkbonnen = new List<Werkbon>();
            //Open the file and read values from client.
            FileStream streamClient = new FileStream(@"C:\SealFlexBeheerSysteem\werkbonnen.data", FileMode.Open);
            bformatter = new BinaryFormatter();

            Console.WriteLine("Reading werkbon Information");

            while (streamClient.Position < streamClient.Length)
                try
                {
                    Werkbon werkbon = (Werkbon)bformatter.Deserialize(streamClient);
                    Console.WriteLine(werkbon.werkbon);
                    if (werkbon is Werkbon)
                        werkbonnen.Add(werkbon);
                    else
                        Console.WriteLine("error loading werkbon" + werkbon.werkbon);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            Console.WriteLine("{0} werkbonnen loaded", werkbonnen.Count);
            streamClient.Close();
            return werkbonnen;
        }
    }
}
