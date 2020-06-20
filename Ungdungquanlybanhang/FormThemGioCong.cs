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
    public partial class FormThemGioCong : Form
    {
        DataClasses1DataContext data;
        public FormThemGioCong()
        {
            InitializeComponent();
            data = new DataClasses1DataContext();
        }
        


        private void label2_Click(object sender, EventArgs e)
        {

        }
        void LoadThemGioCong()
        {
            var tgc = from gc in data.NhanViens
                      select new
                      {
                       colmanv =gc.MaNV,
                        coltennv =gc.TenNV,
                           colgiocong=gc.GioCong,
                       };
            dtGV.DataSource = null;
            dtGV.DataSource = tgc;

        }
        

        private void FormThemGioCong_Load(object sender, EventArgs e)
        {
            LoadThemGioCong();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dtGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttennv.Text = dtGV.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnThemGioCong_Click(object sender, EventArgs e)
        {
            try { 
            NhanVien tgc = (from gc in data.NhanViens
                             where gc.MaNV == txtmanv.Text.Trim()
                             select gc).Single<NhanVien>();
            tgc.TenNV = txttennv.Text;
            tgc.GioCong = Int32.Parse(txtgiocong.Text) + tgc.GioCong;
            data.SubmitChanges();
            LoadThemGioCong();
                MessageBox.Show("Cập nhật thành công");  
            }
            catch
            {
                MessageBox.Show("Cập Nhật thất bại");
                LoadThemGioCong();
            }
        }
    }
}
