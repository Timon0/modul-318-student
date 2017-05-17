using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using SwissTransport;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBB_Fahrplan_2._0
{
    public partial class StandardTimetable : UserControl
    {
        private Transport transport = new Transport();

        public StandardTimetable()
        {
            InitializeComponent();
            fromComboBox.Focus();
        }

        private void stationSearch_TextChanged(object sender, EventArgs e)
        {
            StationSearchHelper.searchStation((ComboBox)sender);
        }

        private void searchConnectionButton_Click(object sender, EventArgs e)
        {
            ConnectionConverter connectionKonverter = new ConnectionConverter();
            var connections = transport.GetConnections(fromComboBox.Text, toComboBox.Text);
            BindingList<ConnectionRow> connectionRows = new BindingList<ConnectionRow>();
            foreach (Connection connection in connections.ConnectionList)
            {
                ConnectionRow connectionRow = new ConnectionRow();
                connectionRow = connectionKonverter.toConnectionRow(connection);
                connectionRows.Add(connectionRow);
            }

            timetableDataGridView.DataSource = connectionRows;
            timetableDataGridView.Columns["Departure"].DefaultCellStyle.Format = "HH:mm";
            timetableDataGridView.Columns["Arrival"].DefaultCellStyle.Format = "HH:mm";
            timetableDataGridView.Columns["Duration"].DefaultCellStyle.Format = "hh\\:mm";
            timetableDataGridView.Visible = true;


        }
    }
}
