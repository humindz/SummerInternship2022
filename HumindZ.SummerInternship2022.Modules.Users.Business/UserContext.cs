
using Microsoft.EntityFrameworkCore;

namespace HumindZ.SummerInternship2022.Modules.Users.Business

{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
                : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
