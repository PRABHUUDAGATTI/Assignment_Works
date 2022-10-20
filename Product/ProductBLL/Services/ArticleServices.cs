using ProductDAL.Repost;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBLL.Services
{
    public class ArticleServices
    {
       
            IArticleRepost _IArticleRepost;

            public ArticleServices(IArticleRepost IArticleRepost)
            {
            _IArticleRepost = IArticleRepost;
            }
            public void AddArticle(Article Article)

            {
            
           
                _IArticleRepost.AddArticle(Article);
            }
            public void UpdateArticle(Article Article)
            {
                _IArticleRepost.UpdateArticle(Article);
            }
            public void DeleteArticle(int Id)
            {
                _IArticleRepost.RemoveArticle(Id);
            }
            public Article GeArticleById(int id)
            {
            return _IArticleRepost.GetArticle(id);
            }
            public IEnumerable<Article> GetAll()
            {
            return _IArticleRepost.GetArticleList();
            }
        }
}
