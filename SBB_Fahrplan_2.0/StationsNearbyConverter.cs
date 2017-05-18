using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwissTransport;
using System.Threading.Tasks;

namespace SBB_Fahrplan_2._0
{
    class StationsNearbyConverter
    {
        public StationsNearbyRow toStationsNearbyRow(Station station)
        {
            if(station == null)
            {
                return null;
            }

            StationsNearbyRow stationNearbyRow = new StationsNearbyRow();

            stationNearbyRow.Station = station.Name;
            stationNearbyRow.Distance = station.Distance;

            return stationNearbyRow;
        }
    }
}
