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
    public partial class FormKhachHang : Form
    {
        DataClasses1DataContext data;
        public FormKhachHang()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();
        }
        void LoadKhachHang()
        {
            var dskh = from kh in data.KhachHangs
                        select new
                        {
                            kh.MaKH,
                            kh.TenKH,
                            kh.DiaChi,
                            kh.DienThoai,
                            
                        };
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dskh;

        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
         private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txttenkh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtdienthoai.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtmakh.Text;
                kh.TenKH = txttenkh.Text; 
                kh.DiaChi = txtdiachi.Text;
                kh.DienThoai = txtdienthoai.Text;
                
                //nv.GioCong = Int32.Parse(txtgiocong.Text);
                data.KhachHangs.InsertOnSubmit(kh);
                data.SubmitChanges();
                LoadKhachHang();

            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
                LoadKhachHang();

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang dskh = (from kh in data.KhachHangs
                                 where kh.MaKH == txtmakh.Text.Trim()
                                 select kh).Single<KhachHang>(); 
                dskh.TenKH = txttenkh.Text;
                dskh.DiaChi = txtdiachi.Text;
                dskh.DienThoai = txtdienthoai.Text;
                
                //dsnv.GioCong = Int32.Parse(txtgiocong.Text);
                data.SubmitChanges();
                LoadKhachHang();
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Cập Nhật thất bại");
                LoadKhachHang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang dskh = (from kh in data.KhachHangs
                                  where kh.MaKH == txtmakh.Text.Trim()
                                  select kh).Single<KhachHang>();
                data.KhachHangs.DeleteOnSubmit(dskh);
                data.SubmitChanges();
                LoadKhachHang();

                MessageBox.Show("Xoá thành công !");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
                LoadKhachHang();
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

        private void btnLammoiform_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

       
    }
}
