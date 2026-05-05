// See https://aka.ms/new-console-template for more information
using solution.classes.Builders;
using solution.classes.Directors;

var director = new Director();
var builder = new SalesReportBuilder();
director.Builder = builder;

director.BuildSimpleReport();
Console.WriteLine("Simple Report:");
builder.GetReport().GenerateReport();

Console.WriteLine("--------------------");

director.BuildCompleteReport();
Console.WriteLine("Complete Report:");
builder.GetReport().GenerateReport();