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
    public partial class FormHangHoa : Form
    {
        DataClasses1DataContext data;
        public FormHangHoa()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();
        }
        void LoadHang()
        {
            var dssp = from sp in data.Hangs
                       select new
                       {
                           sp.MaHang,
                           sp.TenHang,
                           sp.DonViTinh,
                           sp.DonGiaHang,
                           sp.MoTa,
                           sp.NhaCungCap,
                       };
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dssp;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            LoadHang();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDonViTinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMoTa.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNhaCungCap.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Hang sp = new Hang();
            sp.MaHang = txtMaHang.Text;
            sp.TenHang = txtTenHang.Text;
            sp.DonViTinh = txtDonViTinh.Text;
            sp.DonGiaHang = Int32.Parse(txtDonGia.Text);
            sp.MoTa = txtMoTa.Text;
            sp.NhaCungCap = txtNhaCungCap.Text;
            data.Hangs.InsertOnSubmit(sp);
            data.SubmitChanges();
            LoadHang();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
                LoadHang();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            Hang sanpham = (from sp in data.Hangs
                               where sp.MaHang == txtMaHang.Text.Trim()
                               select sp).Single<Hang>();
            sanpham.TenHang = txtTenHang.Text;
            sanpham.DonViTinh = txtDonViTinh.Text;
            sanpham.DonGiaHang = Int32.Parse(txtDonGia.Text);
            sanpham.MoTa = txtMoTa.Text;
            sanpham.NhaCungCap = txtNhaCungCap.Text;
            data.SubmitChanges();
            LoadHang();
            MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại");
                LoadHang();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            Hang sanpham = (from sp in data.Hangs
                               where sp.MaHang == txtMaHang.Text.Trim()
                               select sp).Single<Hang>();
            data.Hangs.DeleteOnSubmit(sanpham);
            data.SubmitChanges();
            LoadHang();
             
            MessageBox.Show("Xoá thành công !");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
                LoadHang();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnLammoiform_Click(object sender, EventArgs e)
        {
            LoadHang();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void LoadTimKiem() 
        {
            

            dataGridView1.DataSource = data.Hangs.Where(p=>p.TenHang.Contains(txttimkiem.Text));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadTimKiem();
        }
    }
}
