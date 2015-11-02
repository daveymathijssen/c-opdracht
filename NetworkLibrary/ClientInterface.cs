namespace NetworkLibrary
{
    public interface ClientInterface
    {
        void LoginResponse(bool loginOk, User.AccessRights accessRights);
        bool SaveWerkbonResponse();
    }
}
