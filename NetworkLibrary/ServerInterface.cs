namespace NetworkLibrary
{
    public interface ServerInterface
    {
        void Login(string username, string password);
        void AddUser(User user);
        void SaveWerkbon(Werkbon werkbon);
    }
}
