namespace QUANLICAFE.PresentationTier
{
    partial class FrmQuanLiMon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDanhSachMon = new System.Windows.Forms.DataGridView();
            this.coMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coMaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUAN LI MON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chon Danh Muc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ten Mon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh Sach Mon";
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(183, 54);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(437, 21);
            this.cmbDanhMuc.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(183, 134);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(437, 20);
            this.txtGia.TabIndex = 3;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(183, 95);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(437, 20);
            this.txtTenMon.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gia";
            // 
            // dgvDanhSachMon
            // 
            this.dgvDanhSachMon.AllowUserToAddRows = false;
            this.dgvDanhSachMon.AllowUserToDeleteRows = false;
            this.dgvDanhSachMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coMaMon,
            this.coTenMon,
            this.coGia,
            this.coTenDanhMuc,
            this.coMaDanhMuc});
            this.dgvDanhSachMon.Location = new System.Drawing.Point(46, 190);
            this.dgvDanhSachMon.Name = "dgvDanhSachMon";
            this.dgvDanhSachMon.ReadOnly = true;
            this.dgvDanhSachMon.Size = new System.Drawing.Size(756, 177);
            this.dgvDanhSachMon.TabIndex = 4;
            this.dgvDanhSachMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMon_CellClick);
            // 
            // coMaMon
            // 
            this.coMaMon.HeaderText = "MaMon";
            this.coMaMon.Name = "coMaMon";
            this.coMaMon.ReadOnly = true;
            this.coMaMon.Visible = false;
            // 
            // coTenMon
            // 
            this.coTenMon.HeaderText = "Ten Mon";
            this.coTenMon.Name = "coTenMon";
            this.coTenMon.ReadOnly = true;
            // 
            // coGia
            // 
            this.coGia.HeaderText = "Gia";
            this.coGia.Name = "coGia";
            this.coGia.ReadOnly = true;
            // 
            // coTenDanhMuc
            // 
            this.coTenDanhMuc.HeaderText = "TenDanhMuc";
            this.coTenDanhMuc.Name = "coTenDanhMuc";
            this.coTenDanhMuc.ReadOnly = true;
            // 
            // coMaDanhMuc
            // 
            this.coMaDanhMuc.HeaderText = "MaDanhMuc";
            this.coMaDanhMuc.Name = "coMaDanhMuc";
            this.coMaDanhMuc.ReadOnly = true;
            this.coMaDanhMuc.Visible = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(682, 54);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(682, 135);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cap Nhat";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(682, 95);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmQuanLiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(911, 377);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSachMon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.cmbDanhMuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLiMon";
            this.Text = "Quan Li Mon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDanhSachMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn coGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMaDanhMuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
    }
}