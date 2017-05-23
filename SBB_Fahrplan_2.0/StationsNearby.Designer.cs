namespace SBB_Fahrplan_2._0
{
    partial class StationsNearby
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendResultsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchStationsButton = new System.Windows.Forms.Button();
            this.stationsDataGridView = new System.Windows.Forms.DataGridView();
            this.stationSearch = new SBB_Fahrplan_2._0.StationSearch();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sendResultsButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchStationsButton);
            this.groupBox1.Controls.Add(this.stationSearch);
            this.groupBox1.Location = new System.Drawing.Point(27, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(872, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // sendResultsButton
            // 
            this.sendResultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendResultsButton.Location = new System.Drawing.Point(296, 97);
            this.sendResultsButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendResultsButton.Name = "sendResultsButton";
            this.sendResultsButton.Size = new System.Drawing.Size(240, 31);
            this.sendResultsButton.TabIndex = 2;
            this.sendResultsButton.Text = "Send Results";
            this.sendResultsButton.UseVisualStyleBackColor = true;
            this.sendResultsButton.Click += new System.EventHandler(this.sendResultsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Place";
            // 
            // searchStationsButton
            // 
            this.searchStationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchStationsButton.Location = new System.Drawing.Point(7, 97);
            this.searchStationsButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchStationsButton.Name = "searchStationsButton";
            this.searchStationsButton.Size = new System.Drawing.Size(240, 31);
            this.searchStationsButton.TabIndex = 1;
            this.searchStationsButton.Text = "Search Stations";
            this.searchStationsButton.UseVisualStyleBackColor = true;
            this.searchStationsButton.Click += new System.EventHandler(this.searchStationsButton_Click);
            // 
            // stationsDataGridView
            // 
            this.stationsDataGridView.AllowUserToAddRows = false;
            this.stationsDataGridView.AllowUserToDeleteRows = false;
            this.stationsDataGridView.AllowUserToOrderColumns = true;
            this.stationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stationsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.stationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationsDataGridView.Location = new System.Drawing.Point(27, 175);
            this.stationsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.stationsDataGridView.Name = "stationsDataGridView";
            this.stationsDataGridView.ReadOnly = true;
            this.stationsDataGridView.RowHeadersVisible = false;
            this.stationsDataGridView.RowTemplate.Height = 28;
            this.stationsDataGridView.Size = new System.Drawing.Size(872, 261);
            this.stationsDataGridView.TabIndex = 3;
            // 
            // stationSearch
            // 
            this.stationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stationSearch.BackColor = System.Drawing.Color.Transparent;
            this.stationSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stationSearch.Location = new System.Drawing.Point(8, 46);
            this.stationSearch.Name = "stationSearch";
            this.stationSearch.Size = new System.Drawing.Size(283, 132);
            this.stationSearch.TabIndex = 0;
            // 
            // StationsNearby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stationsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StationsNearby";
            this.Size = new System.Drawing.Size(927, 455);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchStationsButton;
        private System.Windows.Forms.DataGridView stationsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendResultsButton;
        private StationSearch stationSearch;
    }
}
