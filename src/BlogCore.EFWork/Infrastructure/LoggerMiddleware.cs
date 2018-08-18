using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BlogCore.EFWork.Infrastructure
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        public LoggerMiddleware(ILoggerFactory loggerFactory, IHostingEnvironment env,RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
            loggerFactory.AddNLog();
            string dir = AppContext.BaseDirectory;
            string logPath = Path.Combine(dir, "NLog", "nlog.config");
            env.ConfigureNLog(logPath);
        }

        public async Task Invoke(HttpContext context)
        {
            await _requestDelegate.Invoke(context);
        }
    }
}
