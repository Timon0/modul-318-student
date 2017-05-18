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
    public partial class StationSearch : UserControl
    {
        private Transport transport = new Transport();
        public StationSearch()
        {
            InitializeComponent();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length > 3)
            {
                var stations = transport.GetStations(searchTextBox.Text);
                if (stations == null)
                {
                    return;
                }
                suggestionListBox.Items.Clear();
                foreach (var station in stations.StationList)
                {
                    suggestionListBox.Items.Add(station.Name);
                }
                suggestionListBox.Visible = true;
                this.BringToFront();
                return;
            }
            this.SendToBack();
            suggestionListBox.Visible = false;
        }

        private void setListBoxSize()
        {
            if(suggestionListBox.Items.Count > 10)
            {
                suggestionListBox.Height = 100;
            }
            else
            {
                suggestionListBox.Height = suggestionListBox.Items.Count * 5;
            }
        }

        public bool isValidStation()
        {
            var stations = transport.GetStations(searchTextBox.Text);
            if (stations == null)
            {
                return false;
            }
            foreach (var station in stations.StationList)
            {
                if (station.Name == searchTextBox.Text)
                {
                    return true;
                }
            }
            return false;
        }

        public String getStation()
        {
            return searchTextBox.Text;
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                if(suggestionListBox.Visible == true)
                {
                    suggestionListBox.SelectedIndex = 0;
                    suggestionListBox.Focus();
                }
            }
        }

        private void suggestionListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(suggestionListBox.SelectedItem != null)
                {
                    selectItem();
                }
            }
        }

        private void suggestionListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(suggestionListBox.SelectedItem != null)
            {
                selectItem();
            }
        }

        private void selectItem()
        {
            searchTextBox.Text = suggestionListBox.SelectedItem.ToString();
            suggestionListBox.Visible = false;
            this.SendToBack();
        }
    }
}