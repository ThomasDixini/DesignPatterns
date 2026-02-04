using solution.Classes;
using solution.Classes.Receipts;
using solution.Interfaces;
namespace solution;

class Program
{
    static void Main(string[] args)
    {
        string typeReport = "receipts";
        ReportGenerator reportGenerator;
        if(typeReport == "receipts")
        {
            reportGenerator = new ReceiptsReportGenerator();
        }
        else if(typeReport == "sales")
        {
            reportGenerator = new SalesReportGenerator();
        }
        else 
        {
            Console.WriteLine("Invalid Report Type");
            return;
        }

        Console.WriteLine(reportGenerator.Generate());
    }
}
