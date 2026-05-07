using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.db;
using solution.interfaces;

namespace solution.classes
{
    public class ScheduleRepository : ISchedulesRepository
    {
        private SimulatedDB _db { get; init; } = new SimulatedDB();
        public void GetScheduleById(int id)
        {
            var schedule = _db.Schedules.FirstOrDefault(s => s.Id == id);
            Console.WriteLine($"Schedule retrieved: {schedule.Name}");
        }
    }
}