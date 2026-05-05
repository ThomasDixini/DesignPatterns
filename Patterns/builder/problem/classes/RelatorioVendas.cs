using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace problem.classes
{
    public class SalesReport
    {
        private List<string> _filters = new List<string>();
        private string _query = "SELECT * FROM Sales";
        private bool? _includeIncomes;
        private bool? _includeExpenses;
        private bool? _includeProfits;
        public SalesReport(bool? includeIncomes)
        {
            _includeIncomes = includeIncomes;
        }

        public SalesReport(bool? includeIncomes, bool? includeExpenses) : this(includeIncomes)
        {
            _includeExpenses = includeExpenses;
        }
        public SalesReport(bool? includeIncomes, bool? includeExpenses, bool? includeProfits) : this(includeIncomes, includeExpenses)
        {
            _includeProfits = includeProfits;
        }

        public void GenerateReport()
        {
            Console.WriteLine("Generating sales report...");
            if (_includeIncomes.HasValue && _includeIncomes.Value)
            {
                _filters.Add("JOIN Incomes ON Sales.Id = Incomes.SaleId");
                Console.WriteLine("Including incomes in the report.");
            }
            if (_includeExpenses.HasValue && _includeExpenses.Value)
            {
                _filters.Add("JOIN Expenses ON Sales.Id = Expenses.SaleId");
                Console.WriteLine("Including expenses in the report.");
            }
            if (_includeProfits.HasValue && _includeProfits.Value)
            {
                Console.WriteLine("Including profits in the report.");
            }

             if (_filters.Any())
                _query += " WHERE " + string.Join(" AND ", _filters);
            
            Console.WriteLine("Generate query: " + _query);
        }
    }
}