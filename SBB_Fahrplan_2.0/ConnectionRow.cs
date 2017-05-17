using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBB_Fahrplan_2._0
{
    class ConnectionRow
    {
        public String From { get; set; }
        public String To { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
