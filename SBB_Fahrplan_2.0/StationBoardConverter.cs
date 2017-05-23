using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwissTransport;
using System.Threading.Tasks;

namespace SBB_Fahrplan_2._0
{
    class StationBoardConverter
    {
        /// <summary>
        /// Converts a StationBoard object into a StationBoardRow.
        /// </summary>
        /// <param name="stationBoard">The StationBoard object wich need to be converted.</param>
        /// <returns>StationBoardRow object</returns>
        public StationBoardRow toStationBoardRow(StationBoard stationBoard) 
        {
            if(stationBoard == null)
            {
                return null;
            }

            StationBoardRow stationBoardRow = new StationBoardRow();

            stationBoardRow.From = stationBoard.Stop.Station.Name;
            stationBoardRow.To = stationBoard.To;
            stationBoardRow.Departure = stationBoard.Stop.Departure;

            return stationBoardRow;
        }
    }
}
