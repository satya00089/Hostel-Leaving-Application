using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Hostel_Leaving_Application
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();            
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = " Word Document |*.docx| Word 97-2004 Document |*.doc ", ValidateNames = true })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtattachment.Text = ofd.FileName.ToString();
                }
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com",587);
                message.From =new MailAddress (txtemail.Text);
                message.To.Add(txtreciever.Text);
                message.Body = txtbody.Text;
                message.Subject = txtsubject.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;          
                if(txtattachment.Text!="")
                {
                    message.Attachments.Add(new Attachment(txtattachment.Text));

                }
               
                client.Credentials = new System.Net.NetworkCredential(txtemail.Text, txtpassword.Text);
                client.Send(message);
                message = null;

                MessageBox.Show("Message Sent");
            }
            catch(Exception s)
            {
                MessageBox.Show("Failed to Send Message");
            }
        }

        
    }
}
