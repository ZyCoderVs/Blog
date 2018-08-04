namespace Blog.DataAccess.Context
{
    using Blog.Entity;
    using System.Data.Entity;

    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("name=BlogContext")
        {
        }

        public virtual DbSet<User> User { get; set; }
    }

}