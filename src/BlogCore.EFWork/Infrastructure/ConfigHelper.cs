using Microsoft.Extensions.Configuration;
using System.IO;

namespace BlogCore.EFWork.Infrastructure
{
    public class ConfigHelper
    {
        public static IConfiguration Configuration { get; set; }

        static ConfigHelper()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public static string GetValue(string key)
        {
            return Configuration[key]?.ToString();
        }
    }
}
