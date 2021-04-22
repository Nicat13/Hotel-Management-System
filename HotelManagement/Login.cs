using Hotel.data.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Login : Form
    {
        private readonly IAccountRepository accountRepository;

        public Login()
        {
            InitializeComponent();
            accountRepository = (IAccountRepository)Program.ServiceProvider.GetService(typeof(IAccountRepository));
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Email))
            {
                emailtxtbox.Text = Properties.Settings.Default.Email;
                checkRemember.Checked = true;
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailtxtbox.Text.Trim()) || string.IsNullOrEmpty(passtxtbox.Text.Trim()))
            {
                loginpanel.Visible = true;
                loginerrorlabel.Text = "Fill all fields";
                return;
            }
            int userId = accountRepository.Login(emailtxtbox.Text.Trim(), passtxtbox.Text.Trim());
            if (userId != 0)
            {
                if (checkRemember.Checked)
                {
                    Properties.Settings.Default.Email = emailtxtbox.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Email = null;
                    Properties.Settings.Default.Save();
                }
                Properties.Settings.Default.UserId = userId;
                Properties.Settings.Default.Save();
                this.Hide();
                Main main = new Main(userId);
                main.ShowDialog();
            }
            loginpanel.Visible = true;
            loginerrorlabel.Text = "The email address or password is incorrect";
            return;
        }

        private void emailtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loginbtn_Click(sender, e);
            }
        }

        private void passtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loginbtn_Click(sender, e);
            }
        }
    }
}
