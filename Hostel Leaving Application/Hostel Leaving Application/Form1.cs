using MaterialSkin.Controls;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Leaving_Application
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new splash_screen());
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {

            try { 
            String fullname = txtfname.Text;
            String redg = txtredg.Text;
            String branch = selbranch.Text;
            String sem = selsem.Text;
            String dfrom = selfrom.Text;
            String dto = selto.Text;
            String con = txtcon.Text;
            String sub = txtsubject.Text;
            String reason = txtreason.Text;
            String days = seldays.Text;
            String room = txtroom.Text;
            metroLabel10.Text = "To, \r\n     The Hostel Superintendent.\r\n     EATM,BBSR.\r\nSubject :   " + sub + "\r\nSir, \r\n     It is humbly requested that I may be allowed leave from the hostel because (reason) " + reason + ".So I can not present in the Hostel.\r\n\r\n     Therefore, I request you to kindly grant me leave for  " + days + "  day(s) . Leave applied from " + dfrom + "  to " + dto + " then I should be very much grateful to you.\r\n\r\n                                   Yours  Obediently\r\n\r\n                         Full Name: " + fullname + "\r\n                         Branch: " + branch + "\r\n                         Redg No: " + redg + "\r\n                         Semester: " + sem + "\r\n                         Contact No: " + con + "\r\n                         Room No: " + room;
            
                int room1 = int.Parse(room);
            
            if (txtfname.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to FullName!");
                return;
            }
            else if (txtredg.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to Registration No!");
                return;
            }
            else if (txtredg.Text.Length < 10)
            {
                MessageBox.Show("Registration no must be at least 10 characters long.");
                return /*false*/;
            }
            else if (selbranch.Text == string.Empty)
            {
                MessageBox.Show("Please select a value from Branch!");
                return;
            }
            else if (selsem.Text == string.Empty)
            {
                MessageBox.Show("Please select a value from Semester!");
                return;
            }
            else if (selfrom.Text == string.Empty)
            {
                MessageBox.Show("Please select a date from Date!");
                return;
            }
            else if (selto.Text == string.Empty)
            {
                MessageBox.Show("Please select a date from Date!");
                return;
            }
            else if (txtcon.Text == string.Empty)
            {
                MessageBox.Show("Please enter Your Contact No!");
                return;
            }
            else if (txtcon.Text.Length < 10)
            {
                MessageBox.Show("Contact no must be at least 10 characters long.");
                return /*false*/;
            }
            else if (txtsubject.Text == string.Empty)
            {
                MessageBox.Show("Please enter the subject for Leaving hostel!");
                return;
            }
            else if (txtreason.Text == string.Empty)
            {
                MessageBox.Show("Please enter the reason for Leaving Hostel!");
                return;
            }
            else if (seldays.Text == string.Empty)
            {
                MessageBox.Show("Please select a value from Days Your Are Absent!");
                return;
            }
            else if (txtroom.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Room No!");
                return;
            }
            
            
            else
            {
                if ((room1 > 100 && room1 < 130)||(room1>200 && room1<231)||(room1>300 && room1<331))
                {
                    Form3 f3 = new Form3(metroLabel10.Text);
                    this.Hide();
                    f3.ShowDialog();
                }
                else
                    MessageBox.Show("Enter a valid room no");
            }
            }
            catch(Exception se)
            {
                MessageBox.Show("Enter All The Data Items");
            }
        }

        private void txtredg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtroom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}