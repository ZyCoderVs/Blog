using System.Collections.Generic;
using System.Linq;
using BlogCore.EFWork.Entity;
using BlogCore.EFWork.IRepository;
using BlogCore.EFWork.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogCore.EFWork.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        public bool AddArt(Article article)
        {
            using (var db=new BlogContext())
            {

                var q= article.Id == 0 ? db.Add(article) : db.Update(article);
                return db.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new BlogContext())
            {
                var model = db.Articles.SingleOrDefault(c => c.Id == id);
                db.Articles.Remove(model);
                return db.SaveChanges() > 0;
            }
        }

        public Article GetArticle(int id)
        {
            using (var db = new BlogContext())
            {
                return db.Articles.Include(c=>c.Menu).Include(c=>c.User).SingleOrDefault(c => c.Id == id);
            }
        }

        public List<Article> GetArticlesPage(ref GridPage gridPage, string keyWords,string menuId)
        {
            using (var db = new BlogContext())
            {
                var list = string.IsNullOrWhiteSpace(keyWords) ? db.Articles.Include(c => c.User) as IEnumerable<Article> : db.Articles.Include(c => c.User).Where(c => c.Title.Contains(keyWords)) as IEnumerable<Article>;
                int.TryParse(menuId, out int menuIds);
                if (menuIds != 0)
                    list = list.Where(c => c.MenuId == menuIds);
                gridPage.Records = list.Count();
                return list.OrderByDescending(c => c.CreateTime)
                    .Skip((gridPage.Page - 1) * gridPage.Rows)
                    .Take(gridPage.Rows)
                    .ToList();
            }
        }
    }
}
