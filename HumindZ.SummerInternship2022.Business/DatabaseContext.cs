namespace HumindZ.SummerInternship2022.Business
{
    using Microsoft.EntityFrameworkCore;

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductDocumentDocumentationLinks> ProductDocumentDocumentationLinks { get; set; }
        public DbSet<ProductDocumentExamples> ProductDocumentExamples { get; set; }
    }
}
