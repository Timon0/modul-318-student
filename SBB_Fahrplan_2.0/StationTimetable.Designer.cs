namespace SBB_Fahrplan_2._0
{
    partial class StationTimetable
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
            this.searchConnectionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timetableDataGridView = new System.Windows.Forms.DataGridView();
            this.stationSearch = new SBB_Fahrplan_2._0.StationSearch();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.searchConnectionButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stationSearch);
            this.groupBox1.Location = new System.Drawing.Point(41, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // searchConnectionButton
            // 
            this.searchConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchConnectionButton.Location = new System.Drawing.Point(11, 150);
            this.searchConnectionButton.Name = "searchConnectionButton";
            this.searchConnectionButton.Size = new System.Drawing.Size(360, 48);
            this.searchConnectionButton.TabIndex = 2;
            this.searchConnectionButton.Text = "Search Connection";
            this.searchConnectionButton.UseVisualStyleBackColor = true;
            this.searchConnectionButton.Click += new System.EventHandler(this.searchConnectionButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Station";
            // 
            // timetableDataGridView
            // 
            this.timetableDataGridView.AllowUserToAddRows = false;
            this.timetableDataGridView.AllowUserToDeleteRows = false;
            this.timetableDataGridView.AllowUserToOrderColumns = true;
            this.timetableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timetableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timetableDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.timetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableDataGridView.Location = new System.Drawing.Point(41, 269);
            this.timetableDataGridView.Name = "timetableDataGridView";
            this.timetableDataGridView.ReadOnly = true;
            this.timetableDataGridView.RowHeadersVisible = false;
            this.timetableDataGridView.RowTemplate.Height = 28;
            this.timetableDataGridView.Size = new System.Drawing.Size(1308, 402);
            this.timetableDataGridView.TabIndex = 3;
            // 
            // stationSearch
            // 
            this.stationSearch.BackColor = System.Drawing.Color.Transparent;
            this.stationSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stationSearch.Location = new System.Drawing.Point(11, 60);
            this.stationSearch.Name = "stationSearch";
            this.stationSearch.Size = new System.Drawing.Size(423, 203);
            this.stationSearch.TabIndex = 3;
            // 
            // StationTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timetableDataGridView);
            this.Name = "StationTimetable";
            this.Size = new System.Drawing.Size(1390, 700);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchConnectionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView timetableDataGridView;
        private StationSearch stationSearch;
    }
}
