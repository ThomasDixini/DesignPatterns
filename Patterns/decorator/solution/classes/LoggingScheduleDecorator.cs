using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.db;
using solution.interfaces;

namespace solution.classes
{
    public class LoggingScheduleDecorator : ISchedulesRepository
    {
        private readonly ISchedulesRepository _scheduleRepository;
        private SimulatedDB _db { get; init; } = new SimulatedDB();

        public LoggingScheduleDecorator(ISchedulesRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public void GetScheduleById(int id)
        {
            Console.WriteLine("Logging the schedules...");
            var schedule = _db.Schedules.FirstOrDefault(s => s.Id == id);
            _scheduleRepository.GetScheduleById(id);
        }
    }
}