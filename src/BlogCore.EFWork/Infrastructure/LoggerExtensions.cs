using Microsoft.AspNetCore.Builder;

namespace BlogCore.EFWork.Infrastructure
{
    public static class LoggerExtensions
    {
        public static IApplicationBuilder UseNLog(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggerMiddleware>();
        }
    }
}
