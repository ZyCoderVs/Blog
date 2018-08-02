using Blog.Business.IBLL;
using Blog.DataAccess.IDAL;

namespace Blog.Business.BLL
{
    public class TestBLL : ITestBLL
    {
        private readonly ITestDAL _dal;
        public TestBLL(ITestDAL dal)
        {
            this._dal = dal;
        }
        public string Get()
        {
            return _dal.Get();
        }
    }
}
