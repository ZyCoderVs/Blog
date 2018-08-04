using System.Collections.Generic;
using System.Linq;
using Blog.DataAccess.IDAL;
using Blog.Entity;

namespace Blog.DataAccess.DAL
{
    // 实现接口
    public class UserDAL : BaseDAL<User>, IUserDAL
    {
        // 实现获取用户列表方法
        public List<User> GetUsers()
        {
            return blogContext.User.ToList();
        }
    }
}
