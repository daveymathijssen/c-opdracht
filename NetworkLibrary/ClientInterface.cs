﻿using System.Collections.Generic;

namespace NetworkLibrary
{
    public interface ClientInterface
    {
        void LoginResponse(bool loginOk, User.AccessRights accessRights);
        bool SaveWerkbonResponse();
        void GetUsersResponse(List<User> users);
        void GetWerkbonnenResponse(List<Werkbon> werkbonnen);
    }
}
