namespace SBB_Fahrplan_2._0
{
    partial class StandardTimetable
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
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.searchConnectionButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromStationSearch = new SBB_Fahrplan_2._0.StationSearch();
            this.toStationSearch = new SBB_Fahrplan_2._0.StationSearch();
            this.timetableDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.timePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.searchConnectionButton);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fromStationSearch);
            this.groupBox1.Controls.Add(this.toStationSearch);
            this.groupBox1.Location = new System.Drawing.Point(41, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // timePicker
            // 
            this.timePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(444, 128);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(360, 26);
            this.timePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time";
            // 
            // searchConnectionButton
            // 
            this.searchConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchConnectionButton.Location = new System.Drawing.Point(13, 215);
            this.searchConnectionButton.Name = "searchConnectionButton";
            this.searchConnectionButton.Size = new System.Drawing.Size(360, 48);
            this.searchConnectionButton.TabIndex = 4;
            this.searchConnectionButton.Text = "Search connection";
            this.searchConnectionButton.UseVisualStyleBackColor = true;
            this.searchConnectionButton.Click += new System.EventHandler(this.searchConnectionButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(13, 128);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(360, 26);
            this.datePicker.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // fromStationSearch
            // 
            this.fromStationSearch.BackColor = System.Drawing.Color.Transparent;
            this.fromStationSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fromStationSearch.Location = new System.Drawing.Point(11, 60);
            this.fromStationSearch.Name = "fromStationSearch";
            this.fromStationSearch.Size = new System.Drawing.Size(423, 203);
            this.fromStationSearch.TabIndex = 0;
            // 
            // toStationSearch
            // 
            this.toStationSearch.BackColor = System.Drawing.Color.Transparent;
            this.toStationSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toStationSearch.Location = new System.Drawing.Point(444, 60);
            this.toStationSearch.Name = "toStationSearch";
            this.toStationSearch.Size = new System.Drawing.Size(423, 203);
            this.toStationSearch.TabIndex = 1;
            // 
            // timetableDataGridView
            // 
            this.timetableDataGridView.AllowUserToAddRows = false;
            this.timetableDataGridView.AllowUserToDeleteRows = false;
            this.timetableDataGridView.AllowUserToOrderColumns = true;
            this.timetableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timetableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timetableDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.timetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableDataGridView.Location = new System.Drawing.Point(41, 333);
            this.timetableDataGridView.Name = "timetableDataGridView";
            this.timetableDataGridView.ReadOnly = true;
            this.timetableDataGridView.RowHeadersVisible = false;
            this.timetableDataGridView.RowTemplate.Height = 28;
            this.timetableDataGridView.Size = new System.Drawing.Size(1308, 341);
            this.timetableDataGridView.TabIndex = 5;
            // 
            // StandardTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.timetableDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "StandardTimetable";
            this.Size = new System.Drawing.Size(1390, 700);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridView timetableDataGridView;
        private System.Windows.Forms.Button searchConnectionButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timePicker;
        private StationSearch fromStationSearch;
        private StationSearch toStationSearch;
    }
}
