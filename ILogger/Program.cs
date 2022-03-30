using System;

namespace ILogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "c:\\temp\\MyTest.txt";

            var stringILogger = new LocalFileLogger<string>(path);
            stringILogger.LogInfo("LogInfo test: string");
            stringILogger.LogWarning("LogWarning test: string");
            stringILogger.LogError("LogError test: string", new Exception("Exeption test: string"));

            var intILogger = new LocalFileLogger<int>(path);
            intILogger.LogInfo("LogInfo test: int");
            intILogger.LogWarning("LogWarning test: int");
            intILogger.LogError("LogError test: int", new Exception("Exeption test: int"));

            var pointILogger = new LocalFileLogger<Point>(path);
            intILogger.LogInfo("LogInfo test: Point");
            intILogger.LogWarning("LogWarning test: Point");
            intILogger.LogError("LogError test: Point", new Exception("Exeption test: Point"));
        }
    }

}
