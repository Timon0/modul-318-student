namespace SBB_Fahrplan_2._0
{
    partial class OverviewForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.standardTimetableButton = new System.Windows.Forms.Button();
            this.stationFahrplanButton = new System.Windows.Forms.Button();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.searchStationsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // standardTimetableButton
            // 
            this.standardTimetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standardTimetableButton.Location = new System.Drawing.Point(254, 21);
            this.standardTimetableButton.Name = "standardTimetableButton";
            this.standardTimetableButton.Size = new System.Drawing.Size(247, 88);
            this.standardTimetableButton.TabIndex = 0;
            this.standardTimetableButton.Text = "Standard Timetable";
            this.standardTimetableButton.UseVisualStyleBackColor = true;
            this.standardTimetableButton.Click += new System.EventHandler(this.standardTimetableButton_Click);
            // 
            // stationFahrplanButton
            // 
            this.stationFahrplanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stationFahrplanButton.Location = new System.Drawing.Point(531, 21);
            this.stationFahrplanButton.Name = "stationFahrplanButton";
            this.stationFahrplanButton.Size = new System.Drawing.Size(247, 88);
            this.stationFahrplanButton.TabIndex = 1;
            this.stationFahrplanButton.Text = "Timetable from a station";
            this.stationFahrplanButton.UseVisualStyleBackColor = true;
            this.stationFahrplanButton.Click += new System.EventHandler(this.stationTimetableButton_Click);
            // 
            // userControlPanel
            // 
            this.userControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlPanel.Location = new System.Drawing.Point(-8, 136);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(1390, 700);
            this.userControlPanel.TabIndex = 2;
            // 
            // searchStationsButton
            // 
            this.searchStationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchStationsButton.Location = new System.Drawing.Point(804, 21);
            this.searchStationsButton.Name = "searchStationsButton";
            this.searchStationsButton.Size = new System.Drawing.Size(247, 88);
            this.searchStationsButton.TabIndex = 3;
            this.searchStationsButton.Text = "Search stations nearby";
            this.searchStationsButton.UseVisualStyleBackColor = true;
            this.searchStationsButton.Click += new System.EventHandler(this.searchStationsButton_Click);
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 838);
            this.Controls.Add(this.searchStationsButton);
            this.Controls.Add(this.userControlPanel);
            this.Controls.Add(this.stationFahrplanButton);
            this.Controls.Add(this.standardTimetableButton);
            this.Name = "OverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SBB Timetable 2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button standardTimetableButton;
        private System.Windows.Forms.Button stationFahrplanButton;
        private System.Windows.Forms.Panel userControlPanel;
        private System.Windows.Forms.Button searchStationsButton;
    }
}

