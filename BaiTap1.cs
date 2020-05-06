using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong4._1
{
    public partial class BaiTap1 : Form
    {
        public BaiTap1()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập a");
                txtA.Focus();
                return;
            }

            if (txtB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập b");
                txtB.Focus();
                return;
            }

            double tong = 0;
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            if (a < b)
            {
                for (double i = 0; i <= b; i++)
                {
                    tong = tong + i;
                }
            }
            else
            {
                for (double i = 0; i <= a; i++)
                {
                    tong = tong + i;
                }
            }                
          
            lbTong.Text = tong.ToString();
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            this.txtA.Clear();
            this.txtB.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
