using System;

namespace ILogger
{
    public interface ILogger
    {
        public void LogInfo(string message);
        public void LogWarning(string message);
        public void LogError(string message, Exception ex);
    }

}
