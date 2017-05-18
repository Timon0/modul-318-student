using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;
using System.Globalization;

namespace SBB_Fahrplan_2._0
{
    public partial class StationsNearby : UserControl
    {
        private double longtitude;
        private double latitude;
       
        public StationsNearby()
        {
            InitializeComponent();
        }

        private void searchStationsButton_Click(object sender, EventArgs e)
        {
            if (!stationSearch.isValidStation())
            {
                return;
            }
            Transport tranport = new Transport();
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            numberFormatInfo.NumberDecimalSeparator = ".";

            var stations = tranport.GetStationsNearby(stationSearch.getStation().Coordinate.XCoordinate.ToString(numberFormatInfo), stationSearch.getStation().Coordinate.YCoordinate.ToString(numberFormatInfo));
            BindingList<StationsNearbyRow> stationsNearbyRows = new BindingList<StationsNearbyRow>();
            StationsNearbyConverter converter = new StationsNearbyConverter();

            foreach (Station station in stations.StationList)
            {
                stationsNearbyRows.Add(converter.toStationsNearbyRow(station));
            }

            stationsDataGridView.DataSource = stationsNearbyRows;
        }
      
    }
}
