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

        public SendMailForm()
        {
            InitializeComponent();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            if (!validateInput())
            {
                return;
            }

            //string Text = "Test E-Mail von SBB Fahrplan 2.0";
            //SmtpClient mailClient = new SmtpClient("smtp.live.com");
            //mailClient.Port = 25;
            //mailClient.EnableSsl = true;
            //mailClient.UseDefaultCredentials = false;
            //MailMessage msgMail = new MailMessage();
            //msgMail.From = new MailAddress(email);
            //msgMail.To.Add(new MailAddress(toTextBox.Text));
            //msgMail.Subject = "SBB Fahrplan 2.0";
            //msgMail.Body = Text;
            //msgMail.IsBodyHtml = true;

            //try
            //{
            //    mailClient.Credentials = new System.Net.NetworkCredential(email, password);
            //    mailClient.EnableSsl = true;
            //    mailClient.Send(msgMail);
            //} catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //msgMail.Dispose();
        }

        private bool validateInput()
        {
            string errors = "";
            if(!(fromTextBox.Text.Contains('@') && fromTextBox.Text.Contains('.')))
            {
                errors += "Not valid Sender!";
            }

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
    }
}
