using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Globalization;

namespace SBB_Fahrplan_2._0
{
    class ConnectionConverter
    {
        public ConnectionRow toConnectionRow(Connection connection)
        {
            ConnectionRow connectionRow = new ConnectionRow();

            connectionRow.From = connection.From.Station.Name;
            connectionRow.To = connection.To.Station.Name;
            connectionRow.Departure = DateTime.Parse(connection.From.Departure);
            connectionRow.Arrival = DateTime.Parse(connection.To.Arrival);
            connectionRow.Duration = connectionRow.Arrival - connectionRow.Departure;

            return connectionRow;
        }
    }
}
