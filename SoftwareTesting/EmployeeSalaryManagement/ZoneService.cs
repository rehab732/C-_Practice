using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryManagement
{
    public class ZoneService:IZoneService
    {
        private static Random random = new Random();
        public bool IsDangerZone(string dutyStation)
        {
            return random.Next(1, 10) == 3;
        }
    }
}
