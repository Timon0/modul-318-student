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
        /// <summary>
        /// Converts the Connection object into a ConnectionRow object.
        /// </summary>
        /// <param name="connection">The Connection object which needs to be converted.</param>
        /// <returns>The ConnectionRow object</returns>
        public ConnectionRow toConnectionRow(Connection connection)
        {
            if(connection == null)
            {
                return null;
            }
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
