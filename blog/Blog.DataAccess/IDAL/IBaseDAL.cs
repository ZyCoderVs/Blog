namespace Blog.DataAccess.IDAL
{
    public interface IBaseDAL<T> where T:Entity.Entity,new ()
    {
        bool Add(T t);

        bool Delete(int Id);

        bool Update(T t);

        T Get(int id);
    }
}
