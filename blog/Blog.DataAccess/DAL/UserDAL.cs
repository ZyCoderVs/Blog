using System.Collections.Generic;
using System.Linq;
using Blog.DataAccess.IDAL;
using Blog.Entity;

namespace Blog.DataAccess.DAL
{
    public class UserDAL : BaseDAL<User>, IUserDAL
    {
        public List<User> GetUsers()
        {
            return blogContext.User.ToList();
        }
    }
}
