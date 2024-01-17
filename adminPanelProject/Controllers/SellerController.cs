using adminPanelProject.Entity;
using adminPanelProject.Models.Seller;
using adminPanelProject.Services.SellerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace adminPanelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SellerController : ControllerBase
    {
        private readonly ISellerService _sellerService;
        public SellerController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Seller>>> GetAllSeller()
        {

            return await _sellerService.GetAllSellerAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<Seller>>> AddSeller(SellerPost seller)
        {
            try
            {
                var result = await _sellerService.AddSeller(seller);
                return CreatedAtAction(nameof(AddSeller), result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
