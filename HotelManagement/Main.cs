using HotelManagement.CustomForms;
using Hotel.data.IRepository;
using Hotel.data.StructModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Main : Form
    {
        private readonly IFileRepo fileRepo;
        private readonly IAccountRepository accountRepository;
        private readonly int userId;
        public Main(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            fileRepo = (IFileRepo)Program.ServiceProvider.GetService(typeof(IFileRepo));
            accountRepository= (IAccountRepository)Program.ServiceProvider.GetService(typeof(IAccountRepository));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Jpeg File (*.jpg)|*.jpg|Gif File (*.gif)|*.gif|Png File (*.png)|*.png|Tif File (*.tif)|*.tif";
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

            }

        }


        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //JsonResponseModel imgresponse = fileRepo.UploadImage(pictureBox1.ImageLocation);
            //if (!string.IsNullOrEmpty(imgresponse.obj.ToString()))
            //{
            //    textBox1.Text = "okk";
            //    //pictureBox1.Load($"{ConfigurationManager.AppSettings["ApiUrl"]}/img/{imgurl}");
            //    return;
            //}
            //textBox1.Text = imgresponse.message;
        }

        private void createnewuserbtn_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Confirm Password", "Warning!!");
            if (!string.IsNullOrEmpty(promptValue.Trim()))
            {
                if (accountRepository.Userauthenticator(userId, promptValue)!=0)
                {
                    this.Hide();
                    AddUser newuser = new AddUser(userId);
                    newuser.ShowDialog();
                    return;
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                    return;
                }
            }
                MessageBox.Show("Type Password");
            return;
        }
    }
}
