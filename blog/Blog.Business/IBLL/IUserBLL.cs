using Blog.Entity;
using System.Collections.Generic;

namespace Blog.Business.IBLL
{
    public interface IUserBLL:IBaseBLL<User>
    {
        List<User> GetUsers();
    }
}
