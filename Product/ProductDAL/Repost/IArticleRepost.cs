using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL.Repost
{
    public interface IArticleRepost
    {
        void AddArticle(Article Article);
        Article GetArticle(int Articleid);
        void RemoveArticle(int Articleid);
        void UpdateArticle(Article Article);
        IEnumerable<Article> GetArticleList();

    }
}
