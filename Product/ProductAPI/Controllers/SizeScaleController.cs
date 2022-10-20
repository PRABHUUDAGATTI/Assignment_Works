using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBLL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]
    public class SizeScaleController : ControllerBase
    {
        private SizeScaleServices _SizeScaleServices;
        public SizeScaleController(SizeScaleServices SizeScaleServices)
        {
            _SizeScaleServices = SizeScaleServices;
        }
        [HttpGet("GetALLSizeScale")]
        public IEnumerable<SizeScale> GetAllSizeScale()
        {
            return _SizeScaleServices.GetAll();
        }
        [HttpPost("AddSizeScale")]
        public IActionResult AddSizeScale(SizeScale SizeScale)
        {
            _SizeScaleServices.AddSizeScale(SizeScale);
            return Ok("The SizeScale Added");
        }
        [HttpPut("UpdateSizeScale")]
        public IActionResult UpdateSizeScale(SizeScale SizeScale)
        {
            _SizeScaleServices.UpdateSizeScale(SizeScale);
            return Ok("The SizeScale Updated");
        }
        [HttpDelete("DeleteSizeScale")]
        public IActionResult DeleteSizeScale(int SizeScaleId)
        {
            _SizeScaleServices.DeleteSizeScale(SizeScaleId);
            return Ok("The SizeScaleD eleted");
        }
        [HttpGet("GetSizeScaleById")]
        public SizeScale GetMovieById(int SizeScaleId)
        {
            return _SizeScaleServices.GeSizeScaleById(SizeScaleId);
        }
    }*/
}
