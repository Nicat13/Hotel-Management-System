using Hotel.data.IRepository;
using Hotel.data.StructModel;
using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class CreateRoom : Form
    {
        private bool isEdit;
        private int roomId;
        private string img;
        private bool newimg;
        private readonly IRoomRepository roomRepository;
        private readonly IFileRepo fileRepo;
        public CreateRoom()
        {
            InitializeComponent();
            roomRepository = (IRoomRepository)Program.ServiceProvider.GetService(typeof(IRoomRepository));
            fileRepo = (IFileRepo)Program.ServiceProvider.GetService(typeof(IFileRepo));
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRoom main = new AddRoom();
            main.Show();
        }



        private void roommainimg_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Jpeg File (*.jpg)|*.jpg|Gif File (*.gif)|*.gif|Png File (*.png)|*.png|Tif File (*.tif)|*.tif";
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                newimg = true;
                roommainimg.Load(openFileDialog.FileName);
            }
        }


        private void CreateRoom_Load(object sender, EventArgs e)
        {
            roomdatagrid.DataSource = roomRepository.GetAllRooms();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = roomRepository.GetAllRoomStatusses();
            roomstatus.DataSource = bindingSource.DataSource;
            roomstatus.DisplayMember = "StatusName";
            roomstatus.ValueMember = "Id";
            bindingSource.DataSource = roomRepository.GetAllRoomTypes();
            roomtype.DataSource = bindingSource.DataSource;
            roomtype.DisplayMember = "TypeName";
            roomtype.ValueMember = "Id";
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void roomdatagrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            var rowsCount = roomdatagrid.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;
            DataGridViewRow row = this.roomdatagrid.SelectedRows[0];
            roomId = Convert.ToInt32(row.Cells[0].Value);
            img = row.Cells[7].Value != null ? row.Cells[7].Value.ToString() : String.Empty;
            Room room = roomRepository.GetRoom(roomId);
            if (room != null)
            {
                roomnametxtbox.Text = room.RoomNo;
                bedsnumbertxtbox.Text = room.NumberOfBeds.ToString();
                childbedstxtbox.Text = room.NumberOfChildBeds.ToString();
                roompricetxtbox.Text = room.RoomPrice.ToString();
                discounttxtbox.Text = room.Discount.ToString();
                floornumbertxtbox.Text = room.FloorNumber.ToString();
                roomstatus.SelectedValue = room.RoomStatusId;
                roomtype.SelectedValue = room.RoomTypesId;
                editcreatebtn.Text = "Edit";
                if (!string.IsNullOrEmpty(img))
                {
                    roommainimg.Load(ConfigurationManager.AppSettings["ApiUrl"] + "/img/" + img);
                }
                else
                {
                    roommainimg.Image = null;
                }
                clearbtn.Enabled = true;
                isEdit = true;
            }
        }

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            this.roomdatagrid.ClearSelection();
            editcreatebtn.Text = "Create";
            clearbtn.Enabled = false;
            roomtype.SelectedIndex = 0;
            roomstatus.SelectedIndex = 0;
            isEdit = false;
        }

        private void editcreatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(roomnametxtbox.Text) || string.IsNullOrEmpty(roompricetxtbox.Text) || string.IsNullOrEmpty(bedsnumbertxtbox.Text))
            {
                MessageBox.Show("Fill all fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Room room = new Room()
                {
                    RoomNo = roomnametxtbox.Text,
                    RoomPrice = Convert.ToDecimal(roompricetxtbox.Text),
                    NumberOfBeds = Convert.ToInt32(bedsnumbertxtbox.Text),
                    Discount = string.IsNullOrEmpty(discounttxtbox.Text) ? 0 : Convert.ToInt32(discounttxtbox.Text),
                    NumberOfChildBeds = string.IsNullOrEmpty(childbedstxtbox.Text) ? 0 : Convert.ToInt32(childbedstxtbox.Text),
                    FloorNumber = Convert.ToInt32(floornumbertxtbox.Text),
                    RoomTypesId = (int)roomtype.SelectedValue,
                    RoomStatusId = (int)roomstatus.SelectedValue
                };
                if (isEdit)
                {
                    if (newimg)
                    {
                        JsonResponseModel imgresponse = fileRepo.EditImage(roommainimg.ImageLocation, img);
                        if (!string.IsNullOrEmpty(imgresponse.obj.ToString()))
                        {
                            room.Img = imgresponse.obj.ToString();
                        }
                    }
                    room.Id = roomId;
                    roomRepository.EditRoom(room);
                    MessageBox.Show("Room Edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (newimg)
                    {
                        JsonResponseModel imgresponse = fileRepo.UploadImage(roommainimg.ImageLocation);
                        if (!string.IsNullOrEmpty(imgresponse.obj.ToString()))
                        {
                            room.Img = imgresponse.obj.ToString();
                        }
                    }

                    roomRepository.AddRoom(room);
                    MessageBox.Show("Room Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                roomdatagrid.DataSource = roomRepository.GetAllRooms();
                roommainimg.Image = null;
                clearbtn_Click_1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roomdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == roomdatagrid.Columns["Delete"].Index)
            {
                DialogResult dialogResult = MessageBox.Show($"Delete the {this.roomdatagrid.Rows[e.RowIndex].Cells[1].Value}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        roomRepository.DeleteRoom(Convert.ToInt32(this.roomdatagrid.Rows[e.RowIndex].Cells[0].Value));
                        MessageBox.Show("Room Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        roomdatagrid.DataSource = roomRepository.GetAllRooms();
                        roommainimg.Image = null;
                        clearbtn_Click_1(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
