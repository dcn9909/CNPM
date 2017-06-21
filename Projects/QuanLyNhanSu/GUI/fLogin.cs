using System;
using System.Windows.Forms;
using QuanLyNhanSu.Properties;
using QuanLyNhanSu.BUS;
using QuanLyNhanSu.GUI;

namespace QuanLyNhanSy.GUI
{
    public partial class fLogin : MetroFramework.Forms.MetroForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            txbUserName.Focus();
            if (Settings.Default.rememberMe)
            {
                txbUserName.Text = Settings.Default.userName;
                txbPassWord.Text = Settings.Default.passWord;
                ckbRememberMe.Checked = Settings.Default.rememberMe; ;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbUserName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPassWord.Focus();
                return;
            }
            else
            {
                if (AccountBUS.Instance.Login(userName, passWord))
                {
                    this.Hide();
                    if (ckbRememberMe.Checked)
                    {
                        Settings.Default.passWord = txbPassWord.Text;
                        Settings.Default.userName = txbUserName.Text;                    
                    }
                    Settings.Default.Save();
                    fMain f = new fMain();
                    f.ShowDialog();
                }else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void ckbRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRememberMe.Checked)
            {
                Settings.Default.passWord = txbPassWord.Text;
                Settings.Default.userName = txbUserName.Text;
            }
            else
            {
                Settings.Default.passWord = null;
                Settings.Default.userName = null;
            }
            Settings.Default.rememberMe = ckbRememberMe.Checked;
            Settings.Default.Save();
        }
    }
}
