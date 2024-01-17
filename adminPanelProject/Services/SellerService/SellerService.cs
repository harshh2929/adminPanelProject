
using adminPanelProject.Data;
using adminPanelProject.Entity;
using adminPanelProject.Models.Seller;
using Microsoft.EntityFrameworkCore;

namespace adminPanelProject.Services.SellerService
{
    public class SellerService : ISellerService
    {
        private readonly DataContext _context;
        public SellerService(DataContext context)
        {
            _context = context;
        }
       

        public async Task<List<Seller>> GetAllSellerAsync()
        {
            var sellers = await _context.Sellers.ToListAsync();

            return sellers;
        }

        public async Task<List<Seller>> AddSeller(SellerPost seller)
        {
            var Adminobject = new Seller
            {
                Name = seller.Name,
                Salary = seller.Salary,
                Position = seller.Position,
                Mobile = (long)seller.Mobile,
            };
            _context.Sellers.Add(Adminobject);
            await _context.SaveChangesAsync();
            return await _context.Sellers.ToListAsync();
        }
    }
}
