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
        private Transport transport = new Transport();
        public StationTimetable()
        {
            InitializeComponent();
            stationComboBox.Focus();
        }

        private void stationSearch_TextChanged(object sender, EventArgs e)
        {
            StationSearchHelper.searchStation((ComboBox)sender);
        }

        private void searchConnectionButton_Click(object sender, EventArgs e)
        {
            if (!StationSearchHelper.stationExsits(stationComboBox.Text))
            {
                MessageBox.Show("Die Station wurde nicht gefunden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stations = transport.GetStations(stationComboBox.Text);
            foreach(Station station in stations.StationList)
            {
                if(station.Name == stationComboBox.Text)
                {
                    var stationsBoards = transport.GetStationBoard(station.Name, station.Id);
                    BindingList<StationBoardRow> stationBoardRows = new BindingList<StationBoardRow>();
                    StationBoardConverter stationBoardConverter = new StationBoardConverter();
                    foreach(StationBoard stationBoard in stationsBoards.Entries)
                    {
                        stationBoardRows.Add(stationBoardConverter.toStationBoardRow(stationBoard));
                    }
                    timetableDataGridView.DataSource = stationBoardRows;
                    timetableDataGridView.Columns["Departure"].DefaultCellStyle.Format = "HH:mm";
                }
            }
        }
    }
}
