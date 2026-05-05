// See https://aka.ms/new-console-template for more information
using problem.classes;

var reportWithIncomes = new SalesReport(true);
reportWithIncomes.GenerateReport();

var reportWithIncomesAndExpenses = new SalesReport(true, true);
reportWithIncomesAndExpenses.GenerateReport();

var reportComplete = new SalesReport(true, true, true);
reportComplete.GenerateReport();
