using Hotel.data.IRepository;
using Hotel.entity.Models;
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
    public partial class AddRoomType : Form
    {
        private bool isEdit;
        private int typeId;
        private readonly IRoomRepository roomRepository;
        public AddRoomType()
        {
            InitializeComponent();
            roomRepository = (IRoomRepository)Program.ServiceProvider.GetService(typeof(IRoomRepository));
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRoom main = new AddRoom();
            main.Show();
        }

        private void AddRoomType_Load(object sender, EventArgs e)
        {
            typedatagrid.DataSource = roomRepository.GetAllRoomTypes();
        }

        private void editcreatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(typenametxtbox.Text))
            {
                MessageBox.Show("Fill all fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (isEdit)
                {
                    roomRepository.EditRoomType(typeId, typenametxtbox.Text);
                    MessageBox.Show("Type Edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    roomRepository.AddRoomType(typenametxtbox.Text);
                    MessageBox.Show("Type Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                typedatagrid.DataSource = roomRepository.GetAllRoomTypes();
                clearbtn_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            typenametxtbox.Text = String.Empty;
            this.typedatagrid.ClearSelection();
            editcreatebtn.Text = "Create";
            clearbtn.Enabled = false;
            isEdit = false;
        }

        private void typedatagrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            var rowsCount = typedatagrid.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;
            DataGridViewRow row = this.typedatagrid.SelectedRows[0];
            typeId = Convert.ToInt32(row.Cells[0].Value);
            RoomTypes roomType = roomRepository.GetRoomType(typeId);
            if (roomType != null)
            {
                typenametxtbox.Text = roomType.TypeName;
                editcreatebtn.Text = "Edit";
                clearbtn.Enabled = true;
                isEdit = true;
            }

        }

        private void typedatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == typedatagrid.Columns["Delete"].Index)
            {
                DialogResult dialogResult = MessageBox.Show($"Delete the {this.typedatagrid.Rows[e.RowIndex].Cells[1].Value}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        roomRepository.DeleteRoomType(Convert.ToInt32(this.typedatagrid.Rows[e.RowIndex].Cells[0].Value));
                        MessageBox.Show("Type Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        typedatagrid.DataSource = roomRepository.GetAllRoomTypes();
                        clearbtn_Click(sender, e);
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
