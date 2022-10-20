using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBLL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
   /* [Route("api/[controller]")]
    [ApiController]
    public class ColourController : ControllerBase
    {
        private ColourServices _ColourServices;
        public ColourController(ColourServices ColourServices)
        {
            _ColourServices = ColourServices;
        }
        [HttpGet("GetALLColour")]
        public IEnumerable<Colour> GetAllColour()
        {
            return _ColourServices.GetAll();
        }
        [HttpPost("AddColour")]
        public IActionResult AddColour(Colour Colour)
        {
            _ColourServices.AddColour(Colour);
            return Ok("The Colour Added");
        }
        [HttpPut("UpdateColour")]
        public IActionResult UpdateColour(Colour Colour)
        {
            _ColourServices.UpdateColour(Colour);
            return Ok("The Colour Updated");
        }
        [HttpDelete("DeleteColour")]
        public IActionResult DeleteColour(int ColourId)
        {
            _ColourServices.DeleteColour(ColourId);
            return Ok("The ColourD eleted");
        }
        [HttpGet("GetColourById")]
        public Colour GetMovieById(int ColourId)
        {
            return _ColourServices.GeColourById(ColourId);
        }
    }*/
}
