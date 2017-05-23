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
        public StationsNearby()
        {
            InitializeComponent();
        }

        private void searchStationsButton_Click(object sender, EventArgs e)
        {
            if (!stationSearch.isValidStation())
            {
                MessageBox.Show("Station not found!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Transport tranport = new Transport();
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            numberFormatInfo.NumberDecimalSeparator = ".";

            Station station = stationSearch.getStation();

            var stations = tranport.GetStationsNearby(station.Coordinate.XCoordinate.ToString(numberFormatInfo), station.Coordinate.YCoordinate.ToString(numberFormatInfo));
            BindingList<StationsNearbyRow> stationsNearbyRows = new BindingList<StationsNearbyRow>();
            StationsNearbyConverter converter = new StationsNearbyConverter();

            foreach (Station stationNearby in stations.StationList)
            {
                stationsNearbyRows.Add(converter.toStationsNearbyRow(stationNearby));
            }

            stationsDataGridView.DataSource = stationsNearbyRows;
        }

        private void sendResultsButton_Click(object sender, EventArgs e)
        {
            SendMailForm sendMailForm = new SendMailForm(stationsDataGridView);
        }
    }
}
