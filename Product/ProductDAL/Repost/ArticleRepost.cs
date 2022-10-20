using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductDAL.Repost
{
    public class ArticleRepost:IArticleRepost
    {
        ProductDB _db;
        public ArticleRepost(ProductDB db)
        {
            _db = db;
        }
        public void AddArticle(Article Article)
        {
            _db.articles.Add(Article);
            _db.SaveChanges();
        }
        public void RemoveArticle(int ArticleId)
        {
            var theater = _db.articles.Find(ArticleId);
            _db.articles.Remove(theater);
            _db.SaveChanges();
        }
        public Article GetArticle(int ArticleId)
        {
            return _db.articles.Find(ArticleId);
        }
        public IEnumerable<Article> GetArticleList()
        {
            return _db.articles.Include(obj => obj.Colour).ToList();
        }
        public void UpdateArticle(Article Article)
        {
            _db.Entry(Article).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
