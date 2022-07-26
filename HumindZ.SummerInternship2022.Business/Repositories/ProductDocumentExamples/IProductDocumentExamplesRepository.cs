using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.ProductDocumentExamplesRepository
{
    public interface IProductDocumentExamplesRepository
    {
        Task<ProductDocumentExamples> GetByProductDocumentExampleNameAsync(string productDocumentExampleName);
    }
}
