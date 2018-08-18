using BlogCore.EFWork.Entity;
using BlogCore.EFWork.IRepository;
using BlogCore.EFWork.Model;
using System.Collections.Generic;
using System.Linq;

namespace BlogCore.EFWork.Repository
{
    public class MenuRepository : IMenuRepository
    {
        public bool AddOrUpdateMenu(Menus menus)
        {
            if (string.IsNullOrWhiteSpace(menus.MenuCode))
                return false;
            if (string.IsNullOrWhiteSpace(menus.MenuName))
                return false;
            using (var db = new BlogContext())
            {
                if (menus.Id == 0)
                {
                    db.Add(menus);
                }
                else
                {
                    db.Update(menus);
                }
                return db.SaveChanges() > 0;
            }
        }

        public bool Delete(int Id)
        {
            using (var db=new BlogContext())
            {
                var model = db.Menus.SingleOrDefault(c => c.Id == Id);
                db.Menus.Remove(model);
                return db.SaveChanges() > 0;
            }
        }

        public Menus GetMenu(int Id)
        {
            using (var db = new BlogContext())
            {
                return db.Menus.SingleOrDefault(c => c.Id == Id);
            }
        }

        public List<Menus> GetMenus()
        {
            using (var db=new BlogContext())
            {
                return db.Menus.ToList();
            }
        }

        public List<Menus> GetMenusList(ref GridPage gridPage, string menuName)
        {
            using (var db = new BlogContext())
            {
                var list = string.IsNullOrWhiteSpace(menuName) ? db.Menus as IQueryable<Menus> : db.Menus.Where(c => c.MenuName.Contains(menuName)) as IQueryable<Menus>;
                gridPage.Records = list.Count();
                return list.OrderByDescending(c => c.CreateTime)
                    .Skip((gridPage.Page - 1) * gridPage.Rows)
                    .Take(gridPage.Rows)
                    .ToList();
            }
        }
    }
}
