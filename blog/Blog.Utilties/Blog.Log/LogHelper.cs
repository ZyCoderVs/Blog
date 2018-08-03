using log4net;
using System;

namespace Blog.Utilties
{
    public class LogHelper
    {
        private ILog logger;

        public LogHelper(ILog log)
        {
            this.logger = log;
        }
        public void Debug(object message)
        {
            this.logger.Debug(message);
        }
        public void Debug(object message, Exception e)
        {
            this.logger.Debug(message, e);
        }
        public void Error(object message)
        {
            this.logger.Error(message);
        }
        public void Error(object message, Exception e)
        {
            this.logger.Error(message, e);
        }
        public void Info(object message)
        {
            this.logger.Info(message);
        }
        public void Info(object message, Exception e)
        {
            this.logger.Info(message, e);
        }
        public void Warn(object message)
        {
            this.logger.Warn(message);
        }
        public void Warn(object message, Exception e)
        {
            this.logger.Warn(message, e);
        }
    }
}
