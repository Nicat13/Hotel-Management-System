using Hotel.data.IRepository;
using Hotel.data.StructModel;
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
    public partial class ControlCustomers : Form
    {
        private bool isEdit;
        private readonly ICustomerRepository customerRepository;
        public ControlCustomers()
        {
            InitializeComponent();
            customerRepository = (ICustomerRepository)Program.ServiceProvider.GetService(typeof(ICustomerRepository));
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(Properties.Settings.Default.UserId);
            main.Show();
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
            Customer customer = new Customer()
            {
                Name = usernametxtbox.Text,
                Surname = surnametxtbox.Text,
                FIN = fintxtbox.Text,
                PhoneNumber = numbertxtbox.Text,
                Email = emailtxtbox.Text,
            };
            if (isEdit)
            {
                AddUpdateResponseModel result = customerRepository.UpdateCustomer(customer);
                if (result.Status)
                {
                    MessageBox.Show("User Edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                    AddUpdateResponseModel result = customerRepository.AddCustomer(customer);

                    if (result.Status)
                    {
                        MessageBox.Show("User Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
            customerdatagrid.DataSource = customerRepository.GetAllCustomers();
            clearbtn_Click(sender, e);
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
            this.customerdatagrid.ClearSelection();
            fintxtbox.Enabled = true;
            editcreateuserbtn.Text = "Create";
            isEdit = false;
        }

        private void customerdatagrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            var rowsCount = customerdatagrid.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;
            DataGridViewRow row = this.customerdatagrid.SelectedRows[0];
            Customer appUser = customerRepository.GetCustomerbyId(Convert.ToInt32(row.Cells[0].Value));
            if (appUser != null)
            {
                usernametxtbox.Text = appUser.Name;
                surnametxtbox.Text = appUser.Surname;
                fintxtbox.Text = appUser.FIN;
                numbertxtbox.Text = appUser.PhoneNumber;
                emailtxtbox.Text = appUser.Email;
                fintxtbox.Enabled = false;
                editcreateuserbtn.Text = "Edit";
                isEdit = true;
            }
        }

        private void ControlCustomers_Load(object sender, EventArgs e)
        {
            customerdatagrid.DataSource = customerRepository.GetAllCustomers();
        }

        private void customerdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == customerdatagrid.Columns["Delete"].Index)
            {
                DialogResult dialogResult = MessageBox.Show($"Delete the {this.customerdatagrid.Rows[e.RowIndex].Cells[1].Value + " " + this.customerdatagrid.Rows[e.RowIndex].Cells[2].Value}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (customerRepository.DeleteCustomer(Convert.ToInt32(this.customerdatagrid.Rows[e.RowIndex].Cells[0].Value)))
                    {
                        MessageBox.Show("User Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    customerdatagrid.DataSource = customerRepository.GetAllCustomers();
                    clearbtn_Click(sender, e);
                }

            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            customerdatagrid.DataSource = customerRepository.SearchCustomer(searchtxtbox.Text);
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (searchtxtbox.Text.Length==0)
            {
                customerdatagrid.DataSource = customerRepository.GetAllCustomers();
            }
        }
    }
}
