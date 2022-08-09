using System.Collections.Generic;
using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Services.Product
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDto>> GetProducts();
        public Task<IEnumerable<ProductDto>> GetProductsByFilters(string filters);
    }
}
