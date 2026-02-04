using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.Interfaces;

namespace solution.Classes.Receipts
{
    public class ReceiptsReport : IReport
    {
        public string PrintReport()
        {
            return "Receipts Report Generated";
        }
    }
}