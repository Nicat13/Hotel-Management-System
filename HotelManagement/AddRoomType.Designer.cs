
namespace HotelManagement
{
    partial class AddRoomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoomType));
            this.backbtn = new System.Windows.Forms.Button();
            this.typenametxtbox = new System.Windows.Forms.TextBox();
            this.editcreatebtn = new System.Windows.Forms.Button();
            this.typedatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.roomTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.typedatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.backbtn.TabIndex = 20;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // typenametxtbox
            // 
            this.typenametxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.typenametxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.typenametxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typenametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typenametxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.typenametxtbox.Location = new System.Drawing.Point(412, 83);
            this.typenametxtbox.Name = "typenametxtbox";
            this.typenametxtbox.Size = new System.Drawing.Size(273, 30);
            this.typenametxtbox.TabIndex = 21;
            // 
            // editcreatebtn
            // 
            this.editcreatebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editcreatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.editcreatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editcreatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.editcreatebtn.Location = new System.Drawing.Point(412, 139);
            this.editcreatebtn.Name = "editcreatebtn";
            this.editcreatebtn.Size = new System.Drawing.Size(126, 40);
            this.editcreatebtn.TabIndex = 23;
            this.editcreatebtn.Text = "Create";
            this.editcreatebtn.UseVisualStyleBackColor = false;
            this.editcreatebtn.Click += new System.EventHandler(this.editcreatebtn_Click);
            // 
            // typedatagrid
            // 
            this.typedatagrid.AllowUserToDeleteRows = false;
            this.typedatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typedatagrid.AutoGenerateColumns = false;
            this.typedatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.typedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typedatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.Delete});
            this.typedatagrid.DataSource = this.roomTypesBindingSource;
            this.typedatagrid.Location = new System.Drawing.Point(13, 266);
            this.typedatagrid.Name = "typedatagrid";
            this.typedatagrid.ReadOnly = true;
            this.typedatagrid.RowHeadersWidth = 51;
            this.typedatagrid.RowTemplate.Height = 24;
            this.typedatagrid.Size = new System.Drawing.Size(1059, 338);
            this.typedatagrid.TabIndex = 25;
            this.typedatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.typedatagrid_CellContentClick);
            this.typedatagrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.typedatagrid_RowStateChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(405, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "TypeName";
            // 
            // roomTypesBindingSource
            // 
            this.roomTypesBindingSource.DataSource = typeof(Hotel.entity.Models.RoomTypes);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // clearbtn
            // 
            this.clearbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.clearbtn.Enabled = false;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.clearbtn.Location = new System.Drawing.Point(559, 139);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(126, 40);
            this.clearbtn.TabIndex = 26;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // AddRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1084, 616);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.typedatagrid);
            this.Controls.Add(this.editcreatebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typenametxtbox);
            this.Controls.Add(this.backbtn);
            this.Name = "AddRoomType";
            this.Text = "AddRoomType";
            this.Load += new System.EventHandler(this.AddRoomType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typedatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox typenametxtbox;
        private System.Windows.Forms.Button editcreatebtn;
        private System.Windows.Forms.DataGridView typedatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource roomTypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button clearbtn;
    }
}