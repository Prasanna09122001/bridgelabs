using System;
using NLog;

namespace NlogImplementation
{
    internal class NlogOperation
    {
        Logger logger1 = LogManager.GetCurrentClassLogger();
        public void LogInfo(string message)
        {
            logger1.Info(message);
        }
        public void LogDebug(string message)
        {
            logger1.Debug(message);
        }
      
        
        public void LogWarn(string message)
        {
            logger1.Warn(message);
        }
        public void LogError(string message)
        {
            logger1.Error(message);
        }
    }
}
