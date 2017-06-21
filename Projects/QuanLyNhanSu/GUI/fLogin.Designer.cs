namespace QuanLyNhanSy.GUI
{
    partial class fLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ckbRememberMe = new MetroFramework.Controls.MetroCheckBox();
            this.txbPassWord = new MetroFramework.Controls.MetroTextBox();
            this.txbUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.ckbRememberMe);
            this.panel1.Controls.Add(this.txbPassWord);
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(184, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 159);
            this.panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(161, 126);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ckbRememberMe
            // 
            this.ckbRememberMe.AutoSize = true;
            this.ckbRememberMe.Location = new System.Drawing.Point(0, 103);
            this.ckbRememberMe.Name = "ckbRememberMe";
            this.ckbRememberMe.Size = new System.Drawing.Size(130, 15);
            this.ckbRememberMe.TabIndex = 2;
            this.ckbRememberMe.Text = "Ghi nhớ đăng nhập?";
            this.ckbRememberMe.UseSelectable = true;
            this.ckbRememberMe.CheckedChanged += new System.EventHandler(this.ckbRememberMe_CheckedChanged);
            // 
            // txbPassWord
            // 
            // 
            // 
            // 
            this.txbPassWord.CustomButton.Image = null;
            this.txbPassWord.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txbPassWord.CustomButton.Name = "";
            this.txbPassWord.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txbPassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPassWord.CustomButton.TabIndex = 1;
            this.txbPassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPassWord.CustomButton.UseSelectable = true;
            this.txbPassWord.CustomButton.Visible = false;
            this.txbPassWord.DisplayIcon = true;
            this.txbPassWord.Icon = ((System.Drawing.Image)(resources.GetObject("txbPassWord.Icon")));
            this.txbPassWord.Lines = new string[0];
            this.txbPassWord.Location = new System.Drawing.Point(0, 60);
            this.txbPassWord.MaxLength = 32767;
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '●';
            this.txbPassWord.PromptText = "Mật khẩu";
            this.txbPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPassWord.SelectedText = "";
            this.txbPassWord.SelectionLength = 0;
            this.txbPassWord.SelectionStart = 0;
            this.txbPassWord.ShortcutsEnabled = true;
            this.txbPassWord.Size = new System.Drawing.Size(265, 25);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.UseSelectable = true;
            this.txbPassWord.UseSystemPasswordChar = true;
            this.txbPassWord.WaterMark = "Mật khẩu";
            this.txbPassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPassWord.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txbUserName
            // 
            // 
            // 
            // 
            this.txbUserName.CustomButton.Image = null;
            this.txbUserName.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txbUserName.CustomButton.Name = "";
            this.txbUserName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txbUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbUserName.CustomButton.TabIndex = 1;
            this.txbUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbUserName.CustomButton.UseSelectable = true;
            this.txbUserName.CustomButton.Visible = false;
            this.txbUserName.DisplayIcon = true;
            this.txbUserName.Icon = ((System.Drawing.Image)(resources.GetObject("txbUserName.Icon")));
            this.txbUserName.Lines = new string[0];
            this.txbUserName.Location = new System.Drawing.Point(0, 17);
            this.txbUserName.MaxLength = 32767;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.PasswordChar = '\0';
            this.txbUserName.PromptText = "Tên đăng nhập";
            this.txbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUserName.SelectedText = "";
            this.txbUserName.SelectionLength = 0;
            this.txbUserName.SelectionStart = 0;
            this.txbUserName.ShortcutsEnabled = true;
            this.txbUserName.Size = new System.Drawing.Size(265, 25);
            this.txbUserName.TabIndex = 0;
            this.txbUserName.UseSelectable = true;
            this.txbUserName.WaterMark = "Tên đăng nhập";
            this.txbUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbUserName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fLogin";
            this.Resizable = false;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txbPassWord;
        private MetroFramework.Controls.MetroTextBox txbUserName;
        private MetroFramework.Controls.MetroCheckBox ckbRememberMe;
        private System.Windows.Forms.Button btnLogin;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}