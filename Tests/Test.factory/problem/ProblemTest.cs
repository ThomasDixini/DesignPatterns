using problem;

namespace Tests.Test.factory.problem;


public class UnitTest1
{
    [Fact]
    public void GenerateReport_WithReceiptsType_ReturnsReceiptsReport()
    {
        string typeReport = "receipts";
        var result = Program.GenerateReport(typeReport);

        Assert.Equal("Receipts Report Generated", result);
    }
    [Fact]
    public void GenerateReport_WithSalesType_ReturnsSalesReport()
    {
        string typeReport = "sales";
        var result = Program.GenerateReport(typeReport);

        Assert.Equal("Sales Report Generated", result);
    }
    [Fact]
    public void GenerateReport_WhenInvalidType_ShouldReturnInvalidStringMessage()
    {
        string typeReport = "invalid";
        var result = Program.GenerateReport(typeReport);

        Assert.Equal("Invalid Report Type", result);
    }
}
