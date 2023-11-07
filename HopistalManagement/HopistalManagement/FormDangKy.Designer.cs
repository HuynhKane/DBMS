namespace HopistalManagement
{
    partial class FormDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblMauKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.pnlDangKy = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.rdbBacSi = new System.Windows.Forms.RadioButton();
            this.rdbBenhNhan = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.pnlRoleDangKy = new System.Windows.Forms.Panel();
            this.lblNhapLaiMatKhau = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.pnlDangKy.SuspendLayout();
            this.pnlRoleDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(33, 73);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(211, 22);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // lblMauKhau
            // 
            this.lblMauKhau.AutoSize = true;
            this.lblMauKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMauKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMauKhau.Location = new System.Drawing.Point(35, 114);
            this.lblMauKhau.Name = "lblMauKhau";
            this.lblMauKhau.Size = new System.Drawing.Size(77, 20);
            this.lblMauKhau.TabIndex = 3;
            this.lblMauKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(33, 146);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(211, 22);
            this.txtMatKhau.TabIndex = 1;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTaiKhoan.Location = new System.Drawing.Point(31, 50);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(81, 20);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // pnlDangKy
            // 
            this.pnlDangKy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlDangKy.Controls.Add(this.lblNhapLaiMatKhau);
            this.pnlDangKy.Controls.Add(this.btnThoat);
            this.pnlDangKy.Controls.Add(this.txtNhapLaiMatKhau);
            this.pnlDangKy.Controls.Add(this.pnlRoleDangKy);
            this.pnlDangKy.Controls.Add(this.btnDangKy);
            this.pnlDangKy.Controls.Add(this.txtTaiKhoan);
            this.pnlDangKy.Controls.Add(this.lblMauKhau);
            this.pnlDangKy.Controls.Add(this.txtMatKhau);
            this.pnlDangKy.Controls.Add(this.lblTaiKhoan);
            this.pnlDangKy.Location = new System.Drawing.Point(119, 19);
            this.pnlDangKy.Name = "pnlDangKy";
            this.pnlDangKy.Size = new System.Drawing.Size(270, 492);
            this.pnlDangKy.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(169, 447);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(86, 339);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(98, 42);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // rdbBacSi
            // 
            this.rdbBacSi.AutoSize = true;
            this.rdbBacSi.Location = new System.Drawing.Point(187, 15);
            this.rdbBacSi.Name = "rdbBacSi";
            this.rdbBacSi.Size = new System.Drawing.Size(69, 20);
            this.rdbBacSi.TabIndex = 6;
            this.rdbBacSi.TabStop = true;
            this.rdbBacSi.Text = "Bác Sĩ";
            this.rdbBacSi.UseVisualStyleBackColor = true;
            // 
            // rdbBenhNhan
            // 
            this.rdbBenhNhan.AutoSize = true;
            this.rdbBenhNhan.Location = new System.Drawing.Point(15, 15);
            this.rdbBenhNhan.Name = "rdbBenhNhan";
            this.rdbBenhNhan.Size = new System.Drawing.Size(94, 20);
            this.rdbBenhNhan.TabIndex = 5;
            this.rdbBenhNhan.TabStop = true;
            this.rdbBenhNhan.Text = "Bệnh Nhân";
            this.rdbBenhNhan.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(115, 15);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(66, 20);
            this.rdbAdmin.TabIndex = 4;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // pnlRoleDangKy
            // 
            this.pnlRoleDangKy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlRoleDangKy.Controls.Add(this.rdbBacSi);
            this.pnlRoleDangKy.Controls.Add(this.rdbBenhNhan);
            this.pnlRoleDangKy.Controls.Add(this.rdbAdmin);
            this.pnlRoleDangKy.Location = new System.Drawing.Point(3, 280);
            this.pnlRoleDangKy.Name = "pnlRoleDangKy";
            this.pnlRoleDangKy.Size = new System.Drawing.Size(264, 53);
            this.pnlRoleDangKy.TabIndex = 9;
            // 
            // lblNhapLaiMatKhau
            // 
            this.lblNhapLaiMatKhau.AutoSize = true;
            this.lblNhapLaiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNhapLaiMatKhau.Location = new System.Drawing.Point(31, 188);
            this.lblNhapLaiMatKhau.Name = "lblNhapLaiMatKhau";
            this.lblNhapLaiMatKhau.Size = new System.Drawing.Size(143, 20);
            this.lblNhapLaiMatKhau.TabIndex = 11;
            this.lblNhapLaiMatKhau.Text = "Nhập lại mật khẩu";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(29, 220);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(211, 22);
            this.txtNhapLaiMatKhau.TabIndex = 10;
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(819, 523);
            this.Controls.Add(this.pnlDangKy);
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangKy";
            this.pnlDangKy.ResumeLayout(false);
            this.pnlDangKy.PerformLayout();
            this.pnlRoleDangKy.ResumeLayout(false);
            this.pnlRoleDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMauKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Panel pnlDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.RadioButton rdbBacSi;
        private System.Windows.Forms.RadioButton rdbBenhNhan;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.Panel pnlRoleDangKy;
        private System.Windows.Forms.Label lblNhapLaiMatKhau;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
    }
}