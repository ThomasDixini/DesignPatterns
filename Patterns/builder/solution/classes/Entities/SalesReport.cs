using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solution.classes.Entities
{
    public class SalesReport
    {
        private List<string> _filters = new List<string>();
        public void Add(string filter)
        {
            _filters.Add(filter);
        }

        public void GenerateReport()
        {
            Console.WriteLine("Generating sales report...");
            var query = "SELECT * FROM Sales s";
            if (_filters.Any())
                query += " " + string.Join(" ", _filters);
            
            Console.WriteLine("Generate query: " + query);
        }
    }
}