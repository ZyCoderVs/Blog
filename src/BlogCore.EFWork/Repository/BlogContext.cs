using BlogCore.EFWork.Entity;
using BlogCore.EFWork.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BlogCore.EFWork.Repository
{
    public class BlogContext: DbContext
    {
        public BlogContext() { }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(ConfigHelper.GetValue("SqlServer"));
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SKDDBOM;Initial Catalog=BlogsDb;Integrated Security=True");
            }
        }
    }
}
