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

    public partial class FormBanHang : Form
    {
        DataClasses1DataContext data;
        public FormBanHang()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            hangBindingSource.DataSource = data.Hangs.ToList();
            lblNgayLapHD.Text = DateTime.Today.ToShortDateString();
        }
        private bool CheckValid()
        {  
            string strError = "";
            if (txtsoluongban.Text.Trim() == "")
                strError = "Bạn chưa nhập số lượng sản phẩm bán";
            txtsoluongban.Focus();
            if (strError != "")
            {
                MessageBox.Show(strError, "Thông Báo");
                return false;
            }
            return true;
        }
        private void btnThemsp_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                  return;
        else
            {
                int thanhtien;
                thanhtien = Convert.ToInt32(txtdongia.Text) * Convert.ToInt32(txtsoluongban.Text);
                lblthanhtien.Text = thanhtien.ToString();
                dgv_danhsachspban.Rows.Add(lblNgayLapHD.Text, txtmasp.Text,
                    cbbtensp.Text, txtdonvitinh.Text, txtdongia.Text, txtsoluongban.Text, lblthanhtien.Text);

            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgv_danhsachspban.Rows)
            {
                if (dgvr.Selected == true)
                {
                    dgv_danhsachspban.Rows.Remove(dgvr);
                }
            }
        }

        private void dgv_danhsachspban_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblNgayLapHD.Text = dgv_danhsachspban.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtmasp.Text = dgv_danhsachspban.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbbtensp.Text = dgv_danhsachspban.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdonvitinh.Text = dgv_danhsachspban.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtdongia.Text = dgv_danhsachspban.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsoluongban.Text = dgv_danhsachspban.Rows[e.RowIndex].Cells[5].Value.ToString();
            lblthanhtien.Text = dgv_danhsachspban.Rows[e.RowIndex].Cells[6].Value.ToString();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void label6_Click(object sender, EventArgs e)
        { }
        private void label7_Click(object sender, EventArgs e)
        { }

        private void dgv_danhsachspban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool CheckValidd()
        {
            
            string strError = "";
            if (txtkiemtrasdt.Text == "")
                strError = "Bạn chưa nhập số điện thoại";
            txtkiemtrasdt.Focus();
            if (strError != "")
            {
                MessageBox.Show(strError, "Thông Báo");
                return false;
            }
            return true;
        }
        void KiemTraTonTai()
        {

            dgv_kiemtrakh.Visible = true;
            dgv_kiemtrakh.DataSource = data.KhachHangs.Where(p => p.DienThoai.Equals(txtkiemtrasdt.Text.Trim()));
            btnThemkh.Enabled = true;
            
            //var b = from u in data.KhachHangs
            //       where u.DienThoai.Equals(a)
            //      select u;




        }
        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            if (CheckValidd() == false)
                return;
            else
            {
                try {
                    KiemTraTonTai();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
                }
                finally {
                    txtkiemtrasdt.Text = "";
                }
               
                
            }
            
        }

        private void txtmasp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemkh_Click(object sender, EventArgs e)
        {

        }
    }
}
