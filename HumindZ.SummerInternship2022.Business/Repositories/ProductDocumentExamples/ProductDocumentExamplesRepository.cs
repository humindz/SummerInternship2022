using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.ProductDocumentExamplesRepository
{
    public class ProductDocumentExamplesRepository : IProductDocumentExamplesRepository
    {
        private readonly DatabaseContext context;

        public ProductDocumentExamplesRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<ProductDocumentExamples> GetByProductDocumentExampleNameAsync(string productDocumentExampleName)
        {
            return await context.ProductDocumentExamples.FirstOrDefaultAsync(e => e.ProductDocumentExampleName.Equals(productDocumentExampleName));
        }
    }
}
