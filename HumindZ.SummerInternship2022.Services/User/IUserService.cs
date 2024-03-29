﻿using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Services.User
{
    public interface IUserService
    {
        public Task<UserDto> GetUserByUserName(string userName);
        public Task<UserDto> Login(string username, string password);

    }
}
