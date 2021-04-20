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
    public partial class AddUser : Form
    {
        private readonly int userId;
        private bool isEdit;
        private readonly IAccountRepository accountRepository;
        public AddUser(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            accountRepository = (IAccountRepository)Program.ServiceProvider.GetService(typeof(IAccountRepository));

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            userdatagrid.DataSource = accountRepository.GetAppUsers();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = accountRepository.GetRoles();
            rolecombobox.DataSource = bindingSource.DataSource;
            rolecombobox.DisplayMember = "RoleName";
            rolecombobox.ValueMember = "Id";
        }

        private void userdatagrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            var rowsCount = userdatagrid.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;
            DataGridViewRow row = this.userdatagrid.SelectedRows[0];
            AppUsers appUser = accountRepository.GetUserByid(Convert.ToInt32(row.Cells[0].Value));
            if (appUser != null)
            {
                usernametxtbox.Text = appUser.Name;
                surnametxtbox.Text = appUser.Surname;
                fintxtbox.Text = appUser.FIN;
                numbertxtbox.Text = appUser.PhoneNumber;
                emailtxtbox.Text = appUser.Email;
                rolecombobox.SelectedValue = appUser.rolesId;
                fintxtbox.Enabled = false;
                editcreateuserbtn.Text = "Edit";
                isEdit = true;
            }

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
        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            this.userdatagrid.ClearSelection();
            userdatagrid.CurrentCell.Selected = false;
            fintxtbox.Enabled = true;
            editcreateuserbtn.Text = "Create";
            rolecombobox.SelectedIndex = 0;
            isEdit = false;
        }

        private void editcreateuserbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernametxtbox.Text) || string.IsNullOrEmpty(surnametxtbox.Text) || string.IsNullOrEmpty(fintxtbox.Text) || string.IsNullOrEmpty(numbertxtbox.Text) || string.IsNullOrEmpty(emailtxtbox.Text))
            {
                MessageBox.Show("Fill all fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fintxtbox.Text.Length < 7)
            {
                MessageBox.Show("Invalid FIN", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AppUsers appUser = new AppUsers()
            {
                Name = usernametxtbox.Text,
                Surname = surnametxtbox.Text,
                FIN = fintxtbox.Text,
                PhoneNumber = numbertxtbox.Text,
                Email = emailtxtbox.Text,
                Password = passwordtxtbox.Text,
                rolesId = (int)rolecombobox.SelectedValue
            };
            if (isEdit)
            {
                bool? result = accountRepository.UpdateUser(appUser);
                if (result != null && result == true)
                {
                    MessageBox.Show("User Edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result != null && result == false)
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(passwordtxtbox.Text.Trim()))
                {

                    if (accountRepository.AddUser(appUser))
                    {
                        MessageBox.Show("User Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            userdatagrid.DataSource = accountRepository.GetAppUsers();
            clearbtn_Click(sender, e);
        }

        private void userdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == userdatagrid.Columns["Delete"].Index)
            {
                if (accountRepository.DeleteUser(Convert.ToInt32(this.userdatagrid.Rows[e.RowIndex].Cells[0].Value)))
                {
                    MessageBox.Show("User Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                userdatagrid.DataSource = accountRepository.GetAppUsers();
            }
        }
    }
}
