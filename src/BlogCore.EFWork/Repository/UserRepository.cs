using BlogCore.EFWork.Entity;
using BlogCore.EFWork.Infrastructure;
using BlogCore.EFWork.IRepository;
using System.Linq;

namespace BlogCore.EFWork.Repository
{
    public class UserRepository : IUserRepository
    {
        public User Login(string account, string userPwd)
        {
            if (string.IsNullOrWhiteSpace(account) || string.IsNullOrWhiteSpace(userPwd))
                return null;
            userPwd = Md5Helper.Md5(userPwd);
            using (var db=new BlogContext())
            {
                return db.Users.FirstOrDefault(c => c.Account == account && c.Pwd == userPwd);
            }
        }
    }
}
