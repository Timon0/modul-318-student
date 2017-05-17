using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace SBB_Fahrplan_2._0
{
    class StationSearchHelper
    {
        private static Transport transport = new Transport();
        public static void searchStation(ComboBox comboBox)
        {
            comboBox.DroppedDown = true;
            comboBox.Select(comboBox.Text.Length, 0);
            if (comboBox.Text.Length > 3)
            {
                var stations = transport.GetStations(comboBox.Text);
                if(stations == null)
                {
                    return;
                }
                foreach (var station in stations.StationList)
                {
                    comboBox.Items.Add(station.Name);
                }

            }
        }

        public static bool stationExsits(String stationName)
        {
            var stations = transport.GetStations(stationName);
            if(stations == null)
            {
                return false;
            }
            foreach(var station in stations.StationList)
            {
                if(station.Name == stationName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
