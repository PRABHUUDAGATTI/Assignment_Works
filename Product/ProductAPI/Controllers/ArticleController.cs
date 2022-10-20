using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBLL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]
    *//*public class ArticleController : ControllerBase
    {
        private ArticleServices _ArticleServices;
        public ArticleController(ArticleServices ArticleServices)
        {
            _ArticleServices = ArticleServices;
        }
        [HttpGet("GetALLArticle")]
        public IEnumerable<Article> GetAllArticle()
        {
            return _ArticleServices.GetAll();
        }
        [HttpPost("AddArticle")]
        public IActionResult AddArticle(Article Article)
        {
            _ArticleServices.AddArticle(Article);
            return Ok("The Article Added");
        }
        [HttpPut("UpdateArticle")]
        public IActionResult UpdateArticle(Article Article)
        {
            _ArticleServices.UpdateArticle(Article);
            return Ok("The Article Updated");
        }
        [HttpDelete("DeleteArticle")]
        public IActionResult DeleteArticle(int ArticleId)
        {
            _ArticleServices.DeleteArticle(ArticleId);
            return Ok("The ArticleD eleted");
        }
        [HttpGet("GetArticleById")]
        public Article GetMovieById(int ArticleId)
        {
            return _ArticleServices.GeArticleById(ArticleId);
        }}*/
    
}
