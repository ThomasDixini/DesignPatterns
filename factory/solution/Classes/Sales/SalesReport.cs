using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.Interfaces;

namespace solution.Classes
{
    public class SalesReport : IReport
    {
        public string PrintReport()
        {
            return "Sales Report Generated";
        }
    }
}