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
    public partial class ReservationControl : Form
    {
        private readonly string userfin;
        private readonly int? roomId;
        private bool isEdit;
        private int reservid;
        private bool iscorrectfin;
        private readonly IReservationRepository reservationRepository;

        public ReservationControl(string fin, int? roomId)
        {
            InitializeComponent();
            userfin = fin;
            this.roomId = roomId;
            reservationRepository = (IReservationRepository)Program.ServiceProvider.GetService(typeof(IReservationRepository));

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(Properties.Settings.Default.UserId);
            main.Show();
        }
        private bool CheckUserFin(string fin)
        {
            bool result = reservationRepository.CheckFin(fin);
            if (result)
            {
                checkicon.Text = "✔";
            }
            else
            {
                checkicon.Text = "X";
            }

            return result;
        }
        private void BindRoomCombobox()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = reservationRepository.GetReadyRooms();
            roomcombobox.DataSource = bindingSource.DataSource;
            roomcombobox.DisplayMember = "RoomNo";
            roomcombobox.ValueMember = "Id";
        }
        private void ReservationControl_Load(object sender, EventArgs e)
        {
            reservationgrid.DataSource = reservationRepository.GetReservations();
            if (!string.IsNullOrEmpty(userfin))
            {
                iscorrectfin = CheckUserFin(userfin);
                fintxtbox.Text = userfin;
            }

            BindRoomCombobox();

            if (roomId != null)
            {
                roomcombobox.SelectedValue = roomId;
            }
        }

        private void fintxtbox_TextChanged(object sender, EventArgs e)
        {
            if (fintxtbox.Text.Length == 7)
            {
                iscorrectfin = CheckUserFin(fintxtbox.Text);
            }
            else if (fintxtbox.Text.Length == 0)
            {
                checkicon.Text = "";
            }
            else
            {
                checkicon.Text = "X";
            }
        }

        private void editcreateuserbtn_Click(object sender, EventArgs e)
        {
            if (iscorrectfin)
            {
                if (string.IsNullOrEmpty(fintxtbox.Text))
                {
                    MessageBox.Show("Fill all fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (fintxtbox.Text.Length < 7)
                {
                    MessageBox.Show("Invalid FIN", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Reservation reservation = new Reservation()
                {
                    CheckInDate = checkindate.Value,
                    CheckOutDate = checkoutdate.Value,
                    RoomId = roomcombobox.SelectedValue!=null?Convert.ToInt32(roomcombobox.SelectedValue):0
                };
                if (isEdit)
                {
                    reservation.Id = reservid;
                    reservationRepository.UpdateReservation(reservation);
                    MessageBox.Show("Reservation Edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    reservationRepository.AddReservation(reservation, fintxtbox.Text);
                    MessageBox.Show("Reservation Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reservationgrid.DataSource = reservationRepository.GetReservations();
                BindRoomCombobox();
                clearbtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Invalid FIN", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
            this.reservationgrid.ClearSelection();
            checkindate.Value = DateTime.Now;
            checkoutdate.Value = DateTime.Now;
            fintxtbox.Enabled = true;
            editcreateuserbtn.Text = "Create";
            isEdit = false;
            BindRoomCombobox();
        }

        private void reservationgrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            var rowsCount = reservationgrid.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;
            DataGridViewRow row = this.reservationgrid.SelectedRows[0];
            ReservationViewModel reservation = reservationRepository.GetReservationById(Convert.ToInt32(row.Cells[0].Value));
            if (reservation != null)
            {
                fintxtbox.Text = reservation.FIN;
                fintxtbox.Enabled = false;
                reservid = Convert.ToInt32(row.Cells[0].Value);
                roomcombobox.SelectedValue = Convert.ToInt32(reservation.RoomNo);
                checkindate.Value = reservation.CheckInDate;
                checkoutdate.Value = reservation.CheckOutDate;
                editcreateuserbtn.Text = "Edit";
                isEdit = true;
            }
        }
    }
}
