using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.Interfaces;

namespace solution.Classes
{
    public class SalesReportGenerator : ReportGenerator
    {
        public override IReport CreateReport()
        {
            return new SalesReport();
        }
    }
}