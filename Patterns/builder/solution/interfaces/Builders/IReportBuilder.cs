using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solution.interfaces.Builders
{
    public interface IReportBuilder
    {
        void Reset();
        void AddIncomes();
        void AddExpenses();
        void AddProfits();
    }
}