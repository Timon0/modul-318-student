﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace SBB_Fahrplan_2._0
{
    public partial class StationTimetable : UserControl
    {
        public Button AcceptButton
        {
            get { return searchConnectionButton; }
        }

        private Transport transport = new Transport();
        public StationTimetable()
        {
            InitializeComponent();
            stationSearch.Focus();
        }

        private void searchConnectionButton_Click(object sender, EventArgs e)
        {
            if (!stationSearch.isValidStation())
            {
                MessageBox.Show("Station not found.", "Validationerror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var station = stationSearch.getStation();
            var stationsBoards = transport.GetStationBoard(station.Name, station.Id);
            var stationBoardRows = new BindingList<StationBoardRow>();
            var stationBoardConverter = new StationBoardConverter();
            foreach(StationBoard stationBoard in stationsBoards.Entries)
            {
                stationBoardRows.Add(stationBoardConverter.toStationBoardRow(stationBoard));
            }
            timetableDataGridView.DataSource = stationBoardRows;
            timetableDataGridView.Columns["Departure"].DefaultCellStyle.Format = "HH:mm";
        }

        private void sendResultsButton_Click(object sender, EventArgs e)
        {
            var sendMailForm = new SendMailForm(timetableDataGridView);
        }
    }
}

