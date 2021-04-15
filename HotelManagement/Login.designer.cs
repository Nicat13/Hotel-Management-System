
namespace HotelManagement
{
    partial class Login
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
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.passtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.loginerrorlabel = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.checkRemember = new System.Windows.Forms.CheckBox();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.emailtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.emailtxtbox.Location = new System.Drawing.Point(244, 127);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(286, 30);
            this.emailtxtbox.TabIndex = 0;
            this.emailtxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailtxtbox_KeyDown);
            // 
            // passtxtbox
            // 
            this.passtxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.passtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.passtxtbox.Location = new System.Drawing.Point(244, 209);
            this.passtxtbox.MaxLength = 32;
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.PasswordChar = '*';
            this.passtxtbox.Size = new System.Drawing.Size(286, 30);
            this.passtxtbox.TabIndex = 1;
            this.passtxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passtxtbox_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(239, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(239, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // loginpanel
            // 
            this.loginpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginpanel.Controls.Add(this.loginerrorlabel);
            this.loginpanel.Location = new System.Drawing.Point(12, 381);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(776, 57);
            this.loginpanel.TabIndex = 4;
            this.loginpanel.Visible = false;
            // 
            // loginerrorlabel
            // 
            this.loginerrorlabel.AutoSize = true;
            this.loginerrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginerrorlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.loginerrorlabel.Location = new System.Drawing.Point(17, 17);
            this.loginerrorlabel.Name = "loginerrorlabel";
            this.loginerrorlabel.Size = new System.Drawing.Size(113, 25);
            this.loginerrorlabel.TabIndex = 6;
            this.loginerrorlabel.Text = "ErrorTexts";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.Loginbtn.FlatAppearance.BorderSize = 0;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.Loginbtn.Location = new System.Drawing.Point(244, 263);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(286, 43);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // checkRemember
            // 
            this.checkRemember.AutoSize = true;
            this.checkRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(195)))), ((int)(((byte)(192)))));
            this.checkRemember.Location = new System.Drawing.Point(244, 323);
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Size = new System.Drawing.Size(137, 29);
            this.checkRemember.TabIndex = 6;
            this.checkRemember.Text = "Remember";
            this.checkRemember.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkRemember);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.emailtxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.TextBox passtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label loginerrorlabel;
        private System.Windows.Forms.CheckBox checkRemember;
    }
}