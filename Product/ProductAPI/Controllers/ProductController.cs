using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBLL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductServices _ProductServices;
        public ProductController(ProductServices ProductServices)
        {
            _ProductServices = ProductServices;
        }
        [HttpGet("GetALLProduct")]
        public IEnumerable<Product> GetAllProduct()
        {
            return _ProductServices.GetAll();
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product Product)
        {
            _ProductServices.AddProduct(Product);
            return Ok("The Product Added");
        }
   /*     [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(Product Product)
        {
            _ProductServices.UpdateProduct(Product);
            return Ok("The Product Updated");
        }
        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct(int ProductId)
        {
            _ProductServices.DeleteProduct(ProductId);
            return Ok("The ProductD eleted");
        }
        *//*[HttpGet("GetProductById")]
        public Product GetMovieById(int ProductId)
        {
            return _ProductServices.GeProductById(ProductId);
        }*/
    }
}
