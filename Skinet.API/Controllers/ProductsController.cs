using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Core.Entities;

namespace Skinet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            this._context=context;
        }
        [HttpGet]
        [Route("GetProduct")]
        public async Task<ActionResult<List<Product>>> GetProducts(){
            var  products=await _context.Products.ToListAsync();
            return Ok(products);
        }
        [HttpGet]
        [Route("GetById/{Id}")]
        public async Task<ActionResult<Product>> GetById(int Id){
            var product=await _context.Products.FindAsync(Id);
            return product;
        }
    }
}