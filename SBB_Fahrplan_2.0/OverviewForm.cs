using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBB_Fahrplan_2._0
{
    public partial class OverviewForm : Form
    { 

        public OverviewForm()
        {
            InitializeComponent();
        }

        private void standardTimetableButton_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Clear();
            var standardTimetable = new StandardTimetable();
            standardTimetable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AcceptButton = standardTimetable.AcceptButton;
            userControlPanel.Controls.Add(standardTimetable);
        }

        private void stationTimetableButton_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Clear();
            var stationTimetable = new StationTimetable();
            stationTimetable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AcceptButton = stationTimetable.AcceptButton;
            userControlPanel.Controls.Add(stationTimetable);
        }

        private void searchStationsButton_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Clear();
            var stationsNearby = new StationsNearby();
            stationsNearby.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AcceptButton = stationsNearby.AcceptButton;
            userControlPanel.Controls.Add(stationsNearby);
        }

        private void OverviewForm_Load(object sender, EventArgs e)
        {
            standardTimetableButton.PerformClick();
        }
    }
}
