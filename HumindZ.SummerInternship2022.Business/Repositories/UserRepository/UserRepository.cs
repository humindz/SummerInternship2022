using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext context;

        public UserRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<User> GetUserByNameAsync(string userName)
        {
            return await context.Users.FirstOrDefaultAsync(e => e.UserName.Equals(userName));
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await context.Users.ToListAsync();
        }
    }
}
