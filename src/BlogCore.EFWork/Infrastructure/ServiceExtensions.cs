using BlogCore.EFWork.IRepository;
using BlogCore.EFWork.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BlogCore.EFWork.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void LoadRepository(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
        }
    }
}
