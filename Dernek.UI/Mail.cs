using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernek.UI
{
    public partial class Mail : Form
    {
        List<string> toList = new List<string>();
        public Mail()
        {
            InitializeComponent();
        }

        public Mail(List<string> toList)
        {
            InitializeComponent();
            this.toList = toList;
        }

        private void Mail_Load(object sender, EventArgs e)
        {
            tbTo.Text = string.Join(";", toList);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("hurkan520@gmail.com", "secyobgkcxvbdhoi"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("hurkan520@gmail.com"),
                Subject = "Debt Info",
                Body = tbContent.Text,
                IsBodyHtml = true,
            };

            string[] arr = tbTo.Text.Split(';');

            foreach(string str in arr)
            {
                mailMessage.To.Add(str);
            }

            smtpClient.Send(mailMessage);

            MessageBox.Show("Mail Sent!");
            this.Close();
        }

        private void tbTo_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbTo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTo, "Required");
            }
            else
            {
                errorProvider1.SetError(tbTo, "");
            }
        }

        private void tbContent_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbContent.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbContent, "Required");
            }
            else
            {
                errorProvider1.SetError(tbContent, "");
            }
        }
    }
}
