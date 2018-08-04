using Autofac;
using Autofac.Integration.Mvc;
using Blog.Business.BLL;
using Blog.DataAccess.DAL;
using System.Reflection;
using System.Web.Mvc;
using System.Linq;

namespace Blog.WebApp.App_Start
{
    //autofac  ioc
    // di
    public class AutofacConfig
    {
        public static void Config()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(UserBLL))).Where(c=>!c.Name.Contains("Base"))
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(UserDAL))).Where(c => !c.Name.Contains("Base"))
                .AsImplementedInterfaces();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}