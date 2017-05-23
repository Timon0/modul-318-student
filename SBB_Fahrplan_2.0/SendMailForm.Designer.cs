namespace SBB_Fahrplan_2._0
{
    partial class SendMailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(19, 44);
            this.toTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(188, 20);
            this.toTextBox.TabIndex = 1;
            // 
            // sendMailButton
            // 
            this.sendMailButton.Location = new System.Drawing.Point(19, 100);
            this.sendMailButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(187, 41);
            this.sendMailButton.TabIndex = 2;
            this.sendMailButton.Text = "Send Mail";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // SendMailForm
            // 
            this.AcceptButton = this.sendMailButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 167);
            this.Controls.Add(this.sendMailButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SendMailForm";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button sendMailButton;
    }
}