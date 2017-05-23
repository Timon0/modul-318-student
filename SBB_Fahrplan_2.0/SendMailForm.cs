using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBB_Fahrplan_2._0
{
    public partial class SendMailForm : Form
    {
        private string email = "sbbfahrplan2.0@gmail.com";
        private string mailPassword = "fahrplansbb";
        private string text = "";

        public SendMailForm(DataGridView dataGridView)
        {
            InitializeComponent();
            if (!dataGridViewisEmpty(dataGridView))
            {
                return;
            }
            this.text = getTextFromDataGridView(dataGridView);
            this.Show();
        }

        private bool dataGridViewisEmpty(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("You have to search fist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            if (!validateInput())
            {
                return;
            }

            var mailClient = new SmtpClient("smtp.gmail.com");
            mailClient.Port = 25;
            mailClient.EnableSsl = true;
            mailClient.UseDefaultCredentials = false;
            var msgMail = new MailMessage();
            msgMail.From = new MailAddress(email);
            msgMail.To.Add(new MailAddress(toTextBox.Text));
            msgMail.Subject = "SBB Fahrplan 2.0";
            msgMail.Body = text;
            msgMail.IsBodyHtml = true;

            try
            {
                mailClient.Credentials = new System.Net.NetworkCredential(email, mailPassword);
                mailClient.EnableSsl = true;
                mailClient.Send(msgMail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            msgMail.Dispose();
            this.Close();
        }

        private bool validateInput()
        {
            var errors = "";
       
            if (!(toTextBox.Text.Contains('@') && toTextBox.Text.Contains('.')))
            {
                errors += "Not valid recipient!";
            }

            if(errors.Length > 0)
            {
                MessageBox.Show(errors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private String getTextFromDataGridView(DataGridView dataGridView)
        {
            var text = "";
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView.Rows[i];
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    text += row.Cells[j].Value.ToString();
                }
                text += "\n";
            }
            return text;
        }
    }
}
