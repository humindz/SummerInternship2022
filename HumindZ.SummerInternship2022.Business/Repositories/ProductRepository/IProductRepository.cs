using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<Product> GetByProductNameAsync(string productName);
    }
}
