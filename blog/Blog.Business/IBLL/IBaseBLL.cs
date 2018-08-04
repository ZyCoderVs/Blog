namespace Blog.Business.IBLL
{
    public interface IBaseBLL<T> where T : Entity.Entity
    {

        bool Add(T t);

        bool Delete(int Id);

        bool Update(T t);

        T Get(int id);
    }
}
