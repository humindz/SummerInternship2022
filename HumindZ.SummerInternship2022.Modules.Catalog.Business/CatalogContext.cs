using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace HumindZ.SummerInternship2022.Modules.Catalog.Business
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options)
                : base(options)
        { }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductDocumentDocumentationLinks> ProductDocumentDocumentationLinks { get; set; }
        public DbSet<ProductDocumentExamples> ProductDocumentExamples { get; set; }

        
    }
}
