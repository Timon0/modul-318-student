﻿using System;
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

        public Button AcceptButton
        {
            get { return this.searchConnectionButton; }
        }

        private Transport transport = new Transport();

        public StandardTimetable()
        {
            InitializeComponent();
            datePicker.MinDate = DateTime.Today;
            fromStationSearch.Focus();
        }

        private void searchConnectionButton_Click(object sender, EventArgs e)
        {
            if (!validateInput())
            {
                return;
            }

            int isArrivalTime = 0;
            if (arrivalRadioButton.Checked)
            {
                isArrivalTime = 1;
            }
            
            var connectionKonverter = new ConnectionConverter();
            var connections = transport.GetConnections(fromStationSearch.getStationName(), toStationSearch.getStationName(), datePicker.Value, timePicker.Value, isArrivalTime);
            var connectionRows = new BindingList<ConnectionRow>();
            foreach (Connection connection in connections.ConnectionList)
            {
                var connectionRow = new ConnectionRow();
                connectionRow = connectionKonverter.toConnectionRow(connection);
                connectionRows.Add(connectionRow);
            }

            timetableDataGridView.DataSource = connectionRows;
            timetableDataGridView.Columns["Departure"].DefaultCellStyle.Format = "HH:mm";
            timetableDataGridView.Columns["Arrival"].DefaultCellStyle.Format = "HH:mm";
            timetableDataGridView.Columns["Duration"].DefaultCellStyle.Format = "hh\\:mm";
            timetableDataGridView.Visible = true;


        }

        private bool validateInput()
        {
            var errors = "";
            if (!fromStationSearch.isValidStation())
            {
                errors += "Departurestation not found!\n";
            }
            if (!toStationSearch.isValidStation())
            {
                errors += "Arrivalstation not found!\n";
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors, "Validationerror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void sendResultsButton_Click(object sender, EventArgs e)
        {
            var sendMailForm = new SendMailForm(timetableDataGridView);
        }
        private void StandardTimetable_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchConnectionButton.PerformClick();
            }
        }
    }
}
