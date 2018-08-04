using Blog.Entity;
using System.Collections.Generic;

namespace Blog.DataAccess.IDAL
{
    public interface IUserDAL:IBaseDAL<User>
    {
        List<User> GetUsers();
    }
}
