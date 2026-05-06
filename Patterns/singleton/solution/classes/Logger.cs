using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solution.classes
{
    public class Logger
    {
        private static Logger? _instance;
        private Logger()
        {
            
        }

        public static Logger GetInstance()
        {
            if(_instance is null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}