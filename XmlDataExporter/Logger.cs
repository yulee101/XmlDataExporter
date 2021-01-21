using System;
using System.Collections.Generic;

namespace XmlDataExporter
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
