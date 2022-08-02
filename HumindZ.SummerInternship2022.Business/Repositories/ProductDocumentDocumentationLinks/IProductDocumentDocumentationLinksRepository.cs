using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.ProductDocumentDocumentationLinksRepository
{
    public interface IProductDocumentDocumentationLinksRepository
    {
        Task<ProductDocumentDocumentationLinks> GetByProductDocumentDocumentationLinksNameAsync(string productDocumentDocumentationLinksName);
    }
}
