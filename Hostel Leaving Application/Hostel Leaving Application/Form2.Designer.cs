namespace Hostel_Leaving_Application
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtemail = new MetroFramework.Controls.MetroTextBox();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.txtreciever = new MetroFramework.Controls.MetroTextBox();
            this.txtattachment = new MetroFramework.Controls.MetroTextBox();
            this.txtsubject = new MetroFramework.Controls.MetroTextBox();
            this.btnbrowse = new MetroFramework.Controls.MetroButton();
            this.btnsend = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtbody = new MetroFramework.Controls.MetroTextBox();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(149, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Enter Your E-MAIL ID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(406, 76);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(149, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Enter Your Password";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(110, 200);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Message";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(121, 170);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(59, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Subject";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 110);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(168, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Enter Reciever\'s E-MAIL";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(63, 139);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(117, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Add Attachment";
            // 
            // txtemail
            // 
            // 
            // 
            // 
            this.txtemail.CustomButton.Image = null;
            this.txtemail.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtemail.CustomButton.Name = "";
            this.txtemail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtemail.CustomButton.TabIndex = 1;
            this.txtemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtemail.CustomButton.UseSelectable = true;
            this.txtemail.CustomButton.Visible = false;
            this.txtemail.Lines = new string[0];
            this.txtemail.Location = new System.Drawing.Point(195, 76);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(205, 23);
            this.txtemail.TabIndex = 6;
            this.txtemail.UseSelectable = true;
            this.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.CustomButton.Image = null;
            this.txtpassword.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtpassword.CustomButton.Name = "";
            this.txtpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.CustomButton.TabIndex = 1;
            this.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassword.CustomButton.UseSelectable = true;
            this.txtpassword.CustomButton.Visible = false;
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(561, 76);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(177, 23);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtreciever
            // 
            // 
            // 
            // 
            this.txtreciever.CustomButton.Image = null;
            this.txtreciever.CustomButton.Location = new System.Drawing.Point(521, 1);
            this.txtreciever.CustomButton.Name = "";
            this.txtreciever.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtreciever.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtreciever.CustomButton.TabIndex = 1;
            this.txtreciever.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtreciever.CustomButton.UseSelectable = true;
            this.txtreciever.CustomButton.Visible = false;
            this.txtreciever.Lines = new string[0];
            this.txtreciever.Location = new System.Drawing.Point(195, 106);
            this.txtreciever.MaxLength = 32767;
            this.txtreciever.Name = "txtreciever";
            this.txtreciever.PasswordChar = '\0';
            this.txtreciever.PromptText = "arupa_2007@yahoo.com";
            this.txtreciever.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtreciever.SelectedText = "";
            this.txtreciever.SelectionLength = 0;
            this.txtreciever.SelectionStart = 0;
            this.txtreciever.ShortcutsEnabled = true;
            this.txtreciever.Size = new System.Drawing.Size(543, 23);
            this.txtreciever.TabIndex = 8;
            this.txtreciever.UseSelectable = true;
            this.txtreciever.WaterMark = "arupa_2007@yahoo.com";
            this.txtreciever.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtreciever.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtattachment
            // 
            // 
            // 
            // 
            this.txtattachment.CustomButton.Image = null;
            this.txtattachment.CustomButton.Location = new System.Drawing.Point(440, 1);
            this.txtattachment.CustomButton.Name = "";
            this.txtattachment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtattachment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtattachment.CustomButton.TabIndex = 1;
            this.txtattachment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtattachment.CustomButton.UseSelectable = true;
            this.txtattachment.CustomButton.Visible = false;
            this.txtattachment.Lines = new string[0];
            this.txtattachment.Location = new System.Drawing.Point(195, 135);
            this.txtattachment.MaxLength = 32767;
            this.txtattachment.Name = "txtattachment";
            this.txtattachment.PasswordChar = '\0';
            this.txtattachment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtattachment.SelectedText = "";
            this.txtattachment.SelectionLength = 0;
            this.txtattachment.SelectionStart = 0;
            this.txtattachment.ShortcutsEnabled = true;
            this.txtattachment.Size = new System.Drawing.Size(462, 23);
            this.txtattachment.TabIndex = 9;
            this.txtattachment.UseSelectable = true;
            this.txtattachment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtattachment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtsubject
            // 
            // 
            // 
            // 
            this.txtsubject.CustomButton.Image = null;
            this.txtsubject.CustomButton.Location = new System.Drawing.Point(521, 1);
            this.txtsubject.CustomButton.Name = "";
            this.txtsubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsubject.CustomButton.TabIndex = 1;
            this.txtsubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsubject.CustomButton.UseSelectable = true;
            this.txtsubject.CustomButton.Visible = false;
            this.txtsubject.Lines = new string[0];
            this.txtsubject.Location = new System.Drawing.Point(195, 166);
            this.txtsubject.MaxLength = 450;
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.PasswordChar = '\0';
            this.txtsubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsubject.SelectedText = "";
            this.txtsubject.SelectionLength = 0;
            this.txtsubject.SelectionStart = 0;
            this.txtsubject.ShortcutsEnabled = true;
            this.txtsubject.Size = new System.Drawing.Size(543, 23);
            this.txtsubject.TabIndex = 10;
            this.txtsubject.UseSelectable = true;
            this.txtsubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(663, 135);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 12;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseSelectable = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(663, 306);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 13;
            this.btnsend.Text = "Send";
            this.btnsend.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnsend.UseSelectable = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtbody
            // 
            // 
            // 
            // 
            this.txtbody.CustomButton.Image = null;
            this.txtbody.CustomButton.Location = new System.Drawing.Point(445, 2);
            this.txtbody.CustomButton.Name = "";
            this.txtbody.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtbody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbody.CustomButton.TabIndex = 1;
            this.txtbody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbody.CustomButton.UseSelectable = true;
            this.txtbody.CustomButton.Visible = false;
            this.txtbody.Lines = new string[0];
            this.txtbody.Location = new System.Drawing.Point(195, 200);
            this.txtbody.MaxLength = 450;
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.PasswordChar = '\0';
            this.txtbody.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbody.SelectedText = "";
            this.txtbody.SelectionLength = 0;
            this.txtbody.SelectionStart = 0;
            this.txtbody.ShortcutsEnabled = true;
            this.txtbody.Size = new System.Drawing.Size(543, 100);
            this.txtbody.TabIndex = 14;
            this.txtbody.UseSelectable = true;
            this.txtbody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 330);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtattachment);
            this.Controls.Add(this.txtreciever);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 375);
            this.MinimumSize = new System.Drawing.Size(750, 330);
            this.Name = "Form2";
            this.Text = "Hostel Leaving Application";
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MetroFramework.Controls.MetroTextBox txtemail;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroTextBox txtreciever;
        private MetroFramework.Controls.MetroTextBox txtattachment;
        private MetroFramework.Controls.MetroTextBox txtsubject;
        private MetroFramework.Controls.MetroButton btnbrowse;
        private MetroFramework.Controls.MetroButton btnsend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTextBox txtbody;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}