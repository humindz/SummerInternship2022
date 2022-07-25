namespace HumindZ.SummerInternship2022.Business
{
    using Microsoft.EntityFrameworkCore;

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}
