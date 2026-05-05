using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.classes.Entities;
using solution.interfaces.Builders;

namespace solution.classes.Builders
{
    public class SalesReportBuilder : IReportBuilder
    {
        private SalesReport _report = new SalesReport();
        public SalesReportBuilder()
        {
            this.Reset();
        }
        public void AddExpenses()
        {
            _report.Add("JOIN Expenses e ON s.ExpenseId = e.Id"); 
        }

        public void AddIncomes()
        {
            _report.Add("JOIN Incomes i ON s.IncomeId = i.Id");
        }

        public void AddProfits()
        {
            _report.Add("SELECT (i.Amount - e.Amount) AS Profit FROM Sales s JOIN Incomes i ON s.IncomeId = i.Id JOIN Expenses e ON s.ExpenseId = e.Id");
        }

        public void Reset()
        {
            this._report = new SalesReport();
        }

        public SalesReport GetReport()
        {
            SalesReport result = this._report;
            this.Reset();
            return result;
        }
    }
}