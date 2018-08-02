using log4net;
using System;
using System.IO;
using System.Web;

namespace Blog.Utilties.Blog.Log
{
    public class LogFactory
    {
        static LogFactory()
        {
            FileInfo configFile = new FileInfo(HttpContext.Current.Server.MapPath("/XmlConfig/log4net.config"));
            log4net.Config.XmlConfigurator.Configure(configFile);
        }

        public static LogHelper GetLogger(Type type)
        {
            return new LogHelper(LogManager.GetLogger(type));
        }

        public static LogHelper GetLogger(string str)
        {
            return new LogHelper(LogManager.GetLogger(str));
        }
    }
}
