using Business.Abstract;
using Entitties.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpPost("addProduct")]
        public IActionResult AddProduct(Product product)
        {
            var result = _productManager.Add(product);
            if(result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpDelete("deleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            var result =_productManager.Delete(id);
            if(result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpGet("getProductById")]
        public IActionResult GetProduct(int id)
        {
            var result = _productManager.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpGet("getAllProduct")]
        public IActionResult GetAllProduct()
        {
            var result = _productManager.GetAll();
            if(result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

    }
}
