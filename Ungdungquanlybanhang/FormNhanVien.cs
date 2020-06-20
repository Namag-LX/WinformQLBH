using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ungdungquanlybanhang
{
    public partial class FormNhanVien : Form
    {
        DataClasses1DataContext data;
        public FormNhanVien()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();
        }
        void LoadNhanVien()
        {
            var dssnv = from nv in data.NhanViens
                       select new
                       {
                           nv.MaNV,
                           nv.TenNV,
                           nv.GioiTinh,
                           nv.DiaChi,
                           nv.DienThoai,
                           nv.CapBac,
                           nv.GioCong, 
                       };
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dssnv;

        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttennv.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtgioitinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtdienthoai.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtcapbac.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtgiocong.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void thêmGiờCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemGioCong tgc = new FormThemGioCong();
            tgc.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txtmanv.Text;
                nv.TenNV = txttennv.Text;
                nv.GioiTinh = txtgioitinh.Text;
                nv.DiaChi = txtdiachi.Text;
                nv.DienThoai = txtdienthoai.Text;
                nv.CapBac = txtcapbac.Text;
                nv.GioCong = Int32.Parse(txtgiocong.Text);   
                data.NhanViens.InsertOnSubmit(nv);
                data.SubmitChanges();
                LoadNhanVien();
               
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
                LoadNhanVien();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien dsnv = (from nv in data.NhanViens
                                    where nv.MaNV == txtmanv.Text.Trim()
                                    select nv).Single<NhanVien>();
                dsnv.TenNV = txttennv.Text;
                dsnv.GioiTinh = txtgioitinh.Text;
                dsnv.DiaChi = txtdiachi.Text;
                dsnv.DienThoai = txtdienthoai.Text;
                dsnv.CapBac = txtcapbac.Text;
                dsnv.GioCong = Int32.Parse(txtgiocong.Text);
                data.SubmitChanges();
                LoadNhanVien();
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Cập Nhật thất bại");
                LoadNhanVien();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien dsnv = (from nv in data.NhanViens
                                 where nv.MaNV == txtmanv.Text.Trim()
                                 select nv).Single<NhanVien>();
                data.NhanViens.DeleteOnSubmit(dsnv);
                data.SubmitChanges();
                LoadNhanVien();

                MessageBox.Show("Xoá thành công !");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
                LoadNhanVien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien dsnv = (from nv in data.NhanViens
                                 where nv.MaNV == txtmanv.Text.Trim()
                                 select nv).Single<NhanVien>();
                dsnv.TenNV = txttennv.Text ;
                dsnv.GioiTinh = txtgioitinh.Text; 
                dsnv.DiaChi = txtdiachi.Text;
                dsnv.DienThoai = txtdienthoai.Text;
                dsnv.CapBac = txtcapbac.Text;
                dsnv.GioCong = 0;
                data.SubmitChanges();
                LoadNhanVien();
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Cập Nhật thất bại");
                LoadNhanVien();

            }
        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLammoiform_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
    }
}
