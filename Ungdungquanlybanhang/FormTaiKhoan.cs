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
    public partial class FormTaiKhoan : Form
    {
        DataClasses1DataContext data;
        public FormTaiKhoan()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();
        }
        void LoadTaiKhoan()
        {
            var dstk = from tk in data.DangNhaps
                       select new
                       {
                           coltdn=tk.TenDangNhap,
                           colmk=tk.MatKhau,
                           colmanv=tk.MaNV,

                       };
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dstk;

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txttdn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtmk.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtmanv.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DangNhap tk = new DangNhap();
                tk.TenDangNhap = txttdn.Text;
                tk.MatKhau = txtmk.Text;
                tk.MaNV = txtmanv.Text;
                data.DangNhaps.InsertOnSubmit(tk);
                data.SubmitChanges();
                LoadTaiKhoan();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
                LoadTaiKhoan();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try { 
            DangNhap sanpham = (from sp in data.DangNhaps
                                where sp.TenDangNhap == txttdn.Text.Trim()
                                select sp).Single<DangNhap>();
            sanpham.MatKhau = txtmk.Text;
            data.SubmitChanges();
            LoadTaiKhoan();
            MessageBox.Show("Cập nhật thành công");
            }
            catch { 
                MessageBox.Show("Cập Nhật thất bại");
                LoadTaiKhoan();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DangNhap sanpham = (from sp in data.DangNhaps
                                    where sp.TenDangNhap == txttdn.Text.Trim()
                                    select sp).Single<DangNhap>();
                data.DangNhaps.DeleteOnSubmit(sanpham);
                data.SubmitChanges();
                LoadTaiKhoan();

                MessageBox.Show("Xoá thành công !");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
                LoadTaiKhoan();
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

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien nv = new FormNhanVien();
            nv.Show();
        }

        private void btnLammoiform_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }
    }
}
