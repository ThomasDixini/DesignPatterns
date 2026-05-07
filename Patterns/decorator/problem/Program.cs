// See https://aka.ms/new-console-template for more information
using problem.classes;

var scheduleRepository = new ScheduleRepository();
scheduleRepository.GetById(1);

Console.WriteLine("------------------------------");

scheduleRepository.GetById(1);