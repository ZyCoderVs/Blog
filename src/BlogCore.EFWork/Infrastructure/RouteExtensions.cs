using Microsoft.AspNetCore.Builder;

namespace BlogCore.EFWork.Infrastructure
{
    public static class RouteExtensions
    {
        public static void LoadMvcRoute(this IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaults",
                    template: "{controller=Article}/{action=Index}/{id}");
                routes.MapRoute(
                    name: "defaultList",
                    template: "{controller=Home}/{action=Index}/{type}/{page?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "admin",
                    template: "{area:exists}/{controller}/{action=Index}/{id?}");
            });
        }
    }
}
