using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solution.db
{
    public class SimulatedDB
    {
        public List<dynamic> Schedules { get; set; }

        public SimulatedDB()
        {
            Schedules = new List<dynamic>()
            {
                new { Id = 1, Name = "Schedule 1" },
                new { Id = 2, Name = "Schedule 2" },
                new { Id = 3, Name = "Schedule 3" }
            };
        }
    }
}