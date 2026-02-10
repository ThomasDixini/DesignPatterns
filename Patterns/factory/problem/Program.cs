namespace problem;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GenerateReport("receipts"));
    }

    public static string GenerateReport(string typeReport)
    {
        if(typeReport == "receipts")
        {
            var receiptsReport = new ReceiptsReport();
            return receiptsReport.Generate();
        }
        else if(typeReport == "sales")
        {
            var salesReport = new SalesReport();
            return salesReport.Generate();
        }
        else {
            return "Invalid Report Type";
        }
    }
}
