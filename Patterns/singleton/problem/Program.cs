// See https://aka.ms/new-console-template for more information
using problem.classes;

var logger = new Logger();
var logger2 = new Logger();

Console.WriteLine(logger.GetHashCode());
Console.WriteLine(logger2.GetHashCode());

logger.Log("This is a log message.");
logger2.Log("This is another log message.");