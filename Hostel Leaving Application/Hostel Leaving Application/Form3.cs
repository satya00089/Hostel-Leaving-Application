using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hostel_Leaving_Application
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3(string sa)
        {
            InitializeComponent();
            txtbody.Text = sa;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            SaveFileDialog savefile = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            string fn = saveFileDialog1.FileName;
            FileStream fs = new FileStream(fn, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(txtbody.Text);
            sw.Close();

            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
           
        }

       
    }
}
