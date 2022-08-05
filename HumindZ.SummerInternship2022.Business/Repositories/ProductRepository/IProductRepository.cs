using System.Collections.Generic;
using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<Product> GetByProductNameAsync(string productName);
        Task<IEnumerable<Product>> GetAllProductsAsync();
/*        Task<IEnumerable<Product>> GetAllProductsByCategoryAsync(string categoryName);
*/    }
}
