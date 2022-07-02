using System;
using System.IO;

namespace DesignPattern.Factory.Models
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Datetime: {DateTime.Now} , Data: {message}");

        }
    }
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter w = File.AppendText("performanceData.log"))
            {
                w.WriteLine($"Datetime: {DateTime.Now} , Data: {message}");
            }
        }
    }
    internal class DataBaseLogger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"LogToDatabase: Datetime: {DateTime.Now} , Data: {message}");

        }
    }
}
