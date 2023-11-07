namespace HopistalManagement
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMauKhau = new System.Windows.Forms.Label();
            this.pnlDangNhap = new System.Windows.Forms.Panel();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbBenhNhan = new System.Windows.Forms.RadioButton();
            this.rdbBacSi = new System.Windows.Forms.RadioButton();
            this.pnlRoleDangNhap = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlDangNhap.SuspendLayout();
            this.pnlRoleDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(33, 73);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(211, 22);
            this.txtTaiKhoan.TabIndex = 0;
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
            // pnlDangNhap
            // 
            this.pnlDangNhap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlDangNhap.Controls.Add(this.btnThoat);
            this.pnlDangNhap.Controls.Add(this.btnDangKy);
            this.pnlDangNhap.Controls.Add(this.btnDangNhap);
            this.pnlDangNhap.Controls.Add(this.txtTaiKhoan);
            this.pnlDangNhap.Controls.Add(this.lblMauKhau);
            this.pnlDangNhap.Controls.Add(this.txtMatKhau);
            this.pnlDangNhap.Controls.Add(this.lblTaiKhoan);
            this.pnlDangNhap.Location = new System.Drawing.Point(116, 14);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(270, 492);
            this.pnlDangNhap.TabIndex = 4;
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
            // pnlRoleDangNhap
            // 
            this.pnlRoleDangNhap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlRoleDangNhap.Controls.Add(this.rdbBacSi);
            this.pnlRoleDangNhap.Controls.Add(this.rdbBenhNhan);
            this.pnlRoleDangNhap.Controls.Add(this.rdbAdmin);
            this.pnlRoleDangNhap.Location = new System.Drawing.Point(116, 210);
            this.pnlRoleDangNhap.Name = "pnlRoleDangNhap";
            this.pnlRoleDangNhap.Size = new System.Drawing.Size(270, 53);
            this.pnlRoleDangNhap.TabIndex = 7;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(24, 275);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(98, 42);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(146, 275);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(98, 42);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
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
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(817, 518);
            this.Controls.Add(this.pnlRoleDangNhap);
            this.Controls.Add(this.pnlDangNhap);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.pnlDangNhap.ResumeLayout(false);
            this.pnlDangNhap.PerformLayout();
            this.pnlRoleDangNhap.ResumeLayout(false);
            this.pnlRoleDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMauKhau;
        private System.Windows.Forms.Panel pnlDangNhap;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.RadioButton rdbBenhNhan;
        private System.Windows.Forms.RadioButton rdbBacSi;
        private System.Windows.Forms.Panel pnlRoleDangNhap;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}

