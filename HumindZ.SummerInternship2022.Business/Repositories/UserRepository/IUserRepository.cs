using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.UserRepository
{
    public interface IUserRepository
    {
        public Task<User> GetUserByNameAsync(string userName);
        public Task<IEnumerable<User>> GetUsersAsync();
        public Task<User> GetUserByIdAsync(Guid id);

    }
}
