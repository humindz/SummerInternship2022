using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext context;

        public ProductRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<Product> GetByProductNameAsync(string productName)
        {
            return await context.Product.FirstOrDefaultAsync(e => e.ProductName.Equals(productName));
        }
    }
}
