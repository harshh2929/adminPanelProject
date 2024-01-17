

using adminPanelProject.Entity;
using adminPanelProject.Models.Seller;

namespace adminPanelProject.Services.SellerService
{
    public interface ISellerService
    {

        Task<List<Seller>> GetAllSellerAsync();

        Task<List<Seller>> AddSeller(SellerPost seller);


    }
}
