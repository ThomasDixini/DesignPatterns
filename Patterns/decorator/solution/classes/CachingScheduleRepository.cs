using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.db;
using solution.interfaces;

namespace solution.classes
{
    public class CachingScheduleRepository : ISchedulesRepository
    {
        private readonly ISchedulesRepository _schedulesRepository;
        private SimulatedDB _db { get; init; } = new SimulatedDB();
        private Dictionary<int, dynamic> _cache { get; set; } = new Dictionary<int, dynamic>();
        public CachingScheduleRepository(ISchedulesRepository schedulesRepository)
        {
            _schedulesRepository = schedulesRepository;
        }
        public void GetScheduleById(int id)
        {
            if (_cache.ContainsKey(id))
            {
                Console.WriteLine($"Retrieving schedule with ID {id} from cache...");
                return;
            }

            Console.WriteLine($"Caching the schedule with ID {id}...");
            _cache.Add(id, _db.Schedules.FirstOrDefault(s => s.Id == id));
            _schedulesRepository.GetScheduleById(id);
        }
    }
}