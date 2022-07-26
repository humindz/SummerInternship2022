using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.ProductDocumentDocumentationLinksRepository
{
    public class ProductDocumentDocumentationLinksRepository : IProductDocumentDocumentationLinksRepository
    {
        private readonly DatabaseContext context;

        public ProductDocumentDocumentationLinksRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<ProductDocumentDocumentationLinks> GetByProductDocumentDocumentationLinksNameAsync(string productDocumentDocumentationLinksName)
        {
            return await context.ProductDocumentDocumentationLinks.FirstOrDefaultAsync(e => e.ProductDocumentDocumentationLinksName.Equals(productDocumentDocumentationLinksName));
        }
    }
}
