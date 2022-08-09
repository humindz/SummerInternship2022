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
    using System.Web.Http;
    using Tweetinvi.Core.DTO;

    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

       [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
        {
            var result = await this.productService.GetProducts();
            return Ok(result);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("filtered")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllByFilters([FromUri] string filter)
        {

           /* var filters = new List<string>();
            filters.Add( filter );*/
            var result = await this.productService.GetProductsByFilters(filter);
            return Ok(result);
          /*  var result = await this.productService.GetProducts();
            return Ok(result);*/
        }
    }
}
