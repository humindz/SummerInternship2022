using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await context.Product.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsFilteredAsync(IEnumerable<string> filters)
        {
            return await context.Product.Where(e => filters.Any(filter => filter == e.ProductCategoryType)).ToListAsync();
/*            return await Task.FromResult((IEnumerable<Product>)context.Product.Where(e => filters.Any(filter => filter == e.ProductCategoryType)).ToListAsync());
*/
        }


    }
}
