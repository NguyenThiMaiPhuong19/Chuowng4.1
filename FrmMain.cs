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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void chàoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaoMung c1 = new FrmChaoMung();
            c1.Show();
        }

        private void tínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhTong c2 = new TinhTong();
            c2.Show();
        }

        private void bàiTập1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiTap1 c3 = new BaiTap1();
            c3.Show();
        }
    }
}
