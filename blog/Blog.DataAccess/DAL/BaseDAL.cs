using Blog.DataAccess.Context;
using Blog.DataAccess.IDAL;

namespace Blog.DataAccess.DAL
{
    public class BaseDAL<T> : IBaseDAL<T> where T : Entity.Entity, new()
    {
        protected BlogContext blogContext = new BlogContext();
        public bool Add(T t)
        {
            blogContext.Set<T>().Add(t);
            return blogContext.SaveChanges() > 0;
        }

        public bool Delete(int Id)
        {
            T t= blogContext.Set<T>().Find(Id);
            if(t!=null)
            {
                blogContext.Set<T>().Remove(t);
                return blogContext.SaveChanges() > 0;
            }
            return false;

        }

        public T Get(int id)
        {
            T t = blogContext.Set<T>().Find(id);
            if (t != null)
                return t;
            return default(T);
        }

        public bool Update(T t)
        {
            blogContext.Entry<T>(t).State = System.Data.Entity.EntityState.Modified;
            return blogContext.SaveChanges() > 0;
        }
    }
}
