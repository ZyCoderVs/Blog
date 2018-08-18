using BlogCore.EFWork.Entity;
using BlogCore.EFWork.Model;
using System.Collections.Generic;

namespace BlogCore.EFWork.IRepository
{
    public interface IArticleRepository
    {
        bool AddArt(Article article);

        List<Article> GetArticlesPage(ref GridPage gridPage, string keyWords,string menuId);

        bool Delete(int id);

        Article GetArticle(int id);
    }
}
