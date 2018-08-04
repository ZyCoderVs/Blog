using Blog.Entity;
using System.Collections.Generic;

namespace Blog.DataAccess.IDAL
{
    // 接口
    public interface IUserDAL:IBaseDAL<User>
    {
        // 获取所有用户
        List<User> GetUsers();


    }
}
