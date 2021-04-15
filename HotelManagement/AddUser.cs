using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class AddUser : Form
    {
        private readonly int userId;
        public AddUser(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            textBox1.Text = userId.ToString();
        }
    }
}
