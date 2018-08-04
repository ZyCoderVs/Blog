using Blog.Business.IBLL;
using Blog.DataAccess.DAL;
using Blog.DataAccess.IDAL;

namespace Blog.Business.BLL
{
    public class BaseBLL<T> : IBaseBLL<T> where T : Entity.Entity,new ()
    {
        protected IBaseDAL<T> _dal = new BaseDAL<T>();

        public bool Add(T t)
        {
            return _dal.Add(t);
        }

        public bool Delete(int Id)
        {
            return _dal.Delete(Id);
        }

        public T Get(int id)
        {
            return _dal.Get(id);
        }

        public bool Update(T t)
        {
            return _dal.Update(t);
        }
    }
}
