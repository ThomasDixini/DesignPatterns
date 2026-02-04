using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solution.Interfaces
{
    public abstract class ReportGenerator
    {
        public abstract IReport CreateReport();
        public string Generate()
        {
            var report = CreateReport();
            return report.PrintReport();
        }
    }
}