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
    public partial class FormMayTinh : Form
    {
        Double giatriketqua = 0;
        String thuchientoantu = "";
        bool lathuchientutoan = false;
        public FormMayTinh()
        {
            InitializeComponent();
        }

        private void btnclick(object sender, EventArgs e)
        {
            if (txtketqua.Text == "0" || (lathuchientutoan))
                txtketqua.Clear();
            lathuchientutoan = false;
            Button button = (Button)sender;
            if(button.Text == ",")
            {
                if(!txtketqua.Text.Contains(","))
                    txtketqua.Text = txtketqua.Text + button.Text;
            }
            else
            txtketqua.Text = txtketqua.Text + button.Text;
            

        }

        private void toantuclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(giatriketqua!=0)
            {
                btnequal.PerformClick();
                thuchientoantu = button.Text;
                labeltoantuhientai.Text = giatriketqua + " " + thuchientoantu;
                lathuchientutoan = true;
            }else
            thuchientoantu = button.Text;
            giatriketqua = Double.Parse(txtketqua.Text);
            labeltoantuhientai.Text = giatriketqua + " " + thuchientoantu;
            lathuchientutoan = true;
        }

        private void clearendclick(object sender, EventArgs e)
        {
            txtketqua.Text = "0";
        }

        private void clearclick(object sender, EventArgs e)
        {
            txtketqua.Text = "0";
            giatriketqua = 0;
        }

        private void equalclick(object sender, EventArgs e)
        {
            switch(thuchientoantu)
            {
                case "+":
                    txtketqua.Text = (giatriketqua + Double.Parse(txtketqua.Text)).ToString();
                    break;
                case "-":
                    txtketqua.Text = (giatriketqua - Double.Parse(txtketqua.Text)).ToString();
                    break;
                case "X":
                    txtketqua.Text = (giatriketqua * Double.Parse(txtketqua.Text)).ToString();
                    break;
                case "/":
                    txtketqua.Text = (giatriketqua / Double.Parse(txtketqua.Text)).ToString();
                    break;
                default:
                    break;
            }
            giatriketqua = Double.Parse(txtketqua.Text);
            labeltoantuhientai.Text = "";
        }

        private void FormMayTinh_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtketqua.TextLength>0)
            {
                txtketqua.Text = txtketqua.Text.Substring(0, (txtketqua.TextLength - 1));
                if(txtketqua.TextLength == 0)
                {
                    txtketqua.Text = "0";
                }
            }
        }
    }
}
