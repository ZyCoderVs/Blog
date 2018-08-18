using BlogCore.EFWork.Entity;

namespace BlogCore.EFWork.IRepository
{
    public interface IUserRepository
    {
        User Login(string account, string userPwd);
    }
}
