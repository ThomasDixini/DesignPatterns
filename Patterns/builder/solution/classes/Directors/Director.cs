using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces.Builders;

namespace solution.classes.Directors
{
    public class Director
    {
        private IReportBuilder _builder;
        public IReportBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildSimpleReport()
        {
            _builder.AddIncomes();
        }

        public void BuildCompleteReport()
        {
            _builder.AddIncomes();
            _builder.AddExpenses();
            _builder.AddProfits();
        }
    }
}