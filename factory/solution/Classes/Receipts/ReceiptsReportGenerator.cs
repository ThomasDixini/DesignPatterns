using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.Interfaces;

namespace solution.Classes.Receipts
{
    public class ReceiptsReportGenerator : ReportGenerator
    {
        public override IReport CreateReport()
        {
            return new ReceiptsReport();
        }
    }
}