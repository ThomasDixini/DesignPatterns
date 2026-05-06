// See https://aka.ms/new-console-template for more information
using solution.classes;

var logger = Logger.GetInstance();
var logger2 = Logger.GetInstance();

Console.WriteLine(logger.GetHashCode());
Console.WriteLine(logger2.GetHashCode());

logger.Log("This is a log message.");
logger2.Log("This is another log message.");