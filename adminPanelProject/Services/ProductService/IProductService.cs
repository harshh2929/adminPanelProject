using adminPanelProject.Entity;
using adminPanelProject.Models.Product;

namespace adminPanelProject.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductAsync();

        Task<List<Product>> AddProduct(ProductPost product);


    }
}
