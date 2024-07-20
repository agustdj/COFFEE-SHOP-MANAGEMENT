namespace QUANLICAFE.PresentationTier
{
    partial class FrmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanHang));
            this.pnlBan = new System.Windows.Forms.Panel();
            this.pnlBanHang = new System.Windows.Forms.Panel();
            this.cmbDoiBan = new System.Windows.Forms.ComboBox();
            this.cmbMon = new System.Windows.Forms.ComboBox();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDoiBan = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dgvDanhSachMon = new System.Windows.Forms.DataGridView();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBan
            // 
            this.pnlBan.BackColor = System.Drawing.Color.Moccasin;
            this.pnlBan.Location = new System.Drawing.Point(12, 35);
            this.pnlBan.Name = "pnlBan";
            this.pnlBan.Size = new System.Drawing.Size(418, 351);
            this.pnlBan.TabIndex = 0;
            // 
            // pnlBanHang
            // 
            this.pnlBanHang.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlBanHang.Controls.Add(this.cmbDoiBan);
            this.pnlBanHang.Controls.Add(this.cmbMon);
            this.pnlBanHang.Controls.Add(this.cmbDanhMuc);
            this.pnlBanHang.Controls.Add(this.btnThanhToan);
            this.pnlBanHang.Controls.Add(this.btnDoiBan);
            this.pnlBanHang.Controls.Add(this.btnThem);
            this.pnlBanHang.Controls.Add(this.txtTongTien);
            this.pnlBanHang.Controls.Add(this.dgvDanhSachMon);
            this.pnlBanHang.Controls.Add(this.nudSoLuong);
            this.pnlBanHang.Controls.Add(this.nudGiamGia);
            this.pnlBanHang.Controls.Add(this.label5);
            this.pnlBanHang.Controls.Add(this.label2);
            this.pnlBanHang.Controls.Add(this.label3);
            this.pnlBanHang.Controls.Add(this.label4);
            this.pnlBanHang.Controls.Add(this.label1);
            this.pnlBanHang.Location = new System.Drawing.Point(436, 35);
            this.pnlBanHang.Name = "pnlBanHang";
            this.pnlBanHang.Size = new System.Drawing.Size(447, 351);
            this.pnlBanHang.TabIndex = 1;
            // 
            // cmbDoiBan
            // 
            this.cmbDoiBan.FormattingEnabled = true;
            this.cmbDoiBan.Location = new System.Drawing.Point(103, 266);
            this.cmbDoiBan.Name = "cmbDoiBan";
            this.cmbDoiBan.Size = new System.Drawing.Size(108, 21);
            this.cmbDoiBan.TabIndex = 8;
            // 
            // cmbMon
            // 
            this.cmbMon.FormattingEnabled = true;
            this.cmbMon.Location = new System.Drawing.Point(97, 51);
            this.cmbMon.Name = "cmbMon";
            this.cmbMon.Size = new System.Drawing.Size(114, 21);
            this.cmbMon.TabIndex = 8;
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(97, 18);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(114, 21);
            this.cmbDanhMuc.TabIndex = 8;
            this.cmbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cmbDanhMuc_SelectedIndexChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(317, 308);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(100, 31);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toan";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDoiBan
            // 
            this.btnDoiBan.Image = global::QUANLICAFE.Properties.Resources.change;
            this.btnDoiBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiBan.Location = new System.Drawing.Point(19, 256);
            this.btnDoiBan.Name = "btnDoiBan";
            this.btnDoiBan.Size = new System.Drawing.Size(78, 39);
            this.btnDoiBan.TabIndex = 5;
            this.btnDoiBan.Text = "Doi Ban";
            this.btnDoiBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiBan.UseVisualStyleBackColor = true;
            this.btnDoiBan.Click += new System.EventHandler(this.btnDoiBan_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(352, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 25);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Them";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(317, 256);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 4;
            // 
            // dgvDanhSachMon
            // 
            this.dgvDanhSachMon.AllowUserToAddRows = false;
            this.dgvDanhSachMon.AllowUserToDeleteRows = false;
            this.dgvDanhSachMon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenMon,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.dgvDanhSachMon.Location = new System.Drawing.Point(11, 97);
            this.dgvDanhSachMon.Name = "dgvDanhSachMon";
            this.dgvDanhSachMon.ReadOnly = true;
            this.dgvDanhSachMon.Size = new System.Drawing.Size(406, 142);
            this.dgvDanhSachMon.TabIndex = 3;
            // 
            // colTenMon
            // 
            this.colTenMon.HeaderText = "Ten Mon";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "So Luong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Don Gia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thanh Tien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(352, 23);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(65, 20);
            this.nudSoLuong.TabIndex = 1;
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(317, 282);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(100, 20);
            this.nudGiamGia.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh Muc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "So Luong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tong Tien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giam Gia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mon";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLiToolStripMenuItem,
            this.taiKhoanToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLiToolStripMenuItem
            // 
            this.quanLiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoanToolStripMenuItem,
            this.danhThuToolStripMenuItem,
            this.quanLiMonToolStripMenuItem});
            this.quanLiToolStripMenuItem.Name = "quanLiToolStripMenuItem";
            this.quanLiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quanLiToolStripMenuItem.Text = "Quan Li";
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.taiKhoanToolStripMenuItem.Text = "Tai Khoan";
            // 
            // danhThuToolStripMenuItem
            // 
            this.danhThuToolStripMenuItem.Name = "danhThuToolStripMenuItem";
            this.danhThuToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.danhThuToolStripMenuItem.Text = "Danh thu";
            // 
            // quanLiMonToolStripMenuItem
            // 
            this.quanLiMonToolStripMenuItem.Name = "quanLiMonToolStripMenuItem";
            this.quanLiMonToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quanLiMonToolStripMenuItem.Text = "Quan Li Mon";
            this.quanLiMonToolStripMenuItem.Click += new System.EventHandler(this.quanLiMonToolStripMenuItem_Click);
            // 
            // taiKhoanToolStripMenuItem1
            // 
            this.taiKhoanToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhapToolStripMenuItem,
            this.dangXuâtToolStripMenuItem});
            this.taiKhoanToolStripMenuItem1.Name = "taiKhoanToolStripMenuItem1";
            this.taiKhoanToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.taiKhoanToolStripMenuItem1.Text = "Tai Khoan";
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.dangNhapToolStripMenuItem.Text = "Dang nhap";
            // 
            // dangXuâtToolStripMenuItem
            // 
            this.dangXuâtToolStripMenuItem.Name = "dangXuâtToolStripMenuItem";
            this.dangXuâtToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.dangXuâtToolStripMenuItem.Text = "Dang xuât";
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(895, 393);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlBan);
            this.Controls.Add(this.pnlBanHang);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBanHang";
            this.Text = "Quan Li Cafe";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.pnlBanHang.ResumeLayout(false);
            this.pnlBanHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBan;
        private System.Windows.Forms.Panel pnlBanHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuâtToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cmbMon;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.Button btnDoiBan;
        private System.Windows.Forms.ComboBox cmbDoiBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem quanLiMonToolStripMenuItem;
    }
}