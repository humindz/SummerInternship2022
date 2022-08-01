using Acr.UserDialogs;
using AutoMapper;
using Fluent.Infrastructure.FluentModel;
using HumindZ.SummerInternship2022.Business.Repositories.UserRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web.Mvc;
using Tweetinvi.Core.DTO;

namespace HumindZ.SummerInternship2022.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<UserDto> GetUserByUserName(string userName)
        {
            var result = await userRepository.GetUserByNameAsync(userName);

            return result == null ? null : new UserDto
            {
                Id = result.Id,
                FullName = result.FullName,
                UserName = result.UserName,
                Password = result.Password
            };
        }

        public async Task<UserDTO> Login(string username, string password)
        {
            var result = await userRepository.GetUserByNameAsync(username);
            if (result == null || !(result.Password == password))
            {
                return null;
            }
            return _mapper.Map<UserDTO>(result);
        }

       


        public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            var users = await userRepository.GetUsersAsync();
            var result = _mapper.Map<UserDTO[]>(users);

            return result;
        }
        public async Task<UserDTO> GetUserById(Guid id)
        {
            var result = await userRepository.GetUserByIdAsync(id);

            return result == null ? null : _mapper.Map<UserDTO>(result);
        }
    }
}
