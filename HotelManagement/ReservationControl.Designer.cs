
namespace HotelManagement
{
    partial class ReservationControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationControl));
            this.reservationgrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fintxtbox = new System.Windows.Forms.TextBox();
            this.roomcombobox = new System.Windows.Forms.ComboBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.editcreateuserbtn = new System.Windows.Forms.Button();
            this.checkindate = new System.Windows.Forms.DateTimePicker();
            this.checkoutdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxtbox = new System.Windows.Forms.TextBox();
            this.checkicon = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reservationgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationgrid
            // 
            this.reservationgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationgrid.AutoGenerateColumns = false;
            this.reservationgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.fINDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn});
            this.reservationgrid.DataSource = this.reservationViewModelBindingSource;
            this.reservationgrid.Location = new System.Drawing.Point(13, 354);
            this.reservationgrid.Name = "reservationgrid";
            this.reservationgrid.RowHeadersWidth = 51;
            this.reservationgrid.RowTemplate.Height = 24;
            this.reservationgrid.Size = new System.Drawing.Size(1391, 234);
            this.reservationgrid.TabIndex = 0;
            this.reservationgrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.reservationgrid_RowStateChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerSurnameDataGridViewTextBoxColumn
            // 
            this.customerSurnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.HeaderText = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerSurnameDataGridViewTextBoxColumn.Name = "customerSurnameDataGridViewTextBoxColumn";
            // 
            // fINDataGridViewTextBoxColumn
            // 
            this.fINDataGridViewTextBoxColumn.DataPropertyName = "FIN";
            this.fINDataGridViewTextBoxColumn.HeaderText = "FIN";
            this.fINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fINDataGridViewTextBoxColumn.Name = "fINDataGridViewTextBoxColumn";
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            // 
            // reservationViewModelBindingSource
            // 
            this.reservationViewModelBindingSource.DataSource = typeof(Hotel.data.StructModel.ReservationViewModel);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(390, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "FIN";
            // 
            // fintxtbox
            // 
            this.fintxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fintxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.fintxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fintxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fintxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.fintxtbox.Location = new System.Drawing.Point(395, 53);
            this.fintxtbox.MaxLength = 7;
            this.fintxtbox.Name = "fintxtbox";
            this.fintxtbox.Size = new System.Drawing.Size(268, 30);
            this.fintxtbox.TabIndex = 11;
            this.fintxtbox.TextChanged += new System.EventHandler(this.fintxtbox_TextChanged);
            // 
            // roomcombobox
            // 
            this.roomcombobox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roomcombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.roomcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomcombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.roomcombobox.FormattingEnabled = true;
            this.roomcombobox.Location = new System.Drawing.Point(698, 53);
            this.roomcombobox.Name = "roomcombobox";
            this.roomcombobox.Size = new System.Drawing.Size(268, 33);
            this.roomcombobox.TabIndex = 13;
            // 
            // clearbtn
            // 
            this.clearbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.clearbtn.Location = new System.Drawing.Point(840, 190);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(126, 40);
            this.clearbtn.TabIndex = 20;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // editcreateuserbtn
            // 
            this.editcreateuserbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editcreateuserbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.editcreateuserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editcreateuserbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.editcreateuserbtn.Location = new System.Drawing.Point(698, 190);
            this.editcreateuserbtn.Name = "editcreateuserbtn";
            this.editcreateuserbtn.Size = new System.Drawing.Size(126, 40);
            this.editcreateuserbtn.TabIndex = 19;
            this.editcreateuserbtn.Text = "Create";
            this.editcreateuserbtn.UseVisualStyleBackColor = false;
            this.editcreateuserbtn.Click += new System.EventHandler(this.editcreateuserbtn_Click);
            // 
            // checkindate
            // 
            this.checkindate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkindate.Location = new System.Drawing.Point(395, 132);
            this.checkindate.Name = "checkindate";
            this.checkindate.Size = new System.Drawing.Size(268, 22);
            this.checkindate.TabIndex = 21;
            // 
            // checkoutdate
            // 
            this.checkoutdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkoutdate.Location = new System.Drawing.Point(698, 132);
            this.checkoutdate.Name = "checkoutdate";
            this.checkoutdate.Size = new System.Drawing.Size(268, 22);
            this.checkoutdate.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(693, 25);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Room";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(390, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "CheckInDate";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(693, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "CheckOutDate";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.searchbtn.Location = new System.Drawing.Point(325, 304);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(126, 40);
            this.searchbtn.TabIndex = 43;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.searchtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.searchtxtbox.Location = new System.Drawing.Point(13, 308);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(306, 30);
            this.searchtxtbox.TabIndex = 42;
            // 
            // checkicon
            // 
            this.checkicon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkicon.AutoSize = true;
            this.checkicon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkicon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.checkicon.Location = new System.Drawing.Point(362, 55);
            this.checkicon.Name = "checkicon";
            this.checkicon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkicon.Size = new System.Drawing.Size(18, 25);
            this.checkicon.TabIndex = 44;
            this.checkicon.Text = " ";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(12, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(86, 51);
            this.backbtn.TabIndex = 45;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // ReservationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1416, 600);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.checkicon);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkoutdate);
            this.Controls.Add(this.checkindate);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.editcreateuserbtn);
            this.Controls.Add(this.roomcombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fintxtbox);
            this.Controls.Add(this.reservationgrid);
            this.Name = "ReservationControl";
            this.Text = "ReservationControl";
            this.Load += new System.EventHandler(this.ReservationControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationgrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fintxtbox;
        private System.Windows.Forms.ComboBox roomcombobox;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button editcreateuserbtn;
        private System.Windows.Forms.DateTimePicker checkindate;
        private System.Windows.Forms.DateTimePicker checkoutdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxtbox;
        private System.Windows.Forms.Label checkicon;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationViewModelBindingSource;
    }
}