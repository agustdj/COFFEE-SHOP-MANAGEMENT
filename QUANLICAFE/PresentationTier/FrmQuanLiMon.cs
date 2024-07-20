using QUANLICAFE.Model;
using QUANLICAFE.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLICAFE.PresentationTier
{
    public partial class FrmQuanLiMon : Form
    {
        int indexcellclick =-1; int ma = -1;
        public FrmQuanLiMon()
        {
            InitializeComponent();
            this.Load += FrmQuanLiMon_Load;
            CaiDatDieuKien();
        }

        private void CaiDatDieuKien()
        {
            cmbDanhMuc.DisplayMember = "TenDanhMuc";
            cmbDanhMuc.ValueMember = "MaDanhMuc";
            cmbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmQuanLiMon_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadDanhSachMon();
            CaiDatChucNang();
            CaiDatMacDinh();
        }

        private void CaiDatMacDinh()
        {
            txtTenMon.Text = "";
            txtGia.Text = "";
            cmbDanhMuc.SelectedIndex = 0;
        }

        private void CaiDatChucNang()
        {
            bool trangthai = (indexcellclick==-1);
            btnThem.Enabled = trangthai;
            btnCapNhat.Enabled = btnXoa.Enabled = !trangthai;
        }

        private void LoadDanhMuc()
        {
            using (var dbcontext = new Model1())
            {
                cmbDanhMuc.DataSource = dbcontext.DanhMucs.Select(x => new { x.TenDanhMuc, x.MaDanhMuc }).ToList();
            }
        }

        private void LoadDanhSachMon()
        {
            dgvDanhSachMon.Rows.Clear();
            using (var dbcontext = new Model1())
            {
                foreach (var item in dbcontext.Mons.Select(x => new ViewModel.ThongTinMon { MaMon = x.MaMon, TenMon = x.TenMon, Gia = x.Dongia, TenDanhMuc = x.DanhMuc.TenDanhMuc, MaDanhMuc = x.MaDanhMuc }))
                {
                    int index = dgvDanhSachMon.Rows.Add();
                    dgvDanhSachMon.Rows[index].Cells[0].Value = item.MaMon;
                    dgvDanhSachMon.Rows[index].Cells[1].Value = item.TenMon;
                    dgvDanhSachMon.Rows[index].Cells[2].Value = item.Gia;
                    dgvDanhSachMon.Rows[index].Cells[3].Value = item.TenDanhMuc;
                    dgvDanhSachMon.Rows[index].Cells[4].Value = item.MaDanhMuc;
                }

            }
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            
           try 
            {
                using (var dbcontext = new Model1())
                {
                    Mon monmoi = new Mon()
                    {
                        TenMon = txtTenMon.Text,
                        MaDanhMuc = cmbDanhMuc.SelectedIndex + 1,
                        Dongia = int.Parse(txtGia.Text)
                    };
                    dbcontext.Mons.Add(monmoi);
                    dbcontext.SaveChanges();
                    LoadDanhSachMon();
                    MessageBox.Show("Them thanh cong!");
                }
                CaiDatMacDinh();
            }
            catch(Exception ex){
                MessageBox.Show("Ban chua nhap gia tien hoac tien mon");
            }
            CaiDatChucNang();

        }

        private bool KiemTraThonTinMonThem()
        {
            if(txtTenMon.Text == "")
            {
                MessageBox.Show("Vui long nhap ten mon");
                return false;
            }
            if(txtGia.Text == "")
            {
                MessageBox.Show("Vui long nhap gia tien");
                return false;
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            ma = int.Parse(dgvDanhSachMon.Rows[indexcellclick].Cells[0].Value.ToString());
            
            try
            {
                if (indexcellclick != -1)
                {
                    using (var dbcontext = new Model1())
                    {
                        Mon dbupdate = dbcontext.Mons.FirstOrDefault(p => p.MaMon == ma);
                        if (dbupdate != null)
                        {
                            dbupdate.MaDanhMuc = cmbDanhMuc.SelectedIndex + 1;
                            dbupdate.TenMon = txtTenMon.Text;
                            dbupdate.Dongia = int.Parse(txtGia.Text);
                            dbcontext.SaveChanges();
                            LoadDanhSachMon();
                            MessageBox.Show("Cap Nhat Thanh Cong");
                            indexcellclick = -1;
                        };
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message);
            }
            CaiDatChucNang();
            CaiDatMacDinh();
        }
        

        private void dgvDanhSachMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(indexcellclick == e.RowIndex)
            {
                dgvDanhSachMon.Rows[indexcellclick].Selected = false;
                indexcellclick = -1;
                CaiDatChucNang();
            }
            else
            {
                indexcellclick = e.RowIndex;
                txtTenMon.Text = dgvDanhSachMon.Rows[indexcellclick].Cells[1].Value.ToString();
                cmbDanhMuc.Text = dgvDanhSachMon.Rows[indexcellclick].Cells[3].Value.ToString();
                txtGia.Text = dgvDanhSachMon.Rows[indexcellclick].Cells[2].Value.ToString();
                CaiDatChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            ma = int.Parse(dgvDanhSachMon.Rows[indexcellclick].Cells[0].Value.ToString());
            
            try
            {
                if (indexcellclick != -1)
                {
                    CaiDatChucNang();
                    using (var dbcontext = new Model1())
                    {
                        Mon dbdelete = dbcontext.Mons.FirstOrDefault(p => p.MaMon == ma);
                        if (dbdelete != null)
                        {
                            dbcontext.Mons.Remove(dbdelete);
                            dbcontext.SaveChanges();
                        };
                        LoadDanhSachMon();
                        MessageBox.Show("Xoa Thanh Cong");
                        indexcellclick = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message);
            }
            CaiDatChucNang();
            CaiDatMacDinh();
        }
        
    }
}
