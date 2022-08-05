using HumindZ.SummerInternship2022.Business.Repositories.ProductRepository;
using HumindZ.SummerInternship2022.Business.Repositories.UserRepository;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HumindZ.SummerInternship2022.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var results = await productRepository.GetAllProductsAsync();
            var productDtos = new List<ProductDto>();

            foreach (var result in results)
            {
                var productDto = new ProductDto
                {
                    ProductId = result.ProductId,
                    ProductName = result.ProductName,
                    ProductCategoryType = result.ProductCategoryType,
                    ProductShortDescription = result.ProductShortDescription,
                    ProductLongDescription = result.ProductLongDescription,
                    ProductVersion = result.ProductVersion,
                    ProductVersionDate = result.ProductVersionDate,
                    ProductVersionNotes = result.ProductVersionNotes,
                    ProductPrice = result.ProductPrice,
                };
                productDtos.Add(productDto);
            }
            return productDtos;

        }

    }
}
