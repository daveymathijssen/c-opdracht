using System.Collections.Generic;

namespace NetworkLibrary
{
    public interface ServerInterface
    {
        void Login(string username, string password);
        void AddUser(User user);
        void SaveWerkbon(Werkbon werkbon);
        void GetUsers();
        void GetWerkbonnen();
        void NewWerkbonnen(List<Werkbon> werkbonnen);
        void NewUsers(List<User> users);
    }
}
