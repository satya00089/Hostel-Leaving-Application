namespace Hostel_Leaving_Application
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtbody = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(540, 284);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(87, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Save | Next";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtbody
            // 
            // 
            // 
            // 
            this.txtbody.CustomButton.Image = null;
            this.txtbody.CustomButton.Location = new System.Drawing.Point(390, 1);
            this.txtbody.CustomButton.Name = "";
            this.txtbody.CustomButton.Size = new System.Drawing.Size(213, 213);
            this.txtbody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbody.CustomButton.TabIndex = 1;
            this.txtbody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbody.CustomButton.UseSelectable = true;
            this.txtbody.CustomButton.Visible = false;
            this.txtbody.Lines = new string[0];
            this.txtbody.Location = new System.Drawing.Point(23, 63);
            this.txtbody.MaxLength = 32767;
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.PasswordChar = '\0';
            this.txtbody.ReadOnly = true;
            this.txtbody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbody.SelectedText = "";
            this.txtbody.SelectionLength = 0;
            this.txtbody.SelectionStart = 0;
            this.txtbody.ShortcutsEnabled = true;
            this.txtbody.Size = new System.Drawing.Size(604, 215);
            this.txtbody.TabIndex = 2;
            this.txtbody.UseSelectable = true;
            this.txtbody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 330);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 330);
            this.MinimumSize = new System.Drawing.Size(650, 330);
            this.Name = "Form3";
            this.Text = "Hostel Leaving Application";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroTextBox txtbody;
    }
}