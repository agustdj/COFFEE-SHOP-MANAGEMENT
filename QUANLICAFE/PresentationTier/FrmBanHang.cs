using QUANLICAFE.Model;
using QUANLICAFE.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLICAFE.PresentationTier
{
    public partial class FrmBanHang : Form
    {
        Button btnBanDangChon;
        List<PhieuDatBan> danhsachDatBan = new List<PhieuDatBan> ();
        double tongtien = 0;
        double sogiamgia = 0;
        public FrmBanHang()
        {
            InitializeComponent();
            cmbDanhMuc.DisplayMember = "Ten";
            cmbDanhMuc.ValueMember = "Ma";
            cmbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbMon.DisplayMember = "TenMon";
            cmbMon.ValueMember = "MaMon";
            cmbMon.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbDoiBan.DisplayMember = "Ten";
            cmbDoiBan.ValueMember = "Ma";
            cmbDoiBan.DropDownStyle = ComboBoxStyle.DropDownList;

            nudGiamGia.TextChanged += NumGiamGia_TextChanged;

            btnBanDangChon = null;
        }
        private void NumGiamGia_TextChanged(object sender, EventArgs e)
        {
            float phantramgiamgia;
            if (!float.TryParse(nudGiamGia.Text, out phantramgiamgia))
                phantramgiamgia = 0;
            sogiamgia = phantramgiamgia / 100 * tongtien;
            txtTongTien.Text = (tongtien - sogiamgia).ToString();
            int maban = int.Parse((btnBanDangChon.Tag.ToString()));
            PhieuDatBan phieu = danhsachDatBan.FirstOrDefault(x => x.MaBan == maban);
        //    if (nudGiamGia.Value == 0)
         //   {
         //       if (!float.TryParse(nudGiamGia.Text, out phantramgiamgia))
          //          phantramgiamgia = 0;
                //   phantramgiamgia = (float)nudGiamGia.Value;
         //       phieu.PhanTramGiamGia = phantramgiamgia;
                sogiamgia = phantramgiamgia / 100 * tongtien;
                txtTongTien.Text = (tongtien - sogiamgia).ToString();
        //    }
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            KhoiTaoDanhSachBan();
            KhoiTaoDanhMuc();
            LoadDoiBan();
            CaiDatMacDinh();
        }

        private void LoadDoiBan()
        {
            using(Model1 dbcontext = new Model1())
            {
                cmbDoiBan.DataSource = dbcontext.BANs.Select(p => new { p.Maban, p.Tenban }).ToList();
                cmbDoiBan.DisplayMember = "TenBan";
                cmbDoiBan.ValueMember = "MaBan";
            }
        }

        private void CaiDatMacDinh()
        {
            cmbDanhMuc.SelectedIndex = 0;
            cmbMon.SelectedIndex = 0;
            nudSoLuong.Value = 0;
            nudGiamGia.Value = 0;
            txtTongTien.Text = "";
            cmbDoiBan.SelectedIndex = 0;
        }

        private void KhoiTaoDanhMuc()
        {
            using(Model1 dbContext = new Model1())
            {
                cmbDanhMuc.DataSource = dbContext.DanhMucs.Select(x => new { x.MaDanhMuc, x.TenDanhMuc }).ToList();
                cmbDanhMuc.DisplayMember = "TenDanhMuc";
                cmbDanhMuc.ValueMember = "MaDanhMuc";
            }
        }

        private void KhoiTaoDanhSachBan()
        {
            int x = 20, y = 20, i = 1;
            //toa do (x,y) cua Botton
            using (var dbContext = new Model1())
            {
                foreach(var item in dbContext.BANs.ToList())
                {
                    cmbDoiBan.Items.Add(item);

                    TaoBan(item.Maban,item.Tenban, x, y);
                    if (i++ % 5 == 0)
                    {
                        y += 75;
                        x = 20;
                        continue;
                    }
                    x += 75;
                }
            }
        }
               

        private void TaoBan(int ma, string ten, int x,int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x,y);
            btn.Size = new Size(70, 70);
            btn.Text = ten;
            btn.Tag = ma;
            btn.BackColor = Color.White;
            pnlBan.Controls.Add(btn);
            btn.Click += btn_Click;
            pnlBan.Controls.Add(btn);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if(btnBanDangChon == null && btn.BackColor != Color.Red)
            {
                btnBanDangChon = btn;
                btnBanDangChon.BackColor = Color.Yellow;
            }
            else if(btn != btnBanDangChon )
            {
                btnBanDangChon.BackColor = Color.White;
                btnBanDangChon = btn;
                btnBanDangChon.BackColor = Color.Yellow;
            }
            else
            {
                btnBanDangChon.BackColor = Color.White;
                btnBanDangChon = null;
            }
            if(btnBanDangChon  != null)
            {
                int maBan = int.Parse(btnBanDangChon.Tag.ToString());
                PhieuDatBan phieu = danhsachDatBan.FirstOrDefault(x => x.MaBan == maBan);
                if (phieu != null)
                {
                    LoadThongTinMon(phieu.DanhSachMon);
                }
                else dgvDanhSachMon.Rows.Clear();

                tongtien = TinhTien(maBan);
                txtTongTien.Text = tongtien.ToString();
                //    nudGiamGia.TextChanged += NumGiamGia_TextChanged;
                nudGiamGia.Value = 0;
                nudSoLuong.Value = 0;
            }
        }
       

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDanhMuc = int.Parse((cmbDanhMuc.SelectedIndex+1).ToString());
            using (var dbContext = new Model1())
            {
                cmbMon.DataSource = dbContext.Mons.Where(x =>x.MaDanhMuc == maDanhMuc).ToList();
                cmbMon.DisplayMember = "TenMon";
                cmbMon.ValueMember = "MaMon";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                int maban = int.Parse((btnBanDangChon.Tag.ToString()));
                PhieuDatBan phieu = danhsachDatBan.FirstOrDefault(x => x.MaBan == maban);
                if (phieu == null)
                {
                    phieu = new PhieuDatBan();
                    phieu.MaBan = maban;
                    danhsachDatBan.Add(phieu);
                    CapNhatTrangThaiban(true);
                }
                Mon mon = cmbMon.SelectedItem as Mon;
                ThongTinMon thongtinmmon = new ThongTinMon()
                {
                    MaMon = mon.MaMon,
                    TenMon = mon.TenMon,
                    Gia = mon.Dongia,
                    SoLuong = int.Parse(nudSoLuong.Value.ToString())
                };
                phieu.CapNhatMon(thongtinmmon);
                LoadThongTinMon(phieu.DanhSachMon);

                HienThiTongTien();
             //   nudGiamGia.TextChanged += NumGiamGia_TextChanged;

                tongtien = TinhTien(maban);
                txtTongTien.Text = tongtien.ToString();
                nudGiamGia.TextChanged += NumGiamGia_TextChanged;
                nudGiamGia.Value = 0;
            }
        }

        private void HienThiTongTien()
        {
            
        }

        private double TinhTien(int maban)
        {
            PhieuDatBan phieu = danhsachDatBan.FirstOrDefault(x => x.MaBan == maban);
            return (phieu != null) ? (double)phieu.DanhSachMon.Sum(x => x.ThanhTien):0;
        }

        private void CapNhatTrangThaiban(bool trangthai)
        {
            btnBanDangChon.Image = trangthai ? Image.FromFile("../../Resources/3.png") : null;
        }

        private void LoadThongTinMon(List<ThongTinMon> DanhSachMon)
        {
                dgvDanhSachMon.Rows.Clear();
                foreach(var item in DanhSachMon)
                {
                    int index = dgvDanhSachMon.Rows.Add();
                    dgvDanhSachMon.Rows[index].Cells[0].Value = item.TenMon;
                    dgvDanhSachMon.Rows[index].Cells[1].Value = item.SoLuong;
                    dgvDanhSachMon.Rows[index].Cells[2].Value = item.Gia;
                    dgvDanhSachMon.Rows[index].Cells[3].Value = item.ThanhTien;
                }
               
        }

    
    
        private bool KiemTraThongTin()
        {
            /*
                * if (btnBanChon == null)
           {
               MessageBox.Show("Vui long chon ban!");
               return;
           }
           int maBan = int.Parse(btnBanChon.Tag.ToString());
           PhieuDatBan phieu = danhSachPhieuDatBan.FirstOrDefault(x => x.MaBan == maBan);
           if (phieu == null)
           {
               MessageBox.Show("Vui long dat mon truoc khi thanh toan");
               return;
                */
            if (btnBanDangChon == null)
            {
                MessageBox.Show("Chua chon Ban!");
                return false;
            }
            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui long nhap so luong!");
                return false;
            }
            return true;
        }

        private void quanLiMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLiMon frm = new FrmQuanLiMon();
            if (KiemTraTonTai(frm)==false)
            {
                frm.Show();
            }
        }

        private bool KiemTraTonTai(Form form)
        {
            foreach(var item in this.MdiChildren)
            {
                if (item.GetType() == form.GetType())
                {
                    item.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btnDoiBan_Click(object sender, EventArgs e)
        {

            if(btnBanDangChon == null)
            {
                MessageBox.Show("Vui long chon ban de chuyen");
                return;
            }
            if(cmbDoiBan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon dich");
                return;
            }
            if(tongtien == 0)
            {
                MessageBox.Show("Ban chua chon mon, khong the chuyen!");
                return;
            }

            int mabanchuyen, mabandich;
            PhieuDatBan phieubanchuyen, phieubandich;
            mabanchuyen = int.Parse((btnBanDangChon.Tag.ToString()));
            mabandich = cmbDoiBan.SelectedIndex + 1;
            phieubanchuyen = danhsachDatBan.FirstOrDefault(p => p.MaBan == mabanchuyen);
            phieubandich = danhsachDatBan.FirstOrDefault(p => p.MaBan == mabandich);
            if (phieubandich != null)
            {
                foreach (var item in phieubanchuyen.DanhSachMon)
                {
                    phieubandich.CapNhatMon(item);
                }
                LoadThongTinMon(phieubandich.DanhSachMon);
                tongtien = TinhTien(mabandich);
                txtTongTien.Text = tongtien.ToString();
                danhsachDatBan.Remove(phieubanchuyen);
            }
            else
            {
                phieubanchuyen.MaBan = mabandich;
            }
            CapNhatTrangThaiban(false);
            btnBanDangChon.BackColor = Color.White;
            btnBanDangChon = pnlBan.Controls.OfType<Button>().FirstOrDefault(x=>x.Tag.ToString()==mabandich.ToString());
            btnBanDangChon.BackColor = Color.Yellow;
            CapNhatTrangThaiban(true);
        }
        void KiemTraThanhToan()
        {
            if (btnBanDangChon == null)
            {
                MessageBox.Show("Vui long chon ban!");
                return;
            }
            int maBan = int.Parse(btnBanDangChon.Tag.ToString());
            PhieuDatBan phieu = danhsachDatBan.FirstOrDefault(x => x.MaBan == maBan);
            if (phieu == null)
            {
                MessageBox.Show("Vui long dat mon truoc khi thanh toan");
                return;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int MaBan = int.Parse((btnBanDangChon.Tag.ToString()));
            PhieuDatBan phieu = danhsachDatBan.FirstOrDefault(p => p.MaBan == MaBan);
            //B2: luu hoa don, in hoa don
            HoaDon hd = new HoaDon();
            hd.MaBan = MaBan;
            hd.NgayDat = DateTime.Now;
            hd.ThanhTien = (decimal)tongtien;

            ChiTietHoaDon ct; //= new ChiTietHoaDon();
            foreach (var item in phieu.DanhSachMon)
            {
                ct = new ChiTietHoaDon();
                ct.MaMon = item.MaMon;
                ct.SoLuong = (int)item.SoLuong;
                //hd.ChiTietHoaDon.Add(ct);
            }
            try
            {
                using (var dbContext = new Model1())
                {
                    dbContext.HoaDons.Add(hd);
                    dbContext.SaveChanges();
                }
                //reset thong tin 
                btnBanDangChon.Image = null;
                btnBanDangChon.BackColor = Color.White;
                dgvDanhSachMon.Rows.Clear();
                txtTongTien.Text = String.Empty;
                danhsachDatBan.Remove(phieu);
                nudGiamGia.Value = 0;
                /*
                //in bill tinh tien
                if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //in hoa don
                    FrmInHoaDon frm = new FrmInHoaDon(phieu);
                    frm.ShowDialog();
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI " + ex.Message);
            }

        }
    }
}
