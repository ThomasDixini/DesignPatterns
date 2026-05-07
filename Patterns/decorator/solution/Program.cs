// See https://aka.ms/new-console-template for more information

using solution.classes;

var scheduleRepository = new ScheduleRepository();
var loggingDecorator = new LoggingScheduleDecorator(scheduleRepository);
var cachingDecorator = new CachingScheduleRepository(loggingDecorator);

cachingDecorator.GetScheduleById(1);

Console.WriteLine("------------------------------");

cachingDecorator.GetScheduleById(1);

Console.WriteLine("------------------------------");

cachingDecorator.GetScheduleById(2);
