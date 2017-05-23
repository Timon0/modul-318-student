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
        /// <summary>
        /// Converts the Station object into a StationsNearbsRow object.
        /// </summary>
        /// <param name="station">The Station witch needs to be converted.</param>
        /// <returns>The new StationsNearbyRow</returns>
        public StationsNearbyRow toStationsNearbyRow(Station station)
        {
            if(station == null)
            {
                return null;
            }

            var stationNearbyRow = new StationsNearbyRow();

            stationNearbyRow.Station = station.Name;
            stationNearbyRow.Distance = station.Distance;

            return stationNearbyRow;
        }
    }
}
