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
    public partial class FormHome : System.Windows.Forms.Form
    {
        DataClasses1DataContext data;
        public FormHome()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {


        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                toolStrip1.Visible = false;
                panel1.Visible = true;
                txttk.Text = "";
                txtmk.Text = "";
            }
        }

        private void abcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            kh.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHangHoa h = new FormHangHoa();
            h.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            DangNhap ktradn = (from DangNhap in data.DangNhaps
                               where DangNhap.TenDangNhap == txttk.Text.Trim() && DangNhap.MatKhau == txtmk.Text
                               select DangNhap).SingleOrDefault();

            if (ktradn == null)

            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu?", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!");
                toolStrip1.Visible = true;
                panel1.Visible = false;
                this.IsMdiContainer = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn huỷ đăng nhập?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormTaiKhoan tk = new FormTaiKhoan();
            tk.Show();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLienHe lh = new FormLienHe();
            lh.ShowDialog();
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMayTinh mt = new FormMayTinh();
            mt.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormBanHang bh = new FormBanHang();
            bh.Show();
        }
    }
}

