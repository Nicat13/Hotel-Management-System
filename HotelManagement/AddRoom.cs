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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(Properties.Settings.Default.UserId);
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRoomType addRoom = new AddRoomType();
            addRoom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRoom createRoom = new CreateRoom();
            createRoom.Show();
        }
    }
}
