﻿namespace SBB_Fahrplan_2._0
{
    partial class StationSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationSearch));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.suggestionListBox = new System.Windows.Forms.ListBox();
            this.showStationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(240, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // suggestionListBox
            // 
            this.suggestionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suggestionListBox.FormattingEnabled = true;
            this.suggestionListBox.Location = new System.Drawing.Point(0, 20);
            this.suggestionListBox.Name = "suggestionListBox";
            this.suggestionListBox.Size = new System.Drawing.Size(240, 108);
            this.suggestionListBox.TabIndex = 1;
            this.suggestionListBox.TabStop = false;
            this.suggestionListBox.Visible = false;
            this.suggestionListBox.VisibleChanged += new System.EventHandler(this.suggestionListBox_VisibleChanged);
            this.suggestionListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.suggestionListBox_KeyDown);
            this.suggestionListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.suggestionListBox_MouseDoubleClick);
            // 
            // showStationButton
            // 
            this.showStationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showStationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showStationButton.Image = ((System.Drawing.Image)(resources.GetObject("showStationButton.Image")));
            this.showStationButton.Location = new System.Drawing.Point(246, 0);
            this.showStationButton.Name = "showStationButton";
            this.showStationButton.Size = new System.Drawing.Size(37, 44);
            this.showStationButton.TabIndex = 2;
            this.showStationButton.TabStop = false;
            this.showStationButton.UseVisualStyleBackColor = true;
            this.showStationButton.Click += new System.EventHandler(this.showStationButton_Click);
            // 
            // StationSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.showStationButton);
            this.Controls.Add(this.suggestionListBox);
            this.Controls.Add(this.searchTextBox);
            this.Name = "StationSearch";
            this.Size = new System.Drawing.Size(283, 132);
            this.Leave += new System.EventHandler(this.StationSearch_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox suggestionListBox;
        private System.Windows.Forms.Button showStationButton;
    }
}
