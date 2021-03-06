﻿using System.Threading.Tasks;
using OpenMod.API.Ioc;

namespace OpenMod.API.Users
{
    [Service]
    public interface IUserDataStore
    {
        Task<UserData> GetUserDataAsync(string userId, string userType);
        Task SaveUserDataAsync(UserData userData);
    }
}