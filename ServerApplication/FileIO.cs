using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NetworkLibrary;
using System.Collections.Generic;

namespace ServerApplication
{
    class FileIO
    {
        public static void SaveUsers(List<User> users)
        {
            Console.WriteLine("{0} users to be saved", users.Count);
            FileStream streamClient = new FileStream(@"C:\SealFlexBeheerSysteem\users.data", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Writing user information");
            foreach (User u in users)
            {
                bformatter.Serialize(streamClient, u);
            }
            streamClient.Close();
            Console.WriteLine("All user data saved");
        }

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
    }
}
