using Microsoft.EntityFrameworkCore;
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

        public async Task<User> GetByUserNameAsync(string userName)
        {
            return await context.Users.FirstOrDefaultAsync(e => e.UserName.Equals(userName));
        }
    }
}
