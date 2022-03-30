using System;
using System.IO;
namespace ILogger
{
    public class LocalFileLogger <T>: ILogger
    {
        private string Path;
        public LocalFileLogger(string path)
        {
            Path = path;
        }

        public void LogInfo(string message)
        {
            File.AppendAllText(Path, $"[Info]: [{typeof(T).Name}] : {message}\n");       
        }

        public void LogWarning(string message)
        {
            File.AppendAllText(Path, $"[Warning] : [{typeof(T).Name}] : {message}\n");
        }

        public void LogError(string message, Exception ex)
        {
            File.AppendAllText(Path, $"[Error] : [{typeof(T).Name}] : {message}. {ex.Message}\n");
        }
    }
}
