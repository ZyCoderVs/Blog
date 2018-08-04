using System.Collections.Generic;
using Blog.Business.IBLL;
using Blog.DataAccess.IDAL;
using Blog.Entity;

namespace Blog.Business.BLL
{
    public class UserBLL:BaseBLL<User>,IUserBLL
    {
        private readonly IUserDAL _userDal;
        public UserBLL(IUserDAL userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetUsers()
        {
            return _userDal.GetUsers();
        }
    }
}
