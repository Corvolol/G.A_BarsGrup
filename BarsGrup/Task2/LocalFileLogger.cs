using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class LocalFileLogger<T>:ILogger
    {
        private string _pathOfFile { get; set; }

        public LocalFileLogger(string pathOfFile)
        {
            _pathOfFile = pathOfFile;
        }

        public void LogInfo(string message)
        {
            using (StreamWriter str = new StreamWriter(_pathOfFile,true))
            {
                str.WriteLine($"[Info]: [{typeof(T).Name}] : {message}");
            }
        }
        public void LogWarning(string message)
        {
            using (StreamWriter str = new StreamWriter(_pathOfFile,true))
            {
                str.WriteLine($"[Info]: [{typeof(T).Name}] : {message}");
            }
        }
        public void LogError(string message, Exception ex)
        {
            using (StreamWriter str = new StreamWriter(_pathOfFile,true))
            {
                str.WriteLine($"[Error]: [{typeof(T).Name}] : {message}. {ex.Message}");
            }
        }
    }
}
