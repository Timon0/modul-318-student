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

        public StationBoardRow toStationBoardRow(StationBoard stationBoard) 
        {
            StationBoardRow stationBoardRow = new StationBoardRow();

            stationBoardRow.From = stationBoard.Stop.Station.Name;
            stationBoardRow.To = stationBoard.To;
            stationBoardRow.Departure = stationBoard.Stop.Departure;

            return stationBoardRow;
        }
    }
}
