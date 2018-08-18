using BlogCore.EFWork.Entity;
using BlogCore.EFWork.Model;
using System.Collections.Generic;

namespace BlogCore.EFWork.IRepository
{
    public interface IMenuRepository
    {
        bool AddOrUpdateMenu(Menus menus);

        Menus GetMenu(int Id);

        List<Menus> GetMenusList(ref GridPage gridPage,string menuName);

        bool Delete(int Id);

        List<Menus> GetMenus();
    }
}
