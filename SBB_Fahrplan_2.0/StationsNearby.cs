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
            if (!validateInput())
            {
                return;
            }
            Transport tranport = new Transport();
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            numberFormatInfo.NumberDecimalSeparator = ".";

            var stations = tranport.GetStationsNearby(latitude.ToString(numberFormatInfo), longtitude.ToString(numberFormatInfo));
            BindingList<StationsNearbyRow> stationsNearbyRows = new BindingList<StationsNearbyRow>();
            StationsNearbyConverter converter = new StationsNearbyConverter();

            foreach(Station station in stations.StationList)
            {
                stationsNearbyRows.Add(converter.toStationsNearbyRow(station));
            }

            stationsDataGridView.DataSource = stationsNearbyRows;
        }

        private bool validateInput()
        {
            string errors = "";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            numberFormatInfo.NumberDecimalSeparator = ".";

            if (!Double.TryParse(longtitudeTextBox.Text, NumberStyles.Number, numberFormatInfo, out longtitude))
            {
                errors += "Longtitude value is invalid!\n";
            }

            if (!Double.TryParse(latitudeTextBox.Text, NumberStyles.Number, numberFormatInfo, out latitude))
            {
                errors += "Latitude value is invalid!\n";
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
