using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace problem.classes
{
    public class Logger
    {
        public Logger() {
            Console.WriteLine("Abrindo arquivo de log... (Recurso caro)");
        }
        public void Log(string message) {
            Console.WriteLine($"Log: {message}");
        }
    }
}