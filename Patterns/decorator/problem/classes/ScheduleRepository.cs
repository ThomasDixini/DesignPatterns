using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.db;

namespace problem.classes
{
    public class ScheduleRepository
    {
        private readonly SimulatedDB _db = new SimulatedDB();
        private readonly Dictionary<int, dynamic> _cache = new();

        public dynamic GetById(int id)
        {
            if (_cache.ContainsKey(id))
            {
                Console.WriteLine($"[CACHE] Retrieving from cache: {id}");
                return _cache[id];
            }

            Console.WriteLine($"[LOG] Searching for schedule {id} in the database...");
            
            var agendamento = _db.Schedules.FirstOrDefault(s => s.Id == id);

            Console.WriteLine($"[LOG] Schedule found: {agendamento?.Id}");

            if (agendamento != null)
                _cache[id] = agendamento;

            return agendamento;
        }
    }
}