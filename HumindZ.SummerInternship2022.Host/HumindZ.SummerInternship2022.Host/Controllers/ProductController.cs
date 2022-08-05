namespace HumindZ.SummerInternship2022.Host.Controllers
{
    using FluentValidation.Results;
    using HumindZ.SummerInternship2022.Services.Product;
    using HumindZ.SummerInternship2022.Services.User;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using Tweetinvi.Core.DTO;

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

       [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
        {
            var result = await this.productService.GetProducts();
            return Ok(result);
        }
    }
}
