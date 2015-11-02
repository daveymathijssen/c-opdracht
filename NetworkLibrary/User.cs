using System;
using System.Runtime.Serialization;

namespace NetworkLibrary
{
    [Serializable]
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public AccessRights accessRights { get; set; }

        /// <summary>
        /// Create a new user with given username, password and acces rights.</summary>
        /// <param name="username">The username for the user</param>
        /// <param name="password">The password for the user</param>
        /// <param name="accesRights">The acces rights for the user</param>
        public User(string username, string password, AccessRights accessRights)
        {
            this.username = username.ToLower();
            this.password = PasswordHash.HashPassword(password);
            this.accessRights = accessRights;
        }

        /// <summary>
        /// Load user data from serialization stream.</summary>
        public User(SerializationInfo info, StreamingContext ctxt)
        {
            username = (string)info.GetValue("username", typeof(string));
            password = (string)info.GetValue("password", typeof(string));
            accessRights = (AccessRights)info.GetValue("accessRights", typeof(AccessRights));
        }

        /// <summary>
        /// Serialize user data.</summary>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("username", username);
            info.AddValue("password", password);
            info.AddValue("accessRights", accessRights);
        }

        /// <summary>
        /// Print username of user to string.</summary>
        public override string ToString()
        {
            return username;
        }

        /// <summary>
        /// Define the AccesRights of an user.</summary>
        [Flags]public enum AccessRights
        {
            /// <summary>Used for login error, no rights</summary>
            None = 0x00,              //0000
            /// <summary>User is a Kitter</summary>
            Kitter = 0x01,              //0001
            /// <summary>User is a KantoorMedewerker and has modification rights</summary>
            KantoorMedewerker = 0x02,   //0010
            /// <summary>User is a Leidinggevende and has modification rights</summary>
            Leidinggevende = 0x04,      //0100
        }

    }
}

