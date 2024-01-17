using adminPanelProject.Data;
using adminPanelProject.Entity;
using adminPanelProject.Models.Product;
using adminPanelProject.Models.Seller;
using Microsoft.EntityFrameworkCore;

namespace adminPanelProject.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }


        public async Task<List<Product>> GetAllProductAsync()
        {
            var sellers = await _context.Products.ToListAsync();

            return sellers;
        }

        public async Task<List<Product>> AddProduct(ProductPost product)
        {
            var Adminobject = new Product
            {
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                ManufacturerName = product.ManufacturerName,
                ManufacturerLocation = product.ManufacturerLocation,
            };
            _context.Products.Add(Adminobject);
            await _context.SaveChangesAsync();
            return await _context.Products.ToListAsync();
        }
    }
}
