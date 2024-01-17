using adminPanelProject.Entity;
using adminPanelProject.Models.Product;
using adminPanelProject.Models.Seller;
using adminPanelProject.Services.ProductService;
using adminPanelProject.Services.SellerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace adminPanelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProduct()
        {

            return await _productService.GetAllProductAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProduct(ProductPost product)
        {
            try
            {
                var result = await _productService.AddProduct(product);
                return CreatedAtAction(nameof(AddProduct), result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
